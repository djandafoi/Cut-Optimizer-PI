using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PI.Forme
{
    public partial class KreiranjeStavkeRezneLIste : Form
    {
        public Plan_rezanja trenutnaReznaLista;
        public Korisnik korisnik;

        public KreiranjeStavkeRezneLIste()
        {
            InitializeComponent();
            PopuniKorisnika();
            PopuniMaterijale();
        }

        public KreiranjeStavkeRezneLIste(Plan_rezanja reznaLista)
        {
            InitializeComponent();
            trenutnaReznaLista = reznaLista;
            PopuniKorisnika();
            PopuniMaterijale();
            Dohvatistavke(trenutnaReznaLista);
        }

        //Funkcija koja za odabrani plan rezanja vraća stavke te rezne liste

        private void Dohvatistavke(Plan_rezanja trenutnaReznaLista)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var stavke = from p in db.Plan_rezanja
                             from sr in db.Stavka_rezanja
                             from s in db.Skladište
                             from mns in db.Materijal_na_Skladište
                             from m in db.Materijals
                             where p.ID_Plan == sr.Plan_ID && mns.Materijal_ID == sr.Materijal_ID && trenutnaReznaLista.ID_Plan == p.ID_Plan && sr.Materijal_ID == m.ID_Materijal
                             select new
                             {
                                 ID = sr.Materijal_ID,
                                 Naziv = m.Naziv_materijala,
                                 Kolicina = sr.Kolicina
                             };
                dgvStavkeRezneListe.DataSource = stavke.ToList();
            }
        }

        //Metoda koja popunjava combobox s materijalima

        private void PopuniMaterijale()
        {
            List<Materijal> materijali;
            using (var db = new CutOptimizerEntities3())
            {
                materijali = db.Materijals.ToList();
            }
            cmbMaterijali.DataSource = materijali;
            cmbMaterijali.DisplayMember = "Naziv_materijala";
        }

        //Metoda koja vraća trenutno prijavljenog korisnika u sustav

        private void PopuniKorisnika()
        {
            using (var db = new CutOptimizerEntities3())
            {
                string ime = "";
                string prezime = "";
                foreach (var item in db.Korisniks)
                {
                    if (item.Prijavljen == 1)
                    {
                        ime = item.Ime;
                        prezime = item.Prezime;
                        string preime = ime + " " + prezime;
                        txtKorisnik.Text = preime;
                    }
                }
            }
        }

        //Klikom na gumb se uneseni podaci spremaju u varijable, te se poziva funkcija za kreiranje novog plana rezanja

        private void btnSpremiReznuListu_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivRezneListe.Text;
            DateTime datum = DateTime.Parse(datumRezneListe.Text);
            using (var db = new CutOptimizerEntities3())
            {
                foreach (var item in db.Korisniks)
                {
                    if (item.Prijavljen == 1)
                    {
                        korisnik = item as Korisnik;
                    }
                }
            }
            KreiranjeNoveRezneListe(naziv, korisnik, datum);
        }

        //Funkcija koja kreira novu plan rezanja, te ga s unesenim podacima sprema u bazu podataka

        private void KreiranjeNoveRezneListe(string naziv, Korisnik korisnik, DateTime datum)
        {
            if (trenutnaReznaLista == null)
            {
                Plan_rezanja reznaLista = new Plan_rezanja
                {
                    Naziv_Plana = naziv,
                    Korisnik_ID = korisnik.ID_Korisnik,
                    Datum = datum,
                };
                using (var db = new CutOptimizerEntities3())
                {
                    db.Plan_rezanja.Add(reznaLista);
                    db.SaveChanges();
                }
                trenutnaReznaLista = reznaLista;
            }
            else
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Plan_rezanja.Attach(trenutnaReznaLista);
                    db.SaveChanges();
                }
            }
        }

        //Klikom na gumb uneseni podaci se spremaju u varijable, te se poziva funkcija za dodavanje stavki rezne liste

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Materijal materijal = cmbMaterijali.SelectedItem as Materijal;
            int kolicina = 0;
            kolicina = int.Parse(txtKolicina.Text);
            double duzina = double.Parse(txtDuzina.Text);
            double debjinaPile = double.Parse(txtDebljinaPile.Text);
            DodajStavku(materijal, kolicina, duzina, debjinaPile);
            Dohvatistavke(trenutnaReznaLista);
        }

        //Funkcija koja dodaje stavku rezne liste u bazu podataka

        private void DodajStavku(Materijal materijal, int kolicina, double duzina, double debjinaPile)
        {
            using (var db = new CutOptimizerEntities3())
            {
                if (trenutnaReznaLista != null)
                {
                    db.Plan_rezanja.Attach(trenutnaReznaLista);
                    db.Materijals.Attach(materijal);
                    Stavka_rezanja novaStavka = new Stavka_rezanja
                    {
                        Materijal_ID = materijal.ID_Materijal,
                        Kolicina = kolicina,
                        Skladiste_ID = 1,
                        Duzina_rezanja = Convert.ToDecimal(duzina),
                        Debljina_pile = Convert.ToDecimal(debjinaPile),
                        Plan_ID = trenutnaReznaLista.ID_Plan
                    };
                    db.Stavka_rezanja.Add(novaStavka);
                    db.SaveChanges();
                }
            }
        }

        //Klikom na gumb, dobiva se odabrana stavka, te se poziva funkcija za brisanje te stavke

        private void btnUkloniStavku_Click(object sender, EventArgs e)
        {
            Stavka_rezanja odabranaStavka = null;
            int id = Convert.ToInt32(dgvStavkeRezneListe.CurrentRow.Cells[0].Value);
            using (var db = new CutOptimizerEntities3())
            {
                var stavke = (from sr in db.Stavka_rezanja
                              where sr.Materijal_ID == id
                              select sr).ToList();
                foreach (Stavka_rezanja item in stavke)
                {
                    odabranaStavka = item;
                }
            }
            ObrisiStavku(odabranaStavka);
            Dohvatistavke(trenutnaReznaLista);
        }

        //Funkcija koja briše odabranu stavku iz baze podataka

        private void ObrisiStavku(Stavka_rezanja odabranaStavka)
        {
            if (odabranaStavka != null)
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Stavka_rezanja.Attach(odabranaStavka);
                    db.Stavka_rezanja.Remove(odabranaStavka);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno ste obrisali stavku rezne liste!");
            }
            else
            {
                MessageBox.Show("Nista odabrali stavku za brisanje!");
            }
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Izrada rezne liste.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

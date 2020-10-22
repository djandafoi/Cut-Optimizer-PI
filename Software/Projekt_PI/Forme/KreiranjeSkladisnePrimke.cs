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
    public partial class KreiranjeSkladisnePrimke : Form
    {

        public Skladišna_primka trenutnaSkladisnaPrimka;
        public Korisnik korisnik;

        public KreiranjeSkladisnePrimke()
        {
            InitializeComponent();
            PopuniKorisnika();
            PopuniMaterijale();
        }

        public KreiranjeSkladisnePrimke(Skladišna_primka skladisnaPrimka)
        {
            InitializeComponent();
            trenutnaSkladisnaPrimka = skladisnaPrimka;
            PopuniKorisnika();
            PopuniMaterijale();
            Dohvatistavke(trenutnaSkladisnaPrimka);
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

        //Klikom na gumb se uneseni podaci zapisuju u varijable, te se poziva funkcija za kreiranje nove skladišne primke

        private void btnSpremiPrimku_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Parse(datumSkladisnePrimke.Text);
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
            KreiranjeNoveSkladisnePrimke(korisnik, datum);
        }

        //Funkcija koja kreira novu skladišnu primku s unesenim podacima u bazi podataka

        private void KreiranjeNoveSkladisnePrimke(Korisnik korisnik, DateTime datum)
        {
            if (trenutnaSkladisnaPrimka == null)
            {
                Skladišna_primka skladisna_primka = new Skladišna_primka
                {
                    Korisnik_ID = korisnik.ID_Korisnik,
                    Datum = datum,
                };
                using (var db = new CutOptimizerEntities3())
                {
                    db.Skladišna_primka.Add(skladisna_primka);
                    db.SaveChanges();
                }
                trenutnaSkladisnaPrimka = skladisna_primka;
            }
            else
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Skladišna_primka.Attach(trenutnaSkladisnaPrimka);
                    trenutnaSkladisnaPrimka.Potvrda = 0;
                    db.SaveChanges();
                }
            }
        }

        //Klikom na gumb se uneseni podaci zapisuju u varijable, te se poziva funkcija za dodavanje stavke skladišne primke

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            Materijal materijal = cmbMaterijali.SelectedItem as Materijal;
            int kolicina = 0;
            try
            {
                kolicina = int.Parse(txtKolicina.Text);
                if (kolicina > 0)
                {
                    DodajStavku(materijal, kolicina);
                    Dohvatistavke(trenutnaSkladisnaPrimka);
                }
                else
                {
                    MessageBox.Show("Ne možete unijeti količinu manje od 1");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ne možete unijeti slova!");
                txtKolicina.Clear();
            }         
        }

        //Funkcija koja vraća stavke primke za odabranu skladišnu primku

        private void Dohvatistavke(Skladišna_primka trenutnaSkladisnaPrimka)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var stavke = from s in db.Skladišna_primka
                                          from sp in db.Stavka_primke
                                          from m in db.Materijals
                                          where s.ID_Primka == sp.Primka_ID && m.ID_Materijal == sp.Materijal_ID && trenutnaSkladisnaPrimka.ID_Primka == s.ID_Primka
                                          select new
                                          {
                                              ID = sp.Materijal_ID,
                                              Naziv = m.Naziv_materijala,
                                              Kolicina = sp.Kolicina
                                          };
                dgvStavke.DataSource = stavke.ToList();
            }
        }

        //Funkcija koja u bazu podataka sprema stavku skladišne primke

        private void DodajStavku(Materijal materijal, int kolicina)
        {
            using (var db = new CutOptimizerEntities3())
            {
                if (trenutnaSkladisnaPrimka != null)
                {
                    db.Skladišna_primka.Attach(trenutnaSkladisnaPrimka);
                    db.Materijals.Attach(materijal);
                    Stavka_primke novaStavka = new Stavka_primke
                    {
                        Materijal = materijal,
                        Skladišna_primka = trenutnaSkladisnaPrimka,
                        Kolicina = kolicina,
                        Primka_ID = trenutnaSkladisnaPrimka.ID_Primka,
                        Skladiste_ID = default
                    };
                    db.Stavka_primke.Add(novaStavka);
                    db.SaveChanges();

                }
            }
        }

        //Klikom na gumb se vraća odabrana stavka primke, te se poziva funkcija za brisanje

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            Stavka_primke odabranaPrimka = null;
            int id = Convert.ToInt32(dgvStavke.CurrentRow.Cells[0].Value);
            using (var db = new CutOptimizerEntities3())
            {
                var stavke = (from sp in db.Stavka_primke
                             where sp.Materijal_ID == id
                             select sp).ToList();
                foreach (Stavka_primke item in stavke)
                {
                    odabranaPrimka = item;
                }
            }
            ObrisiStavku(odabranaPrimka);
            Dohvatistavke(trenutnaSkladisnaPrimka);
        }

        //Funkcija koja briše odabranu stavku primke iz baze podataka

        private void ObrisiStavku(Stavka_primke odabranaStavka)
        {
            if (odabranaStavka != null)
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Stavka_primke.Attach(odabranaStavka);
                    db.Stavka_primke.Remove(odabranaStavka);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno ste obrisali stavku skladišne primke!");
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
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Kreiranje skladišne primke.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KalkulatorKolicina;

namespace Projekt_PI.Forme
{
    public partial class FrmSkladisnaPrimka : Form
    {

        public FrmSkladisnaPrimka()
        {
            InitializeComponent();
            DohvatiSkladisnePrimke();
        }

        //Metoda koja vraća sve skladišne primke, prikazuje ih u DataGridView-u

        private void DohvatiSkladisnePrimke()
        {
            using (var db = new CutOptimizerEntities3())
            {
                skladišna_primkaBindingSource.DataSource = db.Skladišna_primka.ToList();
            }

        }

        //Metoda koja vraća sve stavke skladišne primke odabrane u DataGridView-u

        public void DohvatiStavke(Skladišna_primka skladisnaPrimka)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var stavke = from s in db.Skladišna_primka
                             from sp in db.Stavka_primke
                             from m in db.Materijals
                             where s.ID_Primka == sp.Primka_ID && m.ID_Materijal == sp.Materijal_ID && skladisnaPrimka.ID_Primka == s.ID_Primka
                             select new
                             {
                                 ID = sp.Materijal_ID,
                                 Naziv = m.Naziv_materijala,
                                 Kolicina = sp.Kolicina
                             };
                dgvStavkeSkladisnePrimke.DataSource = stavke.ToList();
            }
        }

        //Funkcija koja poziva formu za kreiranje nove skladišne primke klikom na gumb

        private void btnNovaPrimka_Click(object sender, EventArgs e)
        {
            KreiranjeSkladisnePrimke novaPrimka = new KreiranjeSkladisnePrimke();
            novaPrimka.ShowDialog();
            DohvatiSkladisnePrimke();
        }

        //Metoda koja vraća odabrani redak, odnosno odabranu skladišnu primku iz DataGridView-a

        private void dgvMaterijali_SelectionChanged(object sender, EventArgs e)
        {
            Skladišna_primka skladisnaPrimka = dgvSkladisnePrimke.CurrentRow.DataBoundItem as Skladišna_primka;
            DohvatiStavke(skladisnaPrimka);
        }

        //Funkcija koja poziva brisanje skladišne primke klikom na gumb

        private void btnObrisiPrimku_Click(object sender, EventArgs e)
        {
            Skladišna_primka skladisnaPrimka = dgvSkladisnePrimke.CurrentRow.DataBoundItem as Skladišna_primka;
            ObrisiSkladisnuPrimku(skladisnaPrimka);
            DohvatiSkladisnePrimke();
        }

        //Funkcija koja briše odabranu skladišnu primku

        private void ObrisiSkladisnuPrimku(Skladišna_primka skladisnaPrimka)
        {
            if (skladisnaPrimka != null)
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Skladišna_primka.Attach(skladisnaPrimka);
                    db.Skladišna_primka.Remove(skladisnaPrimka);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno ste obrisali skladišnu primku!");
            }
            else
            {
                MessageBox.Show("Niste odabrali skladišnu primku!");
            }
        }

        //Metoda vraća odabranu skladišnu primku te poziva funkciju za provjeru polja za potvrdu

        private void btnPotvrdiPrimku_Click(object sender, EventArgs e)
        {
            Skladišna_primka skladisnaPrimka = dgvSkladisnePrimke.CurrentRow.DataBoundItem as Skladišna_primka;
            ProvjeraPotvrdenePrimke(skladisnaPrimka);
        }

        //Funkcija koja za odabranu skladišnu primku provjerava ako joj je polje potvrda = 1, ako jest tada se javlja obavijest da je primka unesena u skladište,
        //u suprotnom, stavke odabrane primke se unose na skladište (na skladište se unosi, materijali te njihova količina)

        private void ProvjeraPotvrdenePrimke(Skladišna_primka skladisnaPrimka)
        {
            using (var db = new CutOptimizerEntities3())
            {
                if (skladisnaPrimka != null)
                {
                    if (skladisnaPrimka.Potvrda == 1)
                    {
                        MessageBox.Show("Već je uneseno u skladište!");          
                    }
                    else
                    {
                        db.Skladišna_primka.Attach(skladisnaPrimka);
                        skladisnaPrimka.Potvrda = 1;
                        db.SaveChanges();


                        foreach (Stavka_primke item in skladisnaPrimka.Stavka_primke)
                        {

                            var upit = from m in db.Materijal_na_Skladište
                                       select m.Materijal_ID;
                            if (upit.ToList().Contains((int)item.Materijal_ID))
                            {
                                var kolicine = (from m in db.Materijals
                                                from ms in db.Materijal_na_Skladište
                                                where item.Materijal_ID == ms.Materijal_ID
                                                select ms.Kolicina).ToList();
                                int kolicina = (int)kolicine[0];
                                AzuriranjeStanjaSkladista((int)item.Materijal_ID, item.Kolicina, kolicina);
                            }
                            else
                            {
                                UnesiNaSkladiste((int)item.Materijal_ID, item.Kolicina);
                            }
                        }

                        for (int i = 0; i < skladisnaPrimka.Stavka_primke.Count; i++)
                        {
                            var materijali = from sp in db.Stavka_primke
                                             from p in db.Skladišna_primka
                                             where p.ID_Primka == sp.Primka_ID
                                             select new
                                             {
                                                 sp.Materijal.ID_Materijal
                                             };

                            var kolicine = from sp in db.Stavka_primke
                                           from p in db.Skladišna_primka
                                           from m in db.Materijals
                                           where p.ID_Primka == sp.Primka_ID
                                           select new
                                           {
                                               sp.Kolicina
                                           };
                        }
                    }
                }
            }
        
        }

        //Funkcija koja ažurira količinu materijala, ako već on postoji na skladištu

        Kalkuliraj kalkuliraj = new Kalkuliraj();

        private void AzuriranjeStanjaSkladista(int materijal_ID, int kolicina, int staraKolicina)
        {
            using (var db = new CutOptimizerEntities3())
            {
                int novaKolicina = kalkuliraj.Zbroji(staraKolicina, kolicina);
                var materijali = from m in db.Materijal_na_Skladište
                                 where m.Materijal_ID == materijal_ID
                                 select m;
                foreach (var item in materijali.ToList())
                {
                    item.Kolicina = novaKolicina;
                }
                db.SaveChanges();
            }
        }

        //Funkcija koja unosi materijale odabrane primke na skladište

        private void UnesiNaSkladiste(int materijal, int kolicina)
        {
            using (var db = new CutOptimizerEntities3())
            {
                Materijal_na_Skladište noviUnos = new Materijal_na_Skladište
                {
                    Skladiste_ID = 1,
                    Materijal_ID = materijal,
                    Kolicina = kolicina
                };
                db.Materijal_na_Skladište.Add(noviUnos);
                db.SaveChanges();
            }
        }

        //Sortiranje primki po datumu

        private void btnSortirajPoDatumu_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var upit = from s in db.Skladišna_primka
                           orderby s.Datum descending
                           select s;
                dgvSkladisnePrimke.DataSource = upit.ToList();
                db.SaveChanges();
            }
        }

        //Čišćenje sortiranja

        private void btnResetSort_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var upit = from s in db.Skladišna_primka
                           orderby s.ID_Primka ascending
                           select s;
                dgvSkladisnePrimke.DataSource = upit.ToList();
                db.SaveChanges();
            }
        }

        //Klikom na gumb za azuriranje vraća se odabrana primka te se otvara forma za kreiranje skladišne primke

        private void btnAzurirajPrimku_Click(object sender, EventArgs e)
        {
            Skladišna_primka skladisnaPrimka = dgvSkladisnePrimke.CurrentRow.DataBoundItem as Skladišna_primka;
            KreiranjeSkladisnePrimke azuriranje = new KreiranjeSkladisnePrimke(skladisnaPrimka);
            azuriranje.ShowDialog();
            DohvatiSkladisnePrimke();
        }

        //Izlaz iz trenutne forme klikom na sklikovni objekt

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Skladišne primke.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

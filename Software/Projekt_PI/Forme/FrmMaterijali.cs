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
    public partial class FrmMaterijali : Form
    {
        public FrmMaterijali()
        {
            InitializeComponent();
            DohvatiMaterijale();
        }

        //Izlaz iz trenutne forme pritiskom na slikovni objekt

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funkcija koja vraća sve materijale, prikazuje ih u DataGridView-u

        private void DohvatiMaterijale()
        {
            using (var db = new CutOptimizerEntities3())
            {
                materijalBindingSource.DataSource = db.Materijals.ToList();
            }
        }

        //Funkcija koja pokreće novu formu za dodavanje novog materijala

        private void btnNoviMaterijal_Click(object sender, EventArgs e)
        {
            DodavanjeMaterijala noviMaterijal = new DodavanjeMaterijala();
            noviMaterijal.ShowDialog();
            DohvatiMaterijale();
        }

        //Metoda koja poziva funkciju za provjeru unesenog teksta za pretraživanje materijala

        private void txtPretraziMaterijal_TextChanged(object sender, EventArgs e)
        {
            string pretraga = txtPretraziMaterijal.Text;
            PretraziMaterijal(pretraga);
        }

        //Funkcija koja provjerava unešeni tekst unutar textboxa za pretraživanje, vraća određene materijale ako njihovo ime sadrži upisani tekst

        private void PretraziMaterijal(string pretraga)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var querry = (from m in db.Materijals
                              where m.Naziv_materijala.Contains(pretraga)
                              select m);
                dgvMaterijali.DataSource = querry.ToList();
                db.SaveChanges();
            }
        }

        //Sortiranje svih materijala po nazivu

        private void btnSortirajPoNazivu_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var querry = from m in db.Materijals
                             orderby m.Naziv_materijala ascending
                             select m;
                dgvMaterijali.DataSource = querry.ToList();
                db.SaveChanges();
            }
        }

        //Sortiranje svih materijala po širini

        private void btnSortirajPoSirini_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var querry = from m in db.Materijals
                             orderby m.Sirina descending
                             select m;
                dgvMaterijali.DataSource = querry.ToList();
                db.SaveChanges();
            }
        }

        //Sortiranje svih materijala po dužini

        private void btnSortirajPoDuzini_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var querry = from m in db.Materijals
                             orderby m.Duzina descending
                             select m;
                dgvMaterijali.DataSource = querry.ToList();
                db.SaveChanges();
            }
        }

        //Čišćenje sortiranje (vraćanje na početno)

        private void btnResetSort_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var querry = from m in db.Materijals
                             orderby m.ID_Materijal ascending
                             select m;
                dgvMaterijali.DataSource = querry.ToList();
                db.SaveChanges();
            }
        }

        //Funkcija koja se poziva pritiskom na gumb za azuriranje materijala

        private void btnAzurirajOdabraniMaterijal_Click(object sender, EventArgs e)
        {
            Materijal odabraniMat = dgvMaterijali.CurrentRow.DataBoundItem as Materijal;
            DodavanjeMaterijala azuriraj = new DodavanjeMaterijala(odabraniMat);
            azuriraj.ShowDialog();
            DohvatiMaterijale();    
        }

        //Funkcija koja se poziva pritiskom na gumb za brisanje materijala

        private void btnObrisiMaterijal_Click(object sender, EventArgs e)
        {
            Materijal odabraniMaterijal = dgvMaterijali.CurrentRow.DataBoundItem as Materijal;
            ObrisiMaterijal(odabraniMaterijal);
            DohvatiMaterijale();
        }

        //Funkcija koja briše materijal odabran u DataGridView-u

        private void ObrisiMaterijal(Materijal odabraniMaterijal)
        {
            if (odabraniMaterijal != null)
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Materijals.Attach(odabraniMaterijal);
                    db.Materijals.Remove(odabraniMaterijal);
                    db.SaveChanges();
                }
                MessageBox.Show("Uspješno ste obrisali materijal!");
            }
            else
            {
                MessageBox.Show("Niste odabrali materijal!");
            }
        }

        ////Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Materijali.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

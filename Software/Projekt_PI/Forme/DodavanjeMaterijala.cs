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
    public partial class DodavanjeMaterijala : Form
    {
        public Materijal trenutniMaterijal;

        public DodavanjeMaterijala()
        {
            InitializeComponent();
        }

        public DodavanjeMaterijala(Materijal odabraniMat)
        {
            InitializeComponent();
            trenutniMaterijal = odabraniMat;
            UcitaniPodaci();
        }

        //Funkcija koja vraća podatke iz baze podataka s onim obilježjima ovisno o tome koji je materijal bio odabran

        public void UcitaniPodaci()
        {
            txtNazivMaterijala.Text = trenutniMaterijal.Naziv_materijala.ToString();
            txtSirinaMaterijala.Text = trenutniMaterijal.Sirina.ToString();
            txtDuzinaMaterijala.Text = trenutniMaterijal.Duzina.ToString();
            txtDebljinaMaterijala.Text = trenutniMaterijal.Debljina.ToString();  
        }

        //Klikom na gumb uneseni podaci se spremaju u varijable, te se poziva funkcija za dodavanje novog materijala

        public void btnDodajSirovinu_Click(object sender, EventArgs e)
        {
            string naziv_materijala = txtNazivMaterijala.Text;
            double sirina = double.Parse(txtSirinaMaterijala.Text);
            double duzina = double.Parse(txtDuzinaMaterijala.Text);
            double debljina = double.Parse(txtDebljinaMaterijala.Text);
            DodavanjeNovogMaterijala(naziv_materijala, sirina, duzina, debljina);
            this.Close();
        }

        //Funkcija koja dodaje novi materijal u bazu podataka

        private void DodavanjeNovogMaterijala(string naziv_materijala, double sirina, double duzina, double debljina)
        {
            if (trenutniMaterijal == null)
            {
                Materijal materijal = new Materijal
                {                    
                    Naziv_materijala = naziv_materijala,
                    Sirina = Convert.ToDecimal(sirina),
                    Duzina = Convert.ToDecimal(duzina),
                    Debljina = Convert.ToDecimal(debljina)                    
                };
                using (var db = new CutOptimizerEntities3())
                {
                    db.Materijals.Add(materijal);
                    db.SaveChanges();
                }
                trenutniMaterijal = materijal;
            }
            else
            {
                using (var db = new CutOptimizerEntities3())
                {
                    db.Materijals.Attach(trenutniMaterijal);
                    trenutniMaterijal.Naziv_materijala = txtNazivMaterijala.Text;
                    trenutniMaterijal.Sirina = Convert.ToDecimal(txtSirinaMaterijala.Text);
                    trenutniMaterijal.Duzina = Convert.ToDecimal(txtDuzinaMaterijala.Text);
                    trenutniMaterijal.Debljina = Convert.ToDecimal(txtDebljinaMaterijala.Text);
                    db.SaveChanges();
                }
            }
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Dodavanje Materijala.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Izlaz iz trenutne forme pritiskom na slikovni objekt

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

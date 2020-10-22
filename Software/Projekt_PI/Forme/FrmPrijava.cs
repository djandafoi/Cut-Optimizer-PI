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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        //Izlazak iz programa klikom na slikovni objekt

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Uzimanje vrijednosti zapisene u textboxu, te pozivanje funkcije za provjeru korisnika

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnicko_ime = txtBoxKorIme.Text;
            string lozinka = txtBoxLozinka.Text;
            
            ProvjeraKorisnika(korisnicko_ime, lozinka);
        }

        //Funkcija provjera korisnika - provjerava ako se uneseni podaci za korisnika podudaraju s podacima za korisnika u bazi podataka

        private void ProvjeraKorisnika(string Korisnicko_Ime, string Lozinka)
        {
            bool dobarKorisnik = false;
            using (var db = new CutOptimizerEntities3())
            {
                foreach (var item in db.Korisniks.ToList())
                {
                    if (item.Korisnicko_Ime == Korisnicko_Ime && item.Lozinka == Lozinka)
                    {
                        dobarKorisnik = true;
                        item.Prijavljen = 1;                        
                    }
                }
            db.SaveChanges();
            }
            if (dobarKorisnik == true)
            {
                this.Hide();
                FrmGlavna glavnaForma = new FrmGlavna();                
                glavnaForma.ShowDialog();              

            }
            else if (dobarKorisnik == false)
            {
                MessageBox.Show("Neispravno uneseno korisničko ime ili lozinka!");
            }
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Prijava.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

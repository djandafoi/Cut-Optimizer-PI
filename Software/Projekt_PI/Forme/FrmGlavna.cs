using Projekt_PI.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_PI
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        //Odjava iz programa klikom na gumb - vraćanje na formu za Prijavu

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                foreach (var item in db.Korisniks.ToList())
                {
                    if (item.Prijavljen == 1)
                    {                        
                        item.Prijavljen = 0;
                    }
                }
            db.SaveChanges();
            }
            this.Hide();
            FrmPrijava prijava = new FrmPrijava();
            prijava.ShowDialog();
            
        }

        //Pokretanje forme za dodavanje sirovina/materijala

        private void btnDodajSirovinu_Click(object sender, EventArgs e)
        {
            FrmMaterijali dodavanje_sirovina = new FrmMaterijali();
            dodavanje_sirovina.ShowDialog();
        }

        //Pokretanje forme za pregled stanja zaliha

        private void btnPregledSirovina_Click(object sender, EventArgs e)
        {
            FrmPregledStanjaZaliha pregled_sirovina = new FrmPregledStanjaZaliha();
            pregled_sirovina.ShowDialog();
        }

        //Pokretanje forme za izradu rezne liste

        private void btnIzradaRezneListe_Click(object sender, EventArgs e)
        {
            FrmIzradaRezneListe izrada_listi = new FrmIzradaRezneListe();
            izrada_listi.ShowDialog();
        }

        //Pokretanje forme za dodavanje sirovina/materijala

        private void btnPregledReznihListi_Click(object sender, EventArgs e)
        {
            FrmPregledReznihListi pregled_listi = new FrmPregledReznihListi();
            pregled_listi.ShowDialog();
        }

        //Prikaz obavijesti vezane uz HELP

        private void btnPomoc_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Za pomoć i više informacije pritisnite tipku F1 u bilo kojem dijelu programa!");
        }

        //Pokretanje forme za dodavanje skladisne primke

        private void btnSkladisnePrimke_Click(object sender, EventArgs e)
        {
            FrmSkladisnaPrimka skladisne_primke = new FrmSkladisnaPrimka();
            skladisne_primke.ShowDialog();
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Glavni izbornik.htm");
                return true;    
            }            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

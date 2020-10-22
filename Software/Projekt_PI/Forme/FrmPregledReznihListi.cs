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
    public partial class FrmPregledReznihListi : Form
    {
        public FrmPregledReznihListi()
        {
            InitializeComponent();
            DohvatiRezneListe();
        }

        private void DohvatiRezneListe()
        {
            using (var db = new CutOptimizerEntities3())
            {
                plan_rezanjaBindingSource.DataSource = db.Plan_rezanja.ToList();
            }
        }



        //Izlaz iz trenutne forme pritiskom na slikovni objekt

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Pregled reznih listi.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnOptimiziraj_Click(object sender, EventArgs e)
        {
            Plan_rezanja reznaLista = dgvRezneListe.CurrentRow.DataBoundItem as Plan_rezanja;
           // OptimizirajListu(reznaLista);
        }

        
        decimal c;
        int n;
        decimal[] duzine_stavke = new decimal[1];


        private void OptimizirajListu(Plan_rezanja reznaLista)
        {

            using (var db = new CutOptimizerEntities3())
            {
                var duzine = (from sr in db.Stavka_rezanja
                              from pr in db.Plan_rezanja
                              where reznaLista.ID_Plan == sr.Plan_ID
                             select sr.Duzina_rezanja).ToList();
                var kolicine = (from sr in db.Stavka_rezanja
                                from pr in db.Plan_rezanja
                                where reznaLista.ID_Plan == sr.Plan_ID
                               select sr.Kolicina).ToList();
                var materijali = (from m in db.Materijals
                                 from ms in db.Materijal_na_Skladište
                                 from sr in db.Stavka_rezanja
                                 where m.ID_Materijal == sr.Materijal_ID && m.ID_Materijal == ms.Materijal_ID
                                 select m.Duzina).ToList();
                var stavke = from sr in db.Stavka_rezanja
                             from pr in db.Plan_rezanja
                             where sr.Plan_ID == reznaLista.ID_Plan
                             select sr;
                txtIspis.Text = "";
                

                c = Convert.ToDecimal(materijali[0]);

                for (int i = 0; i < kolicine[0]; i++)
                {
                    duzine_stavke[i] = duzine[0];
                }

                n = duzine_stavke.Length;
                int res = 0;
                decimal[] bin_rem = new decimal[n];

                decimal[][] popis = new decimal[(int)kolicine[0]][];

                for (int i = 0; i < n; i++)
                {
                    int j;
                    //inicijalizacija min mjesta i indexa spremnika
                    //bi je optimiziran materijal koji sadrzi stavke                
                    for (j = 0; j < res; j++)
                    {
                        if (bin_rem[j] >= duzine_stavke[i])
                        {
                            bin_rem[j] = bin_rem[j] - duzine_stavke[i];
                            break;
                        }
                    }
                    popis[j][i] = duzine_stavke[i];
                    // ako se materijal više ne može iskoristit onda koristi novi 
                    if (j == res)
                    {
                        bin_rem[res] = c - duzine_stavke[i];
                        res++;
                    }
                }
                foreach (var item in popis)
                {
                    MessageBox.Show(item.ToString());
                }
            }

        }
    }
}

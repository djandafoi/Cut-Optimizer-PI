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
    public partial class FrmPregledStanjaZaliha : Form
    {
        public FrmPregledStanjaZaliha()
        {
            InitializeComponent();
        }

        //Izlaz iz trenutne forme klikom na slikovni objekt

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        //Pozivanje HELP funkcije pritiskom F1 tipke

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Skladište.htm");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Kod učitavanje forme se u DataSourceve koji se koriste za izvještaje se pune podaci

        private void FrmPregledStanjaZaliha_Load(object sender, EventArgs e)
        {
            using (var db = new CutOptimizerEntities3())
            {
                var materijali = from m in db.Materijals
                           select m;
                var matNaSkladistu = from ms in db.Materijal_na_Skladište
                                     from m in db.Materijals
                                     where ms.Materijal_ID == m.ID_Materijal
                                     select ms;
                //List<Materijal> materijali = upit.ToList();
                MaterijalBindingSource.DataSource = materijali.ToList();
                materijalnaSkladišteDataTableBindingSource.DataSource = matNaSkladistu.ToList();
            }
            this.rpvStanjeSkladista.RefreshReport();
        }
    }

}

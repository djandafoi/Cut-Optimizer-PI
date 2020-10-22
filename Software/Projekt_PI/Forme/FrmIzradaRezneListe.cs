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
    public partial class FrmIzradaRezneListe : Form
    {

        public FrmIzradaRezneListe()
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



		private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzradiReznuListu_Click(object sender, EventArgs e)
		{
			KreiranjeStavkeRezneLIste novaReznaLista = new KreiranjeStavkeRezneLIste();
			novaReznaLista.ShowDialog();
			DohvatiRezneListe();
		}

		private void btnObrisiReznuListu_Click(object sender, EventArgs e)
		{
			Plan_rezanja reznaLista = dgvRezneListe.CurrentRow.DataBoundItem as Plan_rezanja;
			ObrisiReznuListu(reznaLista);
		}

		private void ObrisiReznuListu(Plan_rezanja reznaLista)
		{
			if (reznaLista != null)
			{
				using (var db = new CutOptimizerEntities3())
				{
					db.Plan_rezanja.Attach(reznaLista);
					db.Plan_rezanja.Remove(reznaLista);
					db.SaveChanges();
				}
				MessageBox.Show("Uspješno ste obrisali reznu listu!");
			}
			else
			{
				MessageBox.Show("Niste odabrali reznu listu!");
			}
		}

		private void btnAzurirajReznuListu_Click(object sender, EventArgs e)
		{
			Plan_rezanja reznaLista = dgvRezneListe.CurrentRow.DataBoundItem as Plan_rezanja;
			KreiranjeStavkeRezneLIste azuziranje = new KreiranjeStavkeRezneLIste(reznaLista);
			azuziranje.ShowDialog();
			DohvatiRezneListe();
		}

		private void btnSortirajPoDatumu_Click(object sender, EventArgs e)
		{
			using(var db = new CutOptimizerEntities3())
			{
				var upit = from p in db.Plan_rezanja
						   orderby p.Datum descending
						   select p;
				dgvRezneListe.DataSource = upit.ToList();
				db.SaveChanges();
			}
		}

		private void btnSortPoKorisniku_Click(object sender, EventArgs e)
		{
			using (var db = new CutOptimizerEntities3())
			{
				var upit = from k in db.Plan_rezanja
						   orderby k.Korisnik descending
						   select k;
				dgvRezneListe.DataSource = upit.ToList();
				db.SaveChanges();
			}
		}

		private void btnResetSort_Click(object sender, EventArgs e)
		{
			using (var db = new CutOptimizerEntities3())
			{
				var upit = from p in db.Plan_rezanja
						   orderby p.ID_Plan ascending
						   select p;
				dgvRezneListe.DataSource = upit.ToList();
				db.SaveChanges();
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.F1)
			{
				Help.ShowHelp(this, "../../../Help/CutOptimizerHelp.chm", HelpNavigator.Topic, "Upravljanje reznim listama.htm");
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void dgvRezneListe_SelectionChanged(object sender, EventArgs e)
		{
			Plan_rezanja reznaLista = dgvRezneListe.CurrentRow.DataBoundItem as Plan_rezanja;
			DohvatiStavke(reznaLista);
		}

		private void DohvatiStavke(Plan_rezanja reznaLista)
		{
			using (var db = new CutOptimizerEntities3())
			{
				var stavke = from pr in db.Plan_rezanja
							 from sr in db.Stavka_rezanja
							 from m in db.Materijals
							 where pr.ID_Plan == sr.Plan_ID && m.ID_Materijal == sr.Materijal_ID && reznaLista.ID_Plan == pr.ID_Plan
							 select new
							 {
								 ID = sr.Materijal_ID,
								 Naziv = m.Naziv_materijala,
								 Kolicina = sr.Kolicina,
								 Duzina = sr.Duzina_rezanja
							 };
				dgvStavkeRezneListe.DataSource = stavke.ToList();
			}
		}
	}
}

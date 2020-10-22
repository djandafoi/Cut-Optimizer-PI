namespace Projekt_PI.Forme
{
    partial class FrmPregledStanjaZaliha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvStanjeSkladista = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaterijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalnaSkladišteDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MaterijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnaSkladišteDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvStanjeSkladista
            // 
            this.rpvStanjeSkladista.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsMaterijal";
            reportDataSource1.Value = this.MaterijalBindingSource;
            reportDataSource2.Name = "DsMatNaSkladistu";
            reportDataSource2.Value = this.materijalnaSkladišteDataTableBindingSource;
            this.rpvStanjeSkladista.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvStanjeSkladista.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvStanjeSkladista.LocalReport.ReportEmbeddedResource = "Projekt_PI.Forme.StanjeSkladišta.rdlc";
            this.rpvStanjeSkladista.Location = new System.Drawing.Point(0, 0);
            this.rpvStanjeSkladista.Name = "rpvStanjeSkladista";
            this.rpvStanjeSkladista.ServerReport.BearerToken = null;
            this.rpvStanjeSkladista.Size = new System.Drawing.Size(722, 538);
            this.rpvStanjeSkladista.TabIndex = 0;
            // 
            // MaterijalBindingSource
            // 
            this.MaterijalBindingSource.DataSource = typeof(Projekt_PI.Materijal);
            // 
            // materijalnaSkladišteDataTableBindingSource
            // 
            this.materijalnaSkladišteDataTableBindingSource.DataSource = typeof(Projekt_PI.PI20_059_DBDataSet.Materijal_na_SkladišteDataTable);
            // 
            // FrmPregledStanjaZaliha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 538);
            this.Controls.Add(this.rpvStanjeSkladista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPregledStanjaZaliha";
            this.Text = "Pregled stanja zaliha";
            this.Load += new System.EventHandler(this.FrmPregledStanjaZaliha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalnaSkladišteDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn materijalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivmaterijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer rpvStanjeSkladista;
        private System.Windows.Forms.BindingSource MaterijalBindingSource;
        private System.Windows.Forms.BindingSource materijalnaSkladišteDataTableBindingSource;
    }
}
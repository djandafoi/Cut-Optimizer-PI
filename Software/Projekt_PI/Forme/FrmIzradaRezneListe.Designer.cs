namespace Projekt_PI.Forme
{
    partial class FrmIzradaRezneListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzradaRezneListe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezneListe = new System.Windows.Forms.DataGridView();
            this.iDPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPlanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_rezanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzradiReznuListu = new System.Windows.Forms.Button();
            this.btnObrisiReznuListu = new System.Windows.Forms.Button();
            this.btnAzurirajReznuListu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStavkeRezneListe = new System.Windows.Forms.DataGridView();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.btnSortirajPoDatumu = new System.Windows.Forms.Button();
            this.btnSortPoKorisniku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezneListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_rezanjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRezneListe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(657, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(216, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "UPRAVLJANJE REZNIM LISTAMA";
            // 
            // dgvRezneListe
            // 
            this.dgvRezneListe.AutoGenerateColumns = false;
            this.dgvRezneListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRezneListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezneListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPlanDataGridViewTextBoxColumn,
            this.nazivPlanaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.Korisnik_ID});
            this.dgvRezneListe.DataSource = this.plan_rezanjaBindingSource;
            this.dgvRezneListe.Location = new System.Drawing.Point(12, 162);
            this.dgvRezneListe.Name = "dgvRezneListe";
            this.dgvRezneListe.Size = new System.Drawing.Size(541, 166);
            this.dgvRezneListe.TabIndex = 25;
            this.dgvRezneListe.SelectionChanged += new System.EventHandler(this.dgvRezneListe_SelectionChanged);
            // 
            // iDPlanDataGridViewTextBoxColumn
            // 
            this.iDPlanDataGridViewTextBoxColumn.DataPropertyName = "ID_Plan";
            this.iDPlanDataGridViewTextBoxColumn.HeaderText = "ID_Plan";
            this.iDPlanDataGridViewTextBoxColumn.Name = "iDPlanDataGridViewTextBoxColumn";
            // 
            // nazivPlanaDataGridViewTextBoxColumn
            // 
            this.nazivPlanaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_Plana";
            this.nazivPlanaDataGridViewTextBoxColumn.HeaderText = "Naziv_Plana";
            this.nazivPlanaDataGridViewTextBoxColumn.Name = "nazivPlanaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // Korisnik_ID
            // 
            this.Korisnik_ID.DataPropertyName = "Korisnik_ID";
            this.Korisnik_ID.HeaderText = "Korisnik_ID";
            this.Korisnik_ID.Name = "Korisnik_ID";
            // 
            // plan_rezanjaBindingSource
            // 
            this.plan_rezanjaBindingSource.DataSource = typeof(Projekt_PI.Plan_rezanja);
            // 
            // btnIzradiReznuListu
            // 
            this.btnIzradiReznuListu.BackColor = System.Drawing.Color.White;
            this.btnIzradiReznuListu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnIzradiReznuListu.FlatAppearance.BorderSize = 3;
            this.btnIzradiReznuListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzradiReznuListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzradiReznuListu.Location = new System.Drawing.Point(559, 162);
            this.btnIzradiReznuListu.Name = "btnIzradiReznuListu";
            this.btnIzradiReznuListu.Size = new System.Drawing.Size(151, 45);
            this.btnIzradiReznuListu.TabIndex = 36;
            this.btnIzradiReznuListu.Text = "Izradi reznu listu";
            this.btnIzradiReznuListu.UseVisualStyleBackColor = false;
            this.btnIzradiReznuListu.Click += new System.EventHandler(this.btnIzradiReznuListu_Click);
            // 
            // btnObrisiReznuListu
            // 
            this.btnObrisiReznuListu.BackColor = System.Drawing.Color.White;
            this.btnObrisiReznuListu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnObrisiReznuListu.FlatAppearance.BorderSize = 3;
            this.btnObrisiReznuListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiReznuListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiReznuListu.Location = new System.Drawing.Point(559, 292);
            this.btnObrisiReznuListu.Name = "btnObrisiReznuListu";
            this.btnObrisiReznuListu.Size = new System.Drawing.Size(151, 36);
            this.btnObrisiReznuListu.TabIndex = 68;
            this.btnObrisiReznuListu.Text = "Obriši reznu listu";
            this.btnObrisiReznuListu.UseVisualStyleBackColor = false;
            this.btnObrisiReznuListu.Click += new System.EventHandler(this.btnObrisiReznuListu_Click);
            // 
            // btnAzurirajReznuListu
            // 
            this.btnAzurirajReznuListu.BackColor = System.Drawing.Color.White;
            this.btnAzurirajReznuListu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAzurirajReznuListu.FlatAppearance.BorderSize = 3;
            this.btnAzurirajReznuListu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajReznuListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajReznuListu.Location = new System.Drawing.Point(559, 213);
            this.btnAzurirajReznuListu.Name = "btnAzurirajReznuListu";
            this.btnAzurirajReznuListu.Size = new System.Drawing.Size(151, 54);
            this.btnAzurirajReznuListu.TabIndex = 67;
            this.btnAzurirajReznuListu.Text = "Ažuriraj odabranu reznu listu";
            this.btnAzurirajReznuListu.UseVisualStyleBackColor = false;
            this.btnAzurirajReznuListu.Click += new System.EventHandler(this.btnAzurirajReznuListu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Stavke rezne liste:";
            // 
            // dgvStavkeRezneListe
            // 
            this.dgvStavkeRezneListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRezneListe.Location = new System.Drawing.Point(12, 408);
            this.dgvStavkeRezneListe.Name = "dgvStavkeRezneListe";
            this.dgvStavkeRezneListe.Size = new System.Drawing.Size(541, 150);
            this.dgvStavkeRezneListe.TabIndex = 72;
            // 
            // btnResetSort
            // 
            this.btnResetSort.BackColor = System.Drawing.Color.White;
            this.btnResetSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetSort.Location = new System.Drawing.Point(456, 334);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(97, 36);
            this.btnResetSort.TabIndex = 75;
            this.btnResetSort.Text = "Osvježi";
            this.btnResetSort.UseVisualStyleBackColor = false;
            this.btnResetSort.Click += new System.EventHandler(this.btnResetSort_Click);
            // 
            // btnSortirajPoDatumu
            // 
            this.btnSortirajPoDatumu.BackColor = System.Drawing.Color.White;
            this.btnSortirajPoDatumu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortirajPoDatumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortirajPoDatumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortirajPoDatumu.Location = new System.Drawing.Point(12, 334);
            this.btnSortirajPoDatumu.Name = "btnSortirajPoDatumu";
            this.btnSortirajPoDatumu.Size = new System.Drawing.Size(97, 36);
            this.btnSortirajPoDatumu.TabIndex = 74;
            this.btnSortirajPoDatumu.Text = "Sortiraj po datumu";
            this.btnSortirajPoDatumu.UseVisualStyleBackColor = false;
            this.btnSortirajPoDatumu.Click += new System.EventHandler(this.btnSortirajPoDatumu_Click);
            // 
            // btnSortPoKorisniku
            // 
            this.btnSortPoKorisniku.BackColor = System.Drawing.Color.White;
            this.btnSortPoKorisniku.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortPoKorisniku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortPoKorisniku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortPoKorisniku.Location = new System.Drawing.Point(115, 334);
            this.btnSortPoKorisniku.Name = "btnSortPoKorisniku";
            this.btnSortPoKorisniku.Size = new System.Drawing.Size(97, 36);
            this.btnSortPoKorisniku.TabIndex = 76;
            this.btnSortPoKorisniku.Text = "Sortiraj po korisniku";
            this.btnSortPoKorisniku.UseVisualStyleBackColor = false;
            this.btnSortPoKorisniku.Click += new System.EventHandler(this.btnSortPoKorisniku_Click);
            // 
            // FrmIzradaRezneListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 589);
            this.Controls.Add(this.btnSortPoKorisniku);
            this.Controls.Add(this.btnResetSort);
            this.Controls.Add(this.btnSortirajPoDatumu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStavkeRezneListe);
            this.Controls.Add(this.btnObrisiReznuListu);
            this.Controls.Add(this.btnAzurirajReznuListu);
            this.Controls.Add(this.btnIzradiReznuListu);
            this.Controls.Add(this.dgvRezneListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIzradaRezneListe";
            this.Text = "FrmIzradaRezneListe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezneListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_rezanjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRezneListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRezneListe;
        private System.Windows.Forms.Button btnIzradiReznuListu;
        private System.Windows.Forms.Button btnObrisiReznuListu;
        private System.Windows.Forms.Button btnAzurirajReznuListu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStavkeRezneListe;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.Button btnSortirajPoDatumu;
        private System.Windows.Forms.Button btnSortPoKorisniku;
        private System.Windows.Forms.BindingSource plan_rezanjaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPlanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik_ID;
    }
}
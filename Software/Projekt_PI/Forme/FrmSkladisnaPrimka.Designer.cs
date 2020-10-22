namespace Projekt_PI.Forme
{
    partial class FrmSkladisnaPrimka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSkladisnaPrimka));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvStavkeSkladisnePrimke = new System.Windows.Forms.DataGridView();
            this.btnResetSort = new System.Windows.Forms.Button();
            this.btnSortirajPoDatumu = new System.Windows.Forms.Button();
            this.btnObrisiPrimku = new System.Windows.Forms.Button();
            this.btnAzurirajPrimku = new System.Windows.Forms.Button();
            this.btnNovaPrimka = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvSkladisnePrimke = new System.Windows.Forms.DataGridView();
            this.Korisnik_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPotvrdiPrimku = new System.Windows.Forms.Button();
            this.iDPrimkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skladišna_primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeSkladisnePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladisnePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladišna_primkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Stavke skladišne primke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(259, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "SKLADIŠNE PRIMKE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // dgvStavkeSkladisnePrimke
            // 
            this.dgvStavkeSkladisnePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeSkladisnePrimke.Location = new System.Drawing.Point(12, 436);
            this.dgvStavkeSkladisnePrimke.Name = "dgvStavkeSkladisnePrimke";
            this.dgvStavkeSkladisnePrimke.Size = new System.Drawing.Size(541, 150);
            this.dgvStavkeSkladisnePrimke.TabIndex = 70;
            // 
            // btnResetSort
            // 
            this.btnResetSort.BackColor = System.Drawing.Color.White;
            this.btnResetSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetSort.Location = new System.Drawing.Point(456, 356);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(97, 36);
            this.btnResetSort.TabIndex = 69;
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
            this.btnSortirajPoDatumu.Location = new System.Drawing.Point(12, 356);
            this.btnSortirajPoDatumu.Name = "btnSortirajPoDatumu";
            this.btnSortirajPoDatumu.Size = new System.Drawing.Size(97, 36);
            this.btnSortirajPoDatumu.TabIndex = 67;
            this.btnSortirajPoDatumu.Text = "Sortiraj po datumu";
            this.btnSortirajPoDatumu.UseVisualStyleBackColor = false;
            this.btnSortirajPoDatumu.Click += new System.EventHandler(this.btnSortirajPoDatumu_Click);
            // 
            // btnObrisiPrimku
            // 
            this.btnObrisiPrimku.BackColor = System.Drawing.Color.White;
            this.btnObrisiPrimku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnObrisiPrimku.FlatAppearance.BorderSize = 3;
            this.btnObrisiPrimku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPrimku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPrimku.Location = new System.Drawing.Point(562, 314);
            this.btnObrisiPrimku.Name = "btnObrisiPrimku";
            this.btnObrisiPrimku.Size = new System.Drawing.Size(132, 36);
            this.btnObrisiPrimku.TabIndex = 66;
            this.btnObrisiPrimku.Text = "Obriši primku";
            this.btnObrisiPrimku.UseVisualStyleBackColor = false;
            this.btnObrisiPrimku.Click += new System.EventHandler(this.btnObrisiPrimku_Click);
            // 
            // btnAzurirajPrimku
            // 
            this.btnAzurirajPrimku.BackColor = System.Drawing.Color.White;
            this.btnAzurirajPrimku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAzurirajPrimku.FlatAppearance.BorderSize = 3;
            this.btnAzurirajPrimku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajPrimku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajPrimku.Location = new System.Drawing.Point(562, 243);
            this.btnAzurirajPrimku.Name = "btnAzurirajPrimku";
            this.btnAzurirajPrimku.Size = new System.Drawing.Size(132, 65);
            this.btnAzurirajPrimku.TabIndex = 65;
            this.btnAzurirajPrimku.Text = "Ažuriraj odabranu primku";
            this.btnAzurirajPrimku.UseVisualStyleBackColor = false;
            this.btnAzurirajPrimku.Click += new System.EventHandler(this.btnAzurirajPrimku_Click);
            // 
            // btnNovaPrimka
            // 
            this.btnNovaPrimka.BackColor = System.Drawing.Color.White;
            this.btnNovaPrimka.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnNovaPrimka.FlatAppearance.BorderSize = 3;
            this.btnNovaPrimka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaPrimka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaPrimka.Location = new System.Drawing.Point(562, 188);
            this.btnNovaPrimka.Name = "btnNovaPrimka";
            this.btnNovaPrimka.Size = new System.Drawing.Size(132, 49);
            this.btnNovaPrimka.TabIndex = 64;
            this.btnNovaPrimka.Text = "Nova škladišna primka";
            this.btnNovaPrimka.UseVisualStyleBackColor = false;
            this.btnNovaPrimka.Click += new System.EventHandler(this.btnNovaPrimka_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(641, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dgvSkladisnePrimke
            // 
            this.dgvSkladisnePrimke.AutoGenerateColumns = false;
            this.dgvSkladisnePrimke.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSkladisnePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladisnePrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPrimkaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.Korisnik_ID});
            this.dgvSkladisnePrimke.DataSource = this.skladišna_primkaBindingSource;
            this.dgvSkladisnePrimke.Location = new System.Drawing.Point(12, 188);
            this.dgvSkladisnePrimke.Name = "dgvSkladisnePrimke";
            this.dgvSkladisnePrimke.Size = new System.Drawing.Size(541, 162);
            this.dgvSkladisnePrimke.TabIndex = 62;
            this.dgvSkladisnePrimke.SelectionChanged += new System.EventHandler(this.dgvMaterijali_SelectionChanged);
            // 
            // Korisnik_ID
            // 
            this.Korisnik_ID.DataPropertyName = "Korisnik_ID";
            this.Korisnik_ID.HeaderText = "Korisnik_ID";
            this.Korisnik_ID.Name = "Korisnik_ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn1.HeaderText = "Korisnik";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Korisnik";
            this.dataGridViewTextBoxColumn2.HeaderText = "Korisnik";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnPotvrdiPrimku
            // 
            this.btnPotvrdiPrimku.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPotvrdiPrimku.FlatAppearance.BorderSize = 3;
            this.btnPotvrdiPrimku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdiPrimku.Location = new System.Drawing.Point(562, 356);
            this.btnPotvrdiPrimku.Name = "btnPotvrdiPrimku";
            this.btnPotvrdiPrimku.Size = new System.Drawing.Size(132, 36);
            this.btnPotvrdiPrimku.TabIndex = 72;
            this.btnPotvrdiPrimku.Text = "Potvrdi primku";
            this.btnPotvrdiPrimku.UseVisualStyleBackColor = true;
            this.btnPotvrdiPrimku.Click += new System.EventHandler(this.btnPotvrdiPrimku_Click);
            // 
            // iDPrimkaDataGridViewTextBoxColumn
            // 
            this.iDPrimkaDataGridViewTextBoxColumn.DataPropertyName = "ID_Primka";
            this.iDPrimkaDataGridViewTextBoxColumn.HeaderText = "ID_Primka";
            this.iDPrimkaDataGridViewTextBoxColumn.Name = "iDPrimkaDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // skladišna_primkaBindingSource
            // 
            this.skladišna_primkaBindingSource.DataSource = typeof(Projekt_PI.Skladišna_primka);
            // 
            // FrmSkladisnaPrimka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 618);
            this.Controls.Add(this.btnPotvrdiPrimku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvStavkeSkladisnePrimke);
            this.Controls.Add(this.btnResetSort);
            this.Controls.Add(this.btnSortirajPoDatumu);
            this.Controls.Add(this.btnObrisiPrimku);
            this.Controls.Add(this.btnAzurirajPrimku);
            this.Controls.Add(this.btnNovaPrimka);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvSkladisnePrimke);
            this.Name = "FrmSkladisnaPrimka";
            this.Text = "FrmSkladisnaPrimka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeSkladisnePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladisnePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladišna_primkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource skladišna_primkaBindingSource;
        private System.Windows.Forms.DataGridView dgvStavkeSkladisnePrimke;
        private System.Windows.Forms.Button btnResetSort;
        private System.Windows.Forms.Button btnSortirajPoDatumu;
        private System.Windows.Forms.Button btnObrisiPrimku;
        private System.Windows.Forms.Button btnAzurirajPrimku;
        private System.Windows.Forms.Button btnNovaPrimka;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvSkladisnePrimke;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPrimkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnPotvrdiPrimku;
    }
}
namespace Projekt_PI.Forme
{
    partial class FrmMaterijali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterijali));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.nazivmaterijalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debljinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materijalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNoviMaterijal = new System.Windows.Forms.Button();
            this.btnAzurirajOdabraniMaterijal = new System.Windows.Forms.Button();
            this.btnObrisiMaterijal = new System.Windows.Forms.Button();
            this.btnSortirajPoNazivu = new System.Windows.Forms.Button();
            this.btnSortirajPoSirini = new System.Windows.Forms.Button();
            this.btnSortirajPoDuzini = new System.Windows.Forms.Button();
            this.txtPretraziMaterijal = new System.Windows.Forms.TextBox();
            this.btnResetSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(236, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "UPRAVLJANJE MATERIJALIMA";
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.AutoGenerateColumns = false;
            this.dgvMaterijali.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivmaterijalaDataGridViewTextBoxColumn,
            this.sirinaDataGridViewTextBoxColumn,
            this.duzinaDataGridViewTextBoxColumn,
            this.debljinaDataGridViewTextBoxColumn});
            this.dgvMaterijali.DataSource = this.materijalBindingSource;
            this.dgvMaterijali.Location = new System.Drawing.Point(12, 164);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.Size = new System.Drawing.Size(541, 275);
            this.dgvMaterijali.TabIndex = 10;
            // 
            // nazivmaterijalaDataGridViewTextBoxColumn
            // 
            this.nazivmaterijalaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_materijala";
            this.nazivmaterijalaDataGridViewTextBoxColumn.HeaderText = "Naziv_materijala";
            this.nazivmaterijalaDataGridViewTextBoxColumn.Name = "nazivmaterijalaDataGridViewTextBoxColumn";
            // 
            // sirinaDataGridViewTextBoxColumn
            // 
            this.sirinaDataGridViewTextBoxColumn.DataPropertyName = "Sirina";
            this.sirinaDataGridViewTextBoxColumn.HeaderText = "Sirina";
            this.sirinaDataGridViewTextBoxColumn.Name = "sirinaDataGridViewTextBoxColumn";
            // 
            // duzinaDataGridViewTextBoxColumn
            // 
            this.duzinaDataGridViewTextBoxColumn.DataPropertyName = "Duzina";
            this.duzinaDataGridViewTextBoxColumn.HeaderText = "Duzina";
            this.duzinaDataGridViewTextBoxColumn.Name = "duzinaDataGridViewTextBoxColumn";
            // 
            // debljinaDataGridViewTextBoxColumn
            // 
            this.debljinaDataGridViewTextBoxColumn.DataPropertyName = "Debljina";
            this.debljinaDataGridViewTextBoxColumn.HeaderText = "Debljina";
            this.debljinaDataGridViewTextBoxColumn.Name = "debljinaDataGridViewTextBoxColumn";
            // 
            // materijalBindingSource
            // 
            this.materijalBindingSource.DataSource = typeof(Projekt_PI.Materijal);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(649, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnNoviMaterijal
            // 
            this.btnNoviMaterijal.BackColor = System.Drawing.Color.White;
            this.btnNoviMaterijal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnNoviMaterijal.FlatAppearance.BorderSize = 3;
            this.btnNoviMaterijal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviMaterijal.Location = new System.Drawing.Point(570, 164);
            this.btnNoviMaterijal.Name = "btnNoviMaterijal";
            this.btnNoviMaterijal.Size = new System.Drawing.Size(132, 36);
            this.btnNoviMaterijal.TabIndex = 38;
            this.btnNoviMaterijal.Text = "Novi materijal";
            this.btnNoviMaterijal.UseVisualStyleBackColor = false;
            this.btnNoviMaterijal.Click += new System.EventHandler(this.btnNoviMaterijal_Click);
            // 
            // btnAzurirajOdabraniMaterijal
            // 
            this.btnAzurirajOdabraniMaterijal.BackColor = System.Drawing.Color.White;
            this.btnAzurirajOdabraniMaterijal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAzurirajOdabraniMaterijal.FlatAppearance.BorderSize = 3;
            this.btnAzurirajOdabraniMaterijal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajOdabraniMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajOdabraniMaterijal.Location = new System.Drawing.Point(570, 219);
            this.btnAzurirajOdabraniMaterijal.Name = "btnAzurirajOdabraniMaterijal";
            this.btnAzurirajOdabraniMaterijal.Size = new System.Drawing.Size(132, 65);
            this.btnAzurirajOdabraniMaterijal.TabIndex = 39;
            this.btnAzurirajOdabraniMaterijal.Text = "Ažuriraj odabrani materijal";
            this.btnAzurirajOdabraniMaterijal.UseVisualStyleBackColor = false;
            this.btnAzurirajOdabraniMaterijal.Click += new System.EventHandler(this.btnAzurirajOdabraniMaterijal_Click);
            // 
            // btnObrisiMaterijal
            // 
            this.btnObrisiMaterijal.BackColor = System.Drawing.Color.White;
            this.btnObrisiMaterijal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnObrisiMaterijal.FlatAppearance.BorderSize = 3;
            this.btnObrisiMaterijal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiMaterijal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiMaterijal.Location = new System.Drawing.Point(570, 403);
            this.btnObrisiMaterijal.Name = "btnObrisiMaterijal";
            this.btnObrisiMaterijal.Size = new System.Drawing.Size(132, 36);
            this.btnObrisiMaterijal.TabIndex = 40;
            this.btnObrisiMaterijal.Text = "Obriši materijal";
            this.btnObrisiMaterijal.UseVisualStyleBackColor = false;
            this.btnObrisiMaterijal.Click += new System.EventHandler(this.btnObrisiMaterijal_Click);
            // 
            // btnSortirajPoNazivu
            // 
            this.btnSortirajPoNazivu.BackColor = System.Drawing.Color.White;
            this.btnSortirajPoNazivu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortirajPoNazivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortirajPoNazivu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortirajPoNazivu.Location = new System.Drawing.Point(12, 459);
            this.btnSortirajPoNazivu.Name = "btnSortirajPoNazivu";
            this.btnSortirajPoNazivu.Size = new System.Drawing.Size(97, 36);
            this.btnSortirajPoNazivu.TabIndex = 41;
            this.btnSortirajPoNazivu.Text = "Sortiraj po nazivu";
            this.btnSortirajPoNazivu.UseVisualStyleBackColor = false;
            this.btnSortirajPoNazivu.Click += new System.EventHandler(this.btnSortirajPoNazivu_Click);
            // 
            // btnSortirajPoSirini
            // 
            this.btnSortirajPoSirini.BackColor = System.Drawing.Color.White;
            this.btnSortirajPoSirini.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortirajPoSirini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortirajPoSirini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortirajPoSirini.Location = new System.Drawing.Point(126, 459);
            this.btnSortirajPoSirini.Name = "btnSortirajPoSirini";
            this.btnSortirajPoSirini.Size = new System.Drawing.Size(97, 36);
            this.btnSortirajPoSirini.TabIndex = 42;
            this.btnSortirajPoSirini.Text = "Sortiraj po širini";
            this.btnSortirajPoSirini.UseVisualStyleBackColor = false;
            this.btnSortirajPoSirini.Click += new System.EventHandler(this.btnSortirajPoSirini_Click);
            // 
            // btnSortirajPoDuzini
            // 
            this.btnSortirajPoDuzini.BackColor = System.Drawing.Color.White;
            this.btnSortirajPoDuzini.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSortirajPoDuzini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortirajPoDuzini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSortirajPoDuzini.Location = new System.Drawing.Point(240, 459);
            this.btnSortirajPoDuzini.Name = "btnSortirajPoDuzini";
            this.btnSortirajPoDuzini.Size = new System.Drawing.Size(97, 36);
            this.btnSortirajPoDuzini.TabIndex = 43;
            this.btnSortirajPoDuzini.Text = "Sortiraj po dužini";
            this.btnSortirajPoDuzini.UseVisualStyleBackColor = false;
            this.btnSortirajPoDuzini.Click += new System.EventHandler(this.btnSortirajPoDuzini_Click);
            // 
            // txtPretraziMaterijal
            // 
            this.txtPretraziMaterijal.Location = new System.Drawing.Point(453, 139);
            this.txtPretraziMaterijal.Name = "txtPretraziMaterijal";
            this.txtPretraziMaterijal.Size = new System.Drawing.Size(100, 20);
            this.txtPretraziMaterijal.TabIndex = 44;
            this.txtPretraziMaterijal.Text = "Pretraži...";
            this.txtPretraziMaterijal.TextChanged += new System.EventHandler(this.txtPretraziMaterijal_TextChanged);
            // 
            // btnResetSort
            // 
            this.btnResetSort.BackColor = System.Drawing.Color.White;
            this.btnResetSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetSort.Location = new System.Drawing.Point(456, 459);
            this.btnResetSort.Name = "btnResetSort";
            this.btnResetSort.Size = new System.Drawing.Size(97, 36);
            this.btnResetSort.TabIndex = 45;
            this.btnResetSort.Text = "Resetiraj";
            this.btnResetSort.UseVisualStyleBackColor = false;
            this.btnResetSort.Click += new System.EventHandler(this.btnResetSort_Click);
            // 
            // FrmMaterijali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 538);
            this.Controls.Add(this.btnResetSort);
            this.Controls.Add(this.txtPretraziMaterijal);
            this.Controls.Add(this.btnSortirajPoDuzini);
            this.Controls.Add(this.btnSortirajPoSirini);
            this.Controls.Add(this.btnSortirajPoNazivu);
            this.Controls.Add(this.btnObrisiMaterijal);
            this.Controls.Add(this.btnAzurirajOdabraniMaterijal);
            this.Controls.Add(this.btnNoviMaterijal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvMaterijali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaterijali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajSirovinu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNoviMaterijal;
        private System.Windows.Forms.Button btnAzurirajOdabraniMaterijal;
        private System.Windows.Forms.Button btnObrisiMaterijal;
        private System.Windows.Forms.Button btnSortirajPoNazivu;
        private System.Windows.Forms.Button btnSortirajPoSirini;
        private System.Windows.Forms.Button btnSortirajPoDuzini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivmaterijalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debljinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materijalBindingSource;
        private System.Windows.Forms.TextBox txtPretraziMaterijal;
        private System.Windows.Forms.Button btnResetSort;
    }
}
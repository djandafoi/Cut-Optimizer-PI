namespace Projekt_PI.Forme
{
    partial class KreiranjeSkladisnePrimke
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
            this.datumSkladisnePrimke = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.cmbMaterijali = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremiPrimku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // datumSkladisnePrimke
            // 
            this.datumSkladisnePrimke.Enabled = false;
            this.datumSkladisnePrimke.Location = new System.Drawing.Point(117, 21);
            this.datumSkladisnePrimke.Name = "datumSkladisnePrimke";
            this.datumSkladisnePrimke.Size = new System.Drawing.Size(200, 20);
            this.datumSkladisnePrimke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisnik:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(117, 47);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnik.TabIndex = 3;
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(12, 170);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(413, 150);
            this.dgvStavke.TabIndex = 4;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.BackColor = System.Drawing.Color.White;
            this.btnDodajStavku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDodajStavku.FlatAppearance.BorderSize = 3;
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavku.Location = new System.Drawing.Point(337, 130);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(88, 34);
            this.btnDodajStavku.TabIndex = 65;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = false;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.BackColor = System.Drawing.Color.White;
            this.btnObrisiStavku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnObrisiStavku.FlatAppearance.BorderSize = 3;
            this.btnObrisiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(337, 326);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(88, 34);
            this.btnObrisiStavku.TabIndex = 66;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // cmbMaterijali
            // 
            this.cmbMaterijali.FormattingEnabled = true;
            this.cmbMaterijali.Location = new System.Drawing.Point(12, 143);
            this.cmbMaterijali.Name = "cmbMaterijali";
            this.cmbMaterijali.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterijali.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Odaberite materijal:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(139, 143);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Količina:";
            // 
            // btnSpremiPrimku
            // 
            this.btnSpremiPrimku.BackColor = System.Drawing.Color.White;
            this.btnSpremiPrimku.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnSpremiPrimku.FlatAppearance.BorderSize = 3;
            this.btnSpremiPrimku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiPrimku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiPrimku.Location = new System.Drawing.Point(172, 390);
            this.btnSpremiPrimku.Name = "btnSpremiPrimku";
            this.btnSpremiPrimku.Size = new System.Drawing.Size(88, 34);
            this.btnSpremiPrimku.TabIndex = 71;
            this.btnSpremiPrimku.Text = "Spremi primku";
            this.btnSpremiPrimku.UseVisualStyleBackColor = false;
            this.btnSpremiPrimku.Click += new System.EventHandler(this.btnSpremiPrimku_Click);
            // 
            // KreiranjeSkladisnePrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 436);
            this.Controls.Add(this.btnSpremiPrimku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaterijali);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumSkladisnePrimke);
            this.Name = "KreiranjeSkladisnePrimke";
            this.Text = "KreiranjeSkladisnePrimke";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumSkladisnePrimke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.ComboBox cmbMaterijali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremiPrimku;
    }
}
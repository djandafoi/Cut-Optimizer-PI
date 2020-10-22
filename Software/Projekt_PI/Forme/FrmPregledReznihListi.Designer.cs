namespace Projekt_PI.Forme
{
    partial class FrmPregledReznihListi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledReznihListi));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRezneListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptimiziraj = new System.Windows.Forms.Button();
            this.iDPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivPlanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_rezanjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIspis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezneListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_rezanjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(699, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.korisnikIDDataGridViewTextBoxColumn});
            this.dgvRezneListe.DataSource = this.plan_rezanjaBindingSource;
            this.dgvRezneListe.Location = new System.Drawing.Point(12, 194);
            this.dgvRezneListe.Name = "dgvRezneListe";
            this.dgvRezneListe.Size = new System.Drawing.Size(613, 197);
            this.dgvRezneListe.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(203, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "PREGLED REZNIH LISTI";
            // 
            // btnOptimiziraj
            // 
            this.btnOptimiziraj.BackColor = System.Drawing.Color.White;
            this.btnOptimiziraj.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnOptimiziraj.FlatAppearance.BorderSize = 3;
            this.btnOptimiziraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptimiziraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOptimiziraj.Location = new System.Drawing.Point(631, 194);
            this.btnOptimiziraj.Name = "btnOptimiziraj";
            this.btnOptimiziraj.Size = new System.Drawing.Size(121, 45);
            this.btnOptimiziraj.TabIndex = 37;
            this.btnOptimiziraj.Text = "Optimiziraj";
            this.btnOptimiziraj.UseVisualStyleBackColor = false;
            this.btnOptimiziraj.Click += new System.EventHandler(this.btnOptimiziraj_Click);
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
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "Korisnik_ID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "Korisnik_ID";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            // 
            // plan_rezanjaBindingSource
            // 
            this.plan_rezanjaBindingSource.DataSource = typeof(Projekt_PI.Plan_rezanja);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(12, 435);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(658, 20);
            this.txtIspis.TabIndex = 38;
            // 
            // FrmPregledReznihListi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 570);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnOptimiziraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRezneListe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPregledReznihListi";
            this.Text = "FrmPregledReznihListi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezneListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan_rezanjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRezneListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOptimiziraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPlanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plan_rezanjaBindingSource;
        private System.Windows.Forms.TextBox txtIspis;
    }
}
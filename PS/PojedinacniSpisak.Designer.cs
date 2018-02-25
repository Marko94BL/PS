namespace PS
{
    partial class PojedinacniSpisak
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
            this.tbOtprema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdentifikator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVrece = new System.Windows.Forms.DataGridView();
            this.colIdentifikator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKreirajSpisak = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbZa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrece)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOtprema
            // 
            this.tbOtprema.Location = new System.Drawing.Point(166, 11);
            this.tbOtprema.Name = "tbOtprema";
            this.tbOtprema.Size = new System.Drawing.Size(47, 20);
            this.tbOtprema.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Za";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Otprema ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum";
            // 
            // tbIdentifikator
            // 
            this.tbIdentifikator.Location = new System.Drawing.Point(131, 154);
            this.tbIdentifikator.Name = "tbIdentifikator";
            this.tbIdentifikator.Size = new System.Drawing.Size(163, 20);
            this.tbIdentifikator.TabIndex = 25;
            this.tbIdentifikator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdentifikator_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Identifikator vreće";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(313, 151);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(35, 23);
            this.btnDodaj.TabIndex = 26;
            this.btnDodaj.Text = "+";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pojedinačni spisak razmjene";
            // 
            // dgvVrece
            // 
            this.dgvVrece.AllowUserToAddRows = false;
            this.dgvVrece.AllowUserToDeleteRows = false;
            this.dgvVrece.AllowUserToResizeColumns = false;
            this.dgvVrece.AllowUserToResizeRows = false;
            this.dgvVrece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentifikator});
            this.dgvVrece.Location = new System.Drawing.Point(15, 216);
            this.dgvVrece.Name = "dgvVrece";
            this.dgvVrece.Size = new System.Drawing.Size(357, 234);
            this.dgvVrece.TabIndex = 28;
            // 
            // colIdentifikator
            // 
            this.colIdentifikator.HeaderText = "Identifikator";
            this.colIdentifikator.Name = "colIdentifikator";
            this.colIdentifikator.ReadOnly = true;
            this.colIdentifikator.Width = 315;
            // 
            // btnKreirajSpisak
            // 
            this.btnKreirajSpisak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajSpisak.Location = new System.Drawing.Point(211, 459);
            this.btnKreirajSpisak.Name = "btnKreirajSpisak";
            this.btnKreirajSpisak.Size = new System.Drawing.Size(161, 29);
            this.btnKreirajSpisak.TabIndex = 29;
            this.btnKreirajSpisak.Text = "Štampaj spisak razmjene";
            this.btnKreirajSpisak.UseVisualStyleBackColor = true;
            this.btnKreirajSpisak.Click += new System.EventHandler(this.btnKreirajSpisak_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Spisak razmjene";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(131, 125);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(163, 20);
            this.tbDatum.TabIndex = 31;
            // 
            // tbZa
            // 
            this.tbZa.Location = new System.Drawing.Point(248, 40);
            this.tbZa.Name = "tbZa";
            this.tbZa.Size = new System.Drawing.Size(124, 20);
            this.tbZa.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Od";
            // 
            // tbOd
            // 
            this.tbOd.Location = new System.Drawing.Point(248, 10);
            this.tbOd.Name = "tbOd";
            this.tbOd.Size = new System.Drawing.Size(124, 20);
            this.tbOd.TabIndex = 34;
            // 
            // PojedinacniSpisak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 501);
            this.Controls.Add(this.tbOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbZa);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnKreirajSpisak);
            this.Controls.Add(this.dgvVrece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbIdentifikator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOtprema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 539);
            this.MinimumSize = new System.Drawing.Size(400, 539);
            this.Name = "PojedinacniSpisak";
            this.Text = "Pošte Srpske";
            this.Load += new System.EventHandler(this.PojedinacniSpisak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOtprema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdentifikator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVrece;
        private System.Windows.Forms.Button btnKreirajSpisak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentifikator;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbZa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOd;
    }
}
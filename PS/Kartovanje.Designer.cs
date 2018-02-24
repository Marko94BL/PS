namespace PS
{
    partial class Kartovanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbOtprema = new System.Windows.Forms.TextBox();
            this.cbOdredisnaPosta = new System.Windows.Forms.ComboBox();
            this.dgvKartaZakljucka = new System.Windows.Forms.DataGridView();
            this.colIdentifikator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnKreirajKartu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPrijemnaPosta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNapomena = new System.Windows.Forms.TextBox();
            this.btnDodajNaPopis = new System.Windows.Forms.Button();
            this.btnKreirajSpisakRazmjene = new System.Windows.Forms.Button();
            this.tbIdentifikator = new System.Windows.Forms.MaskedTextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartaZakljucka)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otprema ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Za";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identifikator pošiljke";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbOtprema
            // 
            this.tbOtprema.Location = new System.Drawing.Point(467, 17);
            this.tbOtprema.Name = "tbOtprema";
            this.tbOtprema.Size = new System.Drawing.Size(116, 20);
            this.tbOtprema.TabIndex = 0;
            // 
            // cbOdredisnaPosta
            // 
            this.cbOdredisnaPosta.FormattingEnabled = true;
            this.cbOdredisnaPosta.Location = new System.Drawing.Point(350, 124);
            this.cbOdredisnaPosta.Name = "cbOdredisnaPosta";
            this.cbOdredisnaPosta.Size = new System.Drawing.Size(233, 21);
            this.cbOdredisnaPosta.TabIndex = 2;
            // 
            // dgvKartaZakljucka
            // 
            this.dgvKartaZakljucka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKartaZakljucka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentifikator});
            this.dgvKartaZakljucka.Location = new System.Drawing.Point(12, 188);
            this.dgvKartaZakljucka.Name = "dgvKartaZakljucka";
            this.dgvKartaZakljucka.Size = new System.Drawing.Size(278, 266);
            this.dgvKartaZakljucka.TabIndex = 19;
            // 
            // colIdentifikator
            // 
            this.colIdentifikator.HeaderText = "Identifikator";
            this.colIdentifikator.Name = "colIdentifikator";
            this.colIdentifikator.ReadOnly = true;
            this.colIdentifikator.Width = 236;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(90, 124);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // btnKreirajKartu
            // 
            this.btnKreirajKartu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajKartu.Location = new System.Drawing.Point(467, 356);
            this.btnKreirajKartu.Name = "btnKreirajKartu";
            this.btnKreirajKartu.Size = new System.Drawing.Size(116, 39);
            this.btnKreirajKartu.TabIndex = 23;
            this.btnKreirajKartu.Text = "Kreiraj kartu zaključka";
            this.btnKreirajKartu.UseVisualStyleBackColor = true;
            this.btnKreirajKartu.Click += new System.EventHandler(this.btnKreirajKartu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Od";
            // 
            // cbPrijemnaPosta
            // 
            this.cbPrijemnaPosta.FormattingEnabled = true;
            this.cbPrijemnaPosta.Location = new System.Drawing.Point(350, 92);
            this.cbPrijemnaPosta.Name = "cbPrijemnaPosta";
            this.cbPrijemnaPosta.Size = new System.Drawing.Size(233, 21);
            this.cbPrijemnaPosta.TabIndex = 1;
            this.cbPrijemnaPosta.SelectedIndexChanged += new System.EventHandler(this.cbPrijemnaPosta_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(307, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Napomena";
            // 
            // tbNapomena
            // 
            this.tbNapomena.Location = new System.Drawing.Point(310, 216);
            this.tbNapomena.Multiline = true;
            this.tbNapomena.Name = "tbNapomena";
            this.tbNapomena.Size = new System.Drawing.Size(273, 120);
            this.tbNapomena.TabIndex = 6;
            // 
            // btnDodajNaPopis
            // 
            this.btnDodajNaPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaPopis.Location = new System.Drawing.Point(260, 153);
            this.btnDodajNaPopis.Name = "btnDodajNaPopis";
            this.btnDodajNaPopis.Size = new System.Drawing.Size(30, 23);
            this.btnDodajNaPopis.TabIndex = 5;
            this.btnDodajNaPopis.Text = "+";
            this.btnDodajNaPopis.UseVisualStyleBackColor = true;
            this.btnDodajNaPopis.Click += new System.EventHandler(this.btnDodajNaPopis_Click);
            // 
            // btnKreirajSpisakRazmjene
            // 
            this.btnKreirajSpisakRazmjene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajSpisakRazmjene.Location = new System.Drawing.Point(309, 443);
            this.btnKreirajSpisakRazmjene.Name = "btnKreirajSpisakRazmjene";
            this.btnKreirajSpisakRazmjene.Size = new System.Drawing.Size(274, 38);
            this.btnKreirajSpisakRazmjene.TabIndex = 26;
            this.btnKreirajSpisakRazmjene.Text = "Kreiraj spisak razmjene";
            this.btnKreirajSpisakRazmjene.UseVisualStyleBackColor = true;
            this.btnKreirajSpisakRazmjene.Click += new System.EventHandler(this.btnKreirajSpisakRazmjene_Click);
            // 
            // tbIdentifikator
            // 
            this.tbIdentifikator.Location = new System.Drawing.Point(130, 153);
            this.tbIdentifikator.Mask = "LL000000000LL";
            this.tbIdentifikator.Name = "tbIdentifikator";
            this.tbIdentifikator.Size = new System.Drawing.Size(124, 20);
            this.tbIdentifikator.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(18, 468);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 13);
            this.lbStatus.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Karta zaključka";
            // 
            // Kartovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbIdentifikator);
            this.Controls.Add(this.tbNapomena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPrijemnaPosta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKreirajSpisakRazmjene);
            this.Controls.Add(this.btnKreirajKartu);
            this.Controls.Add(this.btnDodajNaPopis);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.dgvKartaZakljucka);
            this.Controls.Add(this.cbOdredisnaPosta);
            this.Controls.Add(this.tbOtprema);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(610, 533);
            this.MinimumSize = new System.Drawing.Size(610, 533);
            this.Name = "Kartovanje";
            this.Text = "Pošte Srpske - Kartovanje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartaZakljucka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbOtprema;
        private System.Windows.Forms.ComboBox cbOdredisnaPosta;
        private System.Windows.Forms.DataGridView dgvKartaZakljucka;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentifikator;
        private System.Windows.Forms.Button btnKreirajKartu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPrijemnaPosta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNapomena;
        private System.Windows.Forms.Button btnDodajNaPopis;
        private System.Windows.Forms.Button btnKreirajSpisakRazmjene;
        private System.Windows.Forms.MaskedTextBox tbIdentifikator;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
    }
}
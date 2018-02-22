namespace PS
{
    partial class Prijem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrijemna = new System.Windows.Forms.TextBox();
            this.dtpDatumPolaska = new System.Windows.Forms.DateTimePicker();
            this.dgvVrece = new System.Windows.Forms.DataGridView();
            this.colIdentifikatorV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimljenaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPosiljke = new System.Windows.Forms.DataGridView();
            this.colIdentifikatorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimljenaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdentifikatorVrece = new System.Windows.Forms.TextBox();
            this.tbIdentifikatorPosiljke = new System.Windows.Forms.TextBox();
            this.lbStatusVrece = new System.Windows.Forms.Label();
            this.lbStatusSpiska = new System.Windows.Forms.Label();
            this.lbStatusPosiljke = new System.Windows.Forms.Label();
            this.lbStatusKarte = new System.Windows.Forms.Label();
            this.btnOvjeraSpiska = new System.Windows.Forms.Button();
            this.btnOvjeraKarteZakljucka = new System.Windows.Forms.Button();
            this.tbPolazna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIdentifikatorKarte = new System.Windows.Forms.TextBox();
            this.btnKarta = new System.Windows.Forms.Button();
            this.btnVreca = new System.Windows.Forms.Button();
            this.btnPosiljke = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDatumSlanja = new System.Windows.Forms.TextBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Polazna pošta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prijemna pošta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Datum prijema";
            // 
            // tbPrijemna
            // 
            this.tbPrijemna.Location = new System.Drawing.Point(395, 39);
            this.tbPrijemna.Name = "tbPrijemna";
            this.tbPrijemna.Size = new System.Drawing.Size(211, 20);
            this.tbPrijemna.TabIndex = 16;
            // 
            // dtpDatumPolaska
            // 
            this.dtpDatumPolaska.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDatumPolaska.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumPolaska.Location = new System.Drawing.Point(425, 106);
            this.dtpDatumPolaska.Name = "dtpDatumPolaska";
            this.dtpDatumPolaska.Size = new System.Drawing.Size(181, 20);
            this.dtpDatumPolaska.TabIndex = 18;
            // 
            // dgvVrece
            // 
            this.dgvVrece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentifikatorV,
            this.colPrimljenaV});
            this.dgvVrece.Location = new System.Drawing.Point(12, 171);
            this.dgvVrece.Name = "dgvVrece";
            this.dgvVrece.Size = new System.Drawing.Size(287, 204);
            this.dgvVrece.TabIndex = 19;
            // 
            // colIdentifikatorV
            // 
            this.colIdentifikatorV.HeaderText = "Identifikator vreće";
            this.colIdentifikatorV.Name = "colIdentifikatorV";
            this.colIdentifikatorV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIdentifikatorV.Width = 170;
            // 
            // colPrimljenaV
            // 
            this.colPrimljenaV.HeaderText = "Primljena";
            this.colPrimljenaV.Name = "colPrimljenaV";
            this.colPrimljenaV.ReadOnly = true;
            this.colPrimljenaV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrimljenaV.Width = 79;
            // 
            // dgvPosiljke
            // 
            this.dgvPosiljke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiljke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdentifikatorP,
            this.colPrimljenaP});
            this.dgvPosiljke.Location = new System.Drawing.Point(319, 171);
            this.dgvPosiljke.Name = "dgvPosiljke";
            this.dgvPosiljke.Size = new System.Drawing.Size(287, 204);
            this.dgvPosiljke.TabIndex = 20;
            // 
            // colIdentifikatorP
            // 
            this.colIdentifikatorP.HeaderText = "Identifikator pošiljke";
            this.colIdentifikatorP.Name = "colIdentifikatorP";
            this.colIdentifikatorP.ReadOnly = true;
            this.colIdentifikatorP.Width = 170;
            // 
            // colPrimljenaP
            // 
            this.colPrimljenaP.HeaderText = "Primljena";
            this.colPrimljenaP.Name = "colPrimljenaP";
            this.colPrimljenaP.ReadOnly = true;
            this.colPrimljenaP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrimljenaP.Width = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Identifikator vreće";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Identifikator pošiljke";
            // 
            // tbIdentifikatorVrece
            // 
            this.tbIdentifikatorVrece.Location = new System.Drawing.Point(117, 145);
            this.tbIdentifikatorVrece.Name = "tbIdentifikatorVrece";
            this.tbIdentifikatorVrece.Size = new System.Drawing.Size(145, 20);
            this.tbIdentifikatorVrece.TabIndex = 23;
            // 
            // tbIdentifikatorPosiljke
            // 
            this.tbIdentifikatorPosiljke.Location = new System.Drawing.Point(440, 145);
            this.tbIdentifikatorPosiljke.Name = "tbIdentifikatorPosiljke";
            this.tbIdentifikatorPosiljke.Size = new System.Drawing.Size(130, 20);
            this.tbIdentifikatorPosiljke.TabIndex = 24;
            // 
            // lbStatusVrece
            // 
            this.lbStatusVrece.AutoSize = true;
            this.lbStatusVrece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusVrece.Location = new System.Drawing.Point(24, 386);
            this.lbStatusVrece.Name = "lbStatusVrece";
            this.lbStatusVrece.Size = new System.Drawing.Size(133, 15);
            this.lbStatusVrece.TabIndex = 25;
            this.lbStatusVrece.Text = "Status skenirane vreće!";
            // 
            // lbStatusSpiska
            // 
            this.lbStatusSpiska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusSpiska.Location = new System.Drawing.Point(58, 437);
            this.lbStatusSpiska.Name = "lbStatusSpiska";
            this.lbStatusSpiska.Size = new System.Drawing.Size(99, 47);
            this.lbStatusSpiska.TabIndex = 26;
            this.lbStatusSpiska.Text = "Status pojedinačnog spiska razmjene";
            // 
            // lbStatusPosiljke
            // 
            this.lbStatusPosiljke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusPosiljke.Location = new System.Drawing.Point(327, 386);
            this.lbStatusPosiljke.Name = "lbStatusPosiljke";
            this.lbStatusPosiljke.Size = new System.Drawing.Size(146, 42);
            this.lbStatusPosiljke.TabIndex = 27;
            this.lbStatusPosiljke.Text = "Status skenirane pošiljke!";
            // 
            // lbStatusKarte
            // 
            this.lbStatusKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusKarte.Location = new System.Drawing.Point(327, 428);
            this.lbStatusKarte.Name = "lbStatusKarte";
            this.lbStatusKarte.Size = new System.Drawing.Size(143, 47);
            this.lbStatusKarte.TabIndex = 28;
            this.lbStatusKarte.Text = "Status karte zaključka";
            // 
            // btnOvjeraSpiska
            // 
            this.btnOvjeraSpiska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOvjeraSpiska.Location = new System.Drawing.Point(172, 440);
            this.btnOvjeraSpiska.Name = "btnOvjeraSpiska";
            this.btnOvjeraSpiska.Size = new System.Drawing.Size(127, 44);
            this.btnOvjeraSpiska.TabIndex = 29;
            this.btnOvjeraSpiska.Text = "Ovjera spiska razmjene";
            this.btnOvjeraSpiska.UseVisualStyleBackColor = true;
            this.btnOvjeraSpiska.Click += new System.EventHandler(this.btnOvjeraSpiska_Click);
            // 
            // btnOvjeraKarteZakljucka
            // 
            this.btnOvjeraKarteZakljucka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOvjeraKarteZakljucka.Location = new System.Drawing.Point(479, 449);
            this.btnOvjeraKarteZakljucka.Name = "btnOvjeraKarteZakljucka";
            this.btnOvjeraKarteZakljucka.Size = new System.Drawing.Size(127, 44);
            this.btnOvjeraKarteZakljucka.TabIndex = 30;
            this.btnOvjeraKarteZakljucka.Text = "Ovjera karte zaključka";
            this.btnOvjeraKarteZakljucka.UseVisualStyleBackColor = true;
            this.btnOvjeraKarteZakljucka.Click += new System.EventHandler(this.btnOvjeraKarteZakljucka_Click);
            // 
            // tbPolazna
            // 
            this.tbPolazna.Location = new System.Drawing.Point(395, 13);
            this.tbPolazna.Name = "tbPolazna";
            this.tbPolazna.Size = new System.Drawing.Size(211, 20);
            this.tbPolazna.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "Identifikator karte zaključka";
            // 
            // tbIdentifikatorKarte
            // 
            this.tbIdentifikatorKarte.Location = new System.Drawing.Point(172, 74);
            this.tbIdentifikatorKarte.Name = "tbIdentifikatorKarte";
            this.tbIdentifikatorKarte.Size = new System.Drawing.Size(105, 20);
            this.tbIdentifikatorKarte.TabIndex = 34;
            // 
            // btnKarta
            // 
            this.btnKarta.Location = new System.Drawing.Point(290, 72);
            this.btnKarta.Name = "btnKarta";
            this.btnKarta.Size = new System.Drawing.Size(27, 23);
            this.btnKarta.TabIndex = 35;
            this.btnKarta.Text = "+";
            this.btnKarta.UseVisualStyleBackColor = true;
            this.btnKarta.Click += new System.EventHandler(this.btnKarta_Click);
            // 
            // btnVreca
            // 
            this.btnVreca.Location = new System.Drawing.Point(268, 143);
            this.btnVreca.Name = "btnVreca";
            this.btnVreca.Size = new System.Drawing.Size(31, 23);
            this.btnVreca.TabIndex = 36;
            this.btnVreca.Text = "+";
            this.btnVreca.UseVisualStyleBackColor = true;
            this.btnVreca.Click += new System.EventHandler(this.btnVreca_Click);
            // 
            // btnPosiljke
            // 
            this.btnPosiljke.Location = new System.Drawing.Point(575, 143);
            this.btnPosiljke.Name = "btnPosiljke";
            this.btnPosiljke.Size = new System.Drawing.Size(31, 23);
            this.btnPosiljke.TabIndex = 37;
            this.btnPosiljke.Text = "+";
            this.btnPosiljke.UseVisualStyleBackColor = true;
            this.btnPosiljke.Click += new System.EventHandler(this.btnPosiljke_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Datum slanja";
            // 
            // tbDatumSlanja
            // 
            this.tbDatumSlanja.Location = new System.Drawing.Point(117, 107);
            this.tbDatumSlanja.Name = "tbDatumSlanja";
            this.tbDatumSlanja.Size = new System.Drawing.Size(182, 20);
            this.tbDatumSlanja.TabIndex = 39;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(495, 386);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(111, 38);
            this.btnOdjava.TabIndex = 40;
            this.btnOdjava.Text = "Odjava o neispravnosti";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Prikaži neispravne";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Prijem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.tbDatumSlanja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPosiljke);
            this.Controls.Add(this.btnVreca);
            this.Controls.Add(this.btnKarta);
            this.Controls.Add(this.tbIdentifikatorKarte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPolazna);
            this.Controls.Add(this.btnOvjeraKarteZakljucka);
            this.Controls.Add(this.btnOvjeraSpiska);
            this.Controls.Add(this.lbStatusKarte);
            this.Controls.Add(this.lbStatusPosiljke);
            this.Controls.Add(this.lbStatusSpiska);
            this.Controls.Add(this.lbStatusVrece);
            this.Controls.Add(this.tbIdentifikatorPosiljke);
            this.Controls.Add(this.tbIdentifikatorVrece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPosiljke);
            this.Controls.Add(this.dgvVrece);
            this.Controls.Add(this.dtpDatumPolaska);
            this.Controls.Add(this.tbPrijemna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(634, 532);
            this.MinimumSize = new System.Drawing.Size(634, 532);
            this.Name = "Prijem";
            this.Text = "Pošte Srpske - Prijem pošiljaka";
            this.Load += new System.EventHandler(this.Prijem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrijemna;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaska;
        private System.Windows.Forms.DataGridView dgvVrece;
        private System.Windows.Forms.DataGridView dgvPosiljke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdentifikatorVrece;
        private System.Windows.Forms.TextBox tbIdentifikatorPosiljke;
        private System.Windows.Forms.Label lbStatusVrece;
        private System.Windows.Forms.Label lbStatusSpiska;
        private System.Windows.Forms.Label lbStatusPosiljke;
        private System.Windows.Forms.Label lbStatusKarte;
        private System.Windows.Forms.Button btnOvjeraSpiska;
        private System.Windows.Forms.Button btnOvjeraKarteZakljucka;
        private System.Windows.Forms.TextBox tbPolazna;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIdentifikatorKarte;
        private System.Windows.Forms.Button btnKarta;
        private System.Windows.Forms.Button btnVreca;
        private System.Windows.Forms.Button btnPosiljke;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDatumSlanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentifikatorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimljenaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentifikatorV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimljenaV;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button button1;
    }
}
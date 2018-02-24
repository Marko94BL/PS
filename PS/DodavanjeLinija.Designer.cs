namespace PS
{
    partial class DodavanjeLinija
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
            this.cbPocetnaPosta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKrajnjaPosta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.mtbDolazak = new System.Windows.Forms.MaskedTextBox();
            this.mtbPolazak = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStavka = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbStavka = new System.Windows.Forms.MaskedTextBox();
            this.btnAddStavka = new System.Windows.Forms.Button();
            this.dgvStavka = new System.Windows.Forms.DataGridView();
            this.Poslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavka)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.InitialImage = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početna pošta";
            // 
            // cbPocetnaPosta
            // 
            this.cbPocetnaPosta.FormattingEnabled = true;
            this.cbPocetnaPosta.Location = new System.Drawing.Point(113, 86);
            this.cbPocetnaPosta.Name = "cbPocetnaPosta";
            this.cbPocetnaPosta.Size = new System.Drawing.Size(100, 21);
            this.cbPocetnaPosta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Krajnja pošta";
            // 
            // cbKrajnjaPosta
            // 
            this.cbKrajnjaPosta.FormattingEnabled = true;
            this.cbKrajnjaPosta.Location = new System.Drawing.Point(113, 125);
            this.cbKrajnjaPosta.Name = "cbKrajnjaPosta";
            this.cbKrajnjaPosta.Size = new System.Drawing.Size(100, 21);
            this.cbKrajnjaPosta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme polaska";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vrijeme dolaska";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(308, 157);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 26);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Potvrdi unos";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // mtbDolazak
            // 
            this.mtbDolazak.Location = new System.Drawing.Point(340, 126);
            this.mtbDolazak.Mask = "00:00";
            this.mtbDolazak.Name = "mtbDolazak";
            this.mtbDolazak.Size = new System.Drawing.Size(52, 20);
            this.mtbDolazak.TabIndex = 11;
            this.mtbDolazak.ValidatingType = typeof(System.DateTime);
            // 
            // mtbPolazak
            // 
            this.mtbPolazak.Location = new System.Drawing.Point(340, 85);
            this.mtbPolazak.Mask = "00:00";
            this.mtbPolazak.Name = "mtbPolazak";
            this.mtbPolazak.Size = new System.Drawing.Size(52, 20);
            this.mtbPolazak.TabIndex = 12;
            this.mtbPolazak.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Linija stavka";
            // 
            // cbStavka
            // 
            this.cbStavka.FormattingEnabled = true;
            this.cbStavka.Location = new System.Drawing.Point(92, 199);
            this.cbStavka.Name = "cbStavka";
            this.cbStavka.Size = new System.Drawing.Size(121, 21);
            this.cbStavka.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vrijeme";
            // 
            // mtbStavka
            // 
            this.mtbStavka.Location = new System.Drawing.Point(292, 199);
            this.mtbStavka.Mask = "00:00";
            this.mtbStavka.Name = "mtbStavka";
            this.mtbStavka.Size = new System.Drawing.Size(41, 20);
            this.mtbStavka.TabIndex = 16;
            this.mtbStavka.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddStavka
            // 
            this.btnAddStavka.Location = new System.Drawing.Point(356, 199);
            this.btnAddStavka.Name = "btnAddStavka";
            this.btnAddStavka.Size = new System.Drawing.Size(36, 23);
            this.btnAddStavka.TabIndex = 17;
            this.btnAddStavka.Text = "+";
            this.btnAddStavka.UseVisualStyleBackColor = true;
            this.btnAddStavka.Click += new System.EventHandler(this.btnAddStavka_Click);
            // 
            // dgvStavka
            // 
            this.dgvStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poslovnica,
            this.Vrijeme});
            this.dgvStavka.Location = new System.Drawing.Point(15, 253);
            this.dgvStavka.Name = "dgvStavka";
            this.dgvStavka.Size = new System.Drawing.Size(377, 154);
            this.dgvStavka.TabIndex = 18;
            // 
            // Poslovnica
            // 
            this.Poslovnica.HeaderText = "Poslovnica";
            this.Poslovnica.Name = "Poslovnica";
            this.Poslovnica.Width = 168;
            // 
            // Vrijeme
            // 
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Width = 168;
            // 
            // DodavanjeLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 423);
            this.Controls.Add(this.dgvStavka);
            this.Controls.Add(this.btnAddStavka);
            this.Controls.Add(this.mtbStavka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStavka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbPolazak);
            this.Controls.Add(this.mtbDolazak);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKrajnjaPosta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPocetnaPosta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodavanjeLinija";
            this.Text = "Pošte Srpske-Dodavanje linije";
            this.Load += new System.EventHandler(this.DodavanjeLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPocetnaPosta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKrajnjaPosta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox mtbDolazak;
        private System.Windows.Forms.MaskedTextBox mtbPolazak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStavka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbStavka;
        private System.Windows.Forms.Button btnAddStavka;
        private System.Windows.Forms.DataGridView dgvStavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
    }
}
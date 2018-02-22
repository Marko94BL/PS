namespace PS
{
    partial class UnosPosiljke
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
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.btnPotvrdiUnos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOdredisnaPosta = new System.Windows.Forms.ComboBox();
            this.cbPrijemnaPosta = new System.Windows.Forms.ComboBox();
            this.cbVrstaPosiljke = new System.Windows.Forms.ComboBox();
            this.cbVanVrece = new System.Windows.Forms.CheckBox();
            this.tbIdentifikator = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prijemna pošta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identifikator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vrsta pošiljke";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(282, 36);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(156, 20);
            this.tbDatum.TabIndex = 2;
            // 
            // btnPotvrdiUnos
            // 
            this.btnPotvrdiUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdiUnos.Location = new System.Drawing.Point(314, 169);
            this.btnPotvrdiUnos.Name = "btnPotvrdiUnos";
            this.btnPotvrdiUnos.Size = new System.Drawing.Size(124, 36);
            this.btnPotvrdiUnos.TabIndex = 11;
            this.btnPotvrdiUnos.Text = "Potvrdi unos";
            this.btnPotvrdiUnos.UseVisualStyleBackColor = true;
            this.btnPotvrdiUnos.Click += new System.EventHandler(this.btnPotvrdiUnos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Odredišna pošta";
            // 
            // cbOdredisnaPosta
            // 
            this.cbOdredisnaPosta.FormattingEnabled = true;
            this.cbOdredisnaPosta.Location = new System.Drawing.Point(152, 132);
            this.cbOdredisnaPosta.Name = "cbOdredisnaPosta";
            this.cbOdredisnaPosta.Size = new System.Drawing.Size(286, 21);
            this.cbOdredisnaPosta.TabIndex = 10;
            // 
            // cbPrijemnaPosta
            // 
            this.cbPrijemnaPosta.FormattingEnabled = true;
            this.cbPrijemnaPosta.Location = new System.Drawing.Point(282, 8);
            this.cbPrijemnaPosta.Name = "cbPrijemnaPosta";
            this.cbPrijemnaPosta.Size = new System.Drawing.Size(156, 21);
            this.cbPrijemnaPosta.TabIndex = 4;
            // 
            // cbVrstaPosiljke
            // 
            this.cbVrstaPosiljke.FormattingEnabled = true;
            this.cbVrstaPosiljke.Location = new System.Drawing.Point(250, 86);
            this.cbVrstaPosiljke.Name = "cbVrstaPosiljke";
            this.cbVrstaPosiljke.Size = new System.Drawing.Size(87, 21);
            this.cbVrstaPosiljke.TabIndex = 7;
            // 
            // cbVanVrece
            // 
            this.cbVanVrece.AutoSize = true;
            this.cbVanVrece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVanVrece.Location = new System.Drawing.Point(357, 86);
            this.cbVanVrece.Name = "cbVanVrece";
            this.cbVanVrece.Size = new System.Drawing.Size(81, 19);
            this.cbVanVrece.TabIndex = 8;
            this.cbVanVrece.Text = "Van Vreće";
            this.cbVanVrece.UseVisualStyleBackColor = true;
            // 
            // tbIdentifikator
            // 
            this.tbIdentifikator.Location = new System.Drawing.Point(88, 87);
            this.tbIdentifikator.Mask = "000000000";
            this.tbIdentifikator.Name = "tbIdentifikator";
            this.tbIdentifikator.Size = new System.Drawing.Size(64, 20);
            this.tbIdentifikator.TabIndex = 3;
            // 
            // UnosPosiljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 216);
            this.Controls.Add(this.tbIdentifikator);
            this.Controls.Add(this.cbVanVrece);
            this.Controls.Add(this.cbVrstaPosiljke);
            this.Controls.Add(this.cbPrijemnaPosta);
            this.Controls.Add(this.cbOdredisnaPosta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPotvrdiUnos);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(466, 255);
            this.MinimumSize = new System.Drawing.Size(466, 255);
            this.Name = "UnosPosiljke";
            this.Text = "Pošte Srpske - Unos nove pošiljke";
            this.Load += new System.EventHandler(this.UnosPosiljke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.Button btnPotvrdiUnos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOdredisnaPosta;
        private System.Windows.Forms.ComboBox cbPrijemnaPosta;
        private System.Windows.Forms.ComboBox cbVrstaPosiljke;
        private System.Windows.Forms.CheckBox cbVanVrece;
        private System.Windows.Forms.MaskedTextBox tbIdentifikator;
    }
}
namespace PS
{
    partial class GlavnaForma
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
            this.lbKorisnockoIme = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKorisnockoIme
            // 
            this.lbKorisnockoIme.AutoSize = true;
            this.lbKorisnockoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKorisnockoIme.Location = new System.Drawing.Point(97, 68);
            this.lbKorisnockoIme.Name = "lbKorisnockoIme";
            this.lbKorisnockoIme.Size = new System.Drawing.Size(88, 15);
            this.lbKorisnockoIme.TabIndex = 0;
            this.lbKorisnockoIme.Text = "Korisničko ime";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(277, 136);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(92, 33);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(194, 67);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(175, 20);
            this.tbKorisnickoIme.TabIndex = 1;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(194, 100);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(175, 20);
            this.tbLozinka.TabIndex = 3;
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLozinka.Location = new System.Drawing.Point(97, 101);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(50, 15);
            this.lbLozinka.TabIndex = 2;
            this.lbLozinka.Text = "Lozinka";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 182);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lbKorisnockoIme);
            this.MaximumSize = new System.Drawing.Size(397, 221);
            this.MinimumSize = new System.Drawing.Size(397, 221);
            this.Name = "GlavnaForma";
            this.Text = "Prijava na sistem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKorisnockoIme;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


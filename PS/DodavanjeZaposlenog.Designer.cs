namespace PS
{
    partial class DodavanjeZaposlenog
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
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLozinka2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
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
            this.label1.Location = new System.Drawing.Point(115, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite lozinku";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(269, 24);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(160, 20);
            this.tbKorisnickoIme.TabIndex = 0;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(269, 59);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.PasswordChar = '*';
            this.tbLozinka.Size = new System.Drawing.Size(160, 20);
            this.tbLozinka.TabIndex = 1;
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(305, 123);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(124, 36);
            this.btnDodajZaposlenog.TabIndex = 4;
            this.btnDodajZaposlenog.Text = "Potvrdi unos";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsAdmin.Location = new System.Drawing.Point(118, 123);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(61, 19);
            this.cbIsAdmin.TabIndex = 3;
            this.cbIsAdmin.Text = "Admin";
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ponovite unos lozinke";
            // 
            // tbLozinka2
            // 
            this.tbLozinka2.Location = new System.Drawing.Point(269, 91);
            this.tbLozinka2.Name = "tbLozinka2";
            this.tbLozinka2.PasswordChar = '*';
            this.tbLozinka2.Size = new System.Drawing.Size(160, 20);
            this.tbLozinka2.TabIndex = 2;
            // 
            // DodavanjeZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 171);
            this.Controls.Add(this.tbLozinka2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbIsAdmin);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodavanjeZaposlenog";
            this.Text = "Pošte Srpske - Unos novog  korisničkog naloga";
            this.Load += new System.EventHandler(this.DodavanjeZaposlenog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLozinka2;
    }
}
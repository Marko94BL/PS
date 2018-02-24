namespace PS
{
    partial class AdminMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMeni));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLinijeLista = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDodavanjeZaposlenog = new System.Windows.Forms.Button();
            this.btnDodavanjePoslovnice = new System.Windows.Forms.Button();
            this.btnDodavanjeLinije = new System.Windows.Forms.Button();
            this.lblLinijePregled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dodavanje linije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dodavanje poslovnice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodavanje korisnickog naloga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Odjava";
            // 
            // btnLinijeLista
            // 
            this.btnLinijeLista.BackgroundImage = global::PS.Properties.Resources.location;
            this.btnLinijeLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinijeLista.Location = new System.Drawing.Point(22, 157);
            this.btnLinijeLista.Name = "btnLinijeLista";
            this.btnLinijeLista.Size = new System.Drawing.Size(108, 88);
            this.btnLinijeLista.TabIndex = 8;
            this.btnLinijeLista.UseVisualStyleBackColor = true;
            this.btnLinijeLista.Click += new System.EventHandler(this.btnLinijeLista_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdjava.BackgroundImage")));
            this.btnOdjava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjava.Location = new System.Drawing.Point(191, 157);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(108, 88);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDodavanjeZaposlenog
            // 
            this.btnDodavanjeZaposlenog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodavanjeZaposlenog.BackgroundImage")));
            this.btnDodavanjeZaposlenog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjeZaposlenog.Location = new System.Drawing.Point(357, 12);
            this.btnDodavanjeZaposlenog.Name = "btnDodavanjeZaposlenog";
            this.btnDodavanjeZaposlenog.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjeZaposlenog.TabIndex = 2;
            this.btnDodavanjeZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodavanjeZaposlenog.Click += new System.EventHandler(this.btnDodavanjeZaposlenog_Click);
            // 
            // btnDodavanjePoslovnice
            // 
            this.btnDodavanjePoslovnice.BackgroundImage = global::PS.Properties.Resources.poslovnica;
            this.btnDodavanjePoslovnice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjePoslovnice.Location = new System.Drawing.Point(191, 12);
            this.btnDodavanjePoslovnice.Name = "btnDodavanjePoslovnice";
            this.btnDodavanjePoslovnice.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjePoslovnice.TabIndex = 1;
            this.btnDodavanjePoslovnice.UseVisualStyleBackColor = true;
            this.btnDodavanjePoslovnice.Click += new System.EventHandler(this.btnDodavanjePoslovnice_Click);
            // 
            // btnDodavanjeLinije
            // 
            this.btnDodavanjeLinije.BackgroundImage = global::PS.Properties.Resources.linija1;
            this.btnDodavanjeLinije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodavanjeLinije.Location = new System.Drawing.Point(22, 12);
            this.btnDodavanjeLinije.Name = "btnDodavanjeLinije";
            this.btnDodavanjeLinije.Size = new System.Drawing.Size(108, 88);
            this.btnDodavanjeLinije.TabIndex = 0;
            this.btnDodavanjeLinije.UseVisualStyleBackColor = true;
            this.btnDodavanjeLinije.Click += new System.EventHandler(this.btnDodavanjeLinije_Click);
            // 
            // lblLinijePregled
            // 
            this.lblLinijePregled.AutoSize = true;
            this.lblLinijePregled.Location = new System.Drawing.Point(34, 248);
            this.lblLinijePregled.Name = "lblLinijePregled";
            this.lblLinijePregled.Size = new System.Drawing.Size(88, 13);
            this.lblLinijePregled.TabIndex = 9;
            this.lblLinijePregled.Text = "Pregled svih linija";
            // 
            // AdminMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 298);
            this.Controls.Add(this.lblLinijePregled);
            this.Controls.Add(this.btnLinijeLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodavanjeZaposlenog);
            this.Controls.Add(this.btnDodavanjePoslovnice);
            this.Controls.Add(this.btnDodavanjeLinije);
            this.Name = "AdminMeni";
            this.Text = "AdminMeni";
            this.Load += new System.EventHandler(this.AdminMeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodavanjeLinije;
        private System.Windows.Forms.Button btnDodavanjePoslovnice;
        private System.Windows.Forms.Button btnDodavanjeZaposlenog;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLinijeLista;
        private System.Windows.Forms.Label lblLinijePregled;
    }
}
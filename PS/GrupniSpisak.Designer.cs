namespace PS
{
    partial class GrupniSpisak
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbLinije = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite liniju za koju se stampa grupni spsisak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stampaj grupni spisak razmjene";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbLinije
            // 
            this.cbLinije.FormattingEnabled = true;
            this.cbLinije.Location = new System.Drawing.Point(140, 38);
            this.cbLinije.Name = "cbLinije";
            this.cbLinije.Size = new System.Drawing.Size(231, 21);
            this.cbLinije.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // GrupniSpisak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 139);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbLinije);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "GrupniSpisak";
            this.Text = "Pošte Srpske - Kreiranje Grupnog Spiska Razmjene";
            this.Load += new System.EventHandler(this.GrupniSpisak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbLinije;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
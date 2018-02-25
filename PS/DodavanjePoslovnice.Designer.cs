namespace PS
{
    partial class DodavanjePoslovnice
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
            this.cb_Mjesto = new System.Windows.Forms.ComboBox();
            this.combo_PostanskiCentar = new System.Windows.Forms.ComboBox();
            this.tb_Naziv = new System.Windows.Forms.TextBox();
            this.tb_Adresa = new System.Windows.Forms.TextBox();
            this.check_PostanskiCentar = new System.Windows.Forms.CheckBox();
            this.btn_Potvrda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mjesto";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poštanski centar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cb_Mjesto
            // 
            this.cb_Mjesto.FormattingEnabled = true;
            this.cb_Mjesto.Location = new System.Drawing.Point(197, 103);
            this.cb_Mjesto.Name = "cb_Mjesto";
            this.cb_Mjesto.Size = new System.Drawing.Size(182, 21);
            this.cb_Mjesto.TabIndex = 2;
            // 
            // combo_PostanskiCentar
            // 
            this.combo_PostanskiCentar.FormattingEnabled = true;
            this.combo_PostanskiCentar.Location = new System.Drawing.Point(197, 143);
            this.combo_PostanskiCentar.Name = "combo_PostanskiCentar";
            this.combo_PostanskiCentar.Size = new System.Drawing.Size(182, 21);
            this.combo_PostanskiCentar.TabIndex = 4;
            // 
            // tb_Naziv
            // 
            this.tb_Naziv.Location = new System.Drawing.Point(197, 36);
            this.tb_Naziv.Name = "tb_Naziv";
            this.tb_Naziv.Size = new System.Drawing.Size(182, 20);
            this.tb_Naziv.TabIndex = 0;
            // 
            // tb_Adresa
            // 
            this.tb_Adresa.Location = new System.Drawing.Point(197, 70);
            this.tb_Adresa.Name = "tb_Adresa";
            this.tb_Adresa.Size = new System.Drawing.Size(182, 20);
            this.tb_Adresa.TabIndex = 1;
            // 
            // check_PostanskiCentar
            // 
            this.check_PostanskiCentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_PostanskiCentar.Location = new System.Drawing.Point(12, 124);
            this.check_PostanskiCentar.Name = "check_PostanskiCentar";
            this.check_PostanskiCentar.Size = new System.Drawing.Size(84, 57);
            this.check_PostanskiCentar.TabIndex = 3;
            this.check_PostanskiCentar.Text = "Dodaje se poštanski centar";
            this.check_PostanskiCentar.UseVisualStyleBackColor = true;
            this.check_PostanskiCentar.CheckedChanged += new System.EventHandler(this.check_PostanskiCentar_CheckedChanged);
            // 
            // btn_Potvrda
            // 
            this.btn_Potvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Potvrda.Location = new System.Drawing.Point(292, 179);
            this.btn_Potvrda.Name = "btn_Potvrda";
            this.btn_Potvrda.Size = new System.Drawing.Size(87, 34);
            this.btn_Potvrda.TabIndex = 5;
            this.btn_Potvrda.Text = "Potvrdi unos";
            this.btn_Potvrda.UseVisualStyleBackColor = true;
            this.btn_Potvrda.Click += new System.EventHandler(this.btn_Potvrda_Click);
            // 
            // DodavanjePoslovnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.Controls.Add(this.btn_Potvrda);
            this.Controls.Add(this.check_PostanskiCentar);
            this.Controls.Add(this.tb_Adresa);
            this.Controls.Add(this.tb_Naziv);
            this.Controls.Add(this.combo_PostanskiCentar);
            this.Controls.Add(this.cb_Mjesto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(412, 268);
            this.MinimumSize = new System.Drawing.Size(412, 268);
            this.Name = "DodavanjePoslovnice";
            this.Text = "Pošte Srpske - Dodavanje Poslovnice";
            this.Load += new System.EventHandler(this.DodavanjePoslovnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_Mjesto;
        private System.Windows.Forms.ComboBox combo_PostanskiCentar;
        private System.Windows.Forms.TextBox tb_Naziv;
        private System.Windows.Forms.TextBox tb_Adresa;
        private System.Windows.Forms.CheckBox check_PostanskiCentar;
        private System.Windows.Forms.Button btn_Potvrda;
    }
}
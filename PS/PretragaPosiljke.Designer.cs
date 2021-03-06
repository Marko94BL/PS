﻿namespace PS
{
    partial class PretragaPosiljke
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
            this.dgvPosiljke = new System.Windows.Forms.DataGridView();
            this.colDatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArhiva = new System.Windows.Forms.Button();
            this.tbIdentifikator = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifikator";
            // 
            // dgvPosiljke
            // 
            this.dgvPosiljke.AllowUserToAddRows = false;
            this.dgvPosiljke.AllowUserToDeleteRows = false;
            this.dgvPosiljke.AllowUserToResizeColumns = false;
            this.dgvPosiljke.AllowUserToResizeRows = false;
            this.dgvPosiljke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiljke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDatumVrijeme,
            this.colOznaka,
            this.Column1,
            this.Column2});
            this.dgvPosiljke.Location = new System.Drawing.Point(12, 55);
            this.dgvPosiljke.Name = "dgvPosiljke";
            this.dgvPosiljke.ReadOnly = true;
            this.dgvPosiljke.Size = new System.Drawing.Size(569, 231);
            this.dgvPosiljke.TabIndex = 2;
            // 
            // colDatumVrijeme
            // 
            this.colDatumVrijeme.FillWeight = 150F;
            this.colDatumVrijeme.HeaderText = "Poslovnica šalje";
            this.colDatumVrijeme.Name = "colDatumVrijeme";
            this.colDatumVrijeme.ReadOnly = true;
            this.colDatumVrijeme.Width = 150;
            // 
            // colOznaka
            // 
            this.colOznaka.HeaderText = "Poslovnica prima";
            this.colOznaka.Name = "colOznaka";
            this.colOznaka.ReadOnly = true;
            this.colOznaka.Width = 170;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vrijeme";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // btnArhiva
            // 
            this.btnArhiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArhiva.Location = new System.Drawing.Point(496, 13);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(85, 27);
            this.btnArhiva.TabIndex = 4;
            this.btnArhiva.Text = "Prikaži";
            this.btnArhiva.UseVisualStyleBackColor = true;
            this.btnArhiva.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // tbIdentifikator
            // 
            this.tbIdentifikator.Location = new System.Drawing.Point(88, 18);
            this.tbIdentifikator.Mask = "LL000000000LL";
            this.tbIdentifikator.Name = "tbIdentifikator";
            this.tbIdentifikator.Size = new System.Drawing.Size(89, 20);
            this.tbIdentifikator.TabIndex = 5;
            this.tbIdentifikator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbIdentifikator_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(193, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "zadnjih 6 mjeseci";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PretragaPosiljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 299);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbIdentifikator);
            this.Controls.Add(this.btnArhiva);
            this.Controls.Add(this.dgvPosiljke);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(609, 337);
            this.MinimumSize = new System.Drawing.Size(609, 337);
            this.Name = "PretragaPosiljke";
            this.Text = "Pošte Srpske - Pretraga pošiljaka";
            this.Load += new System.EventHandler(this.PretragaPosiljke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiljke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPosiljke;
        private System.Windows.Forms.Button btnArhiva;
        private System.Windows.Forms.MaskedTextBox tbIdentifikator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatumVrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
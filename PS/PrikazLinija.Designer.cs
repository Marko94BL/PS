namespace PS
{
    partial class PrikazLinija
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
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sve linije";
            // 
            // dgvLinije
            // 
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Od,
            this.Do,
            this.vrijemeP,
            this.vrijemeD});
            this.dgvLinije.Location = new System.Drawing.Point(15, 27);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(444, 244);
            this.dgvLinije.TabIndex = 1;
            this.dgvLinije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinije_CellClick);
            this.dgvLinije.Click += new System.EventHandler(this.dgvLinije_Click);
            // 
            // Od
            // 
            this.Od.HeaderText = "Od";
            this.Od.Name = "Od";
            // 
            // Do
            // 
            this.Do.HeaderText = "Do";
            this.Do.Name = "Do";
            // 
            // vrijemeP
            // 
            this.vrijemeP.HeaderText = "Vrijeme polaska";
            this.vrijemeP.Name = "vrijemeP";
            // 
            // vrijemeD
            // 
            this.vrijemeD.HeaderText = "Vrijeme dolaska";
            this.vrijemeD.Name = "vrijemeD";
            // 
            // PrikazLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 300);
            this.Controls.Add(this.dgvLinije);
            this.Controls.Add(this.label1);
            this.Name = "PrikazLinija";
            this.Text = "Pošte Srpske - Linije";
            this.Load += new System.EventHandler(this.PrikazLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeD;
    }
}
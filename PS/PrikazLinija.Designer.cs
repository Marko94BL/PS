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
            this.dgvLinije = new System.Windows.Forms.DataGridView();
            this.Od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinije
            // 
            this.dgvLinije.AllowUserToAddRows = false;
            this.dgvLinije.AllowUserToDeleteRows = false;
            this.dgvLinije.AllowUserToResizeColumns = false;
            this.dgvLinije.AllowUserToResizeRows = false;
            this.dgvLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Od,
            this.Do,
            this.vrijemeP,
            this.vrijemeD});
            this.dgvLinije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinije.Location = new System.Drawing.Point(0, 0);
            this.dgvLinije.Name = "dgvLinije";
            this.dgvLinije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinije.Size = new System.Drawing.Size(441, 277);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 277);
            this.Controls.Add(this.dgvLinije);
            this.Name = "PrikazLinija";
            this.Text = "Pošte Srpske - Linije";
            this.Load += new System.EventHandler(this.PrikazLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLinije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Do;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeD;
    }
}
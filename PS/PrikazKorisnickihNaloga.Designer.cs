namespace PS
{
    partial class PrikazKorisnickihNaloga
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
            this.gdwKorisnickiNalozi = new System.Windows.Forms.DataGridView();
            this.colKorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdwKorisnickiNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // gdwKorisnickiNalozi
            // 
            this.gdwKorisnickiNalozi.AllowUserToDeleteRows = false;
            this.gdwKorisnickiNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdwKorisnickiNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKorisnickoIme});
            this.gdwKorisnickiNalozi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdwKorisnickiNalozi.Location = new System.Drawing.Point(0, 0);
            this.gdwKorisnickiNalozi.Name = "gdwKorisnickiNalozi";
            this.gdwKorisnickiNalozi.ReadOnly = true;
            this.gdwKorisnickiNalozi.Size = new System.Drawing.Size(284, 261);
            this.gdwKorisnickiNalozi.TabIndex = 0;
            this.gdwKorisnickiNalozi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdwKorisnickiNalozi_CellClick);
            // 
            // colKorisnickoIme
            // 
            this.colKorisnickoIme.HeaderText = "Korisničko ime";
            this.colKorisnickoIme.Name = "colKorisnickoIme";
            this.colKorisnickoIme.ReadOnly = true;
            this.colKorisnickoIme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKorisnickoIme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colKorisnickoIme.Width = 141;
            // 
            // PrikazKorisnickihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gdwKorisnickiNalozi);
            this.Name = "PrikazKorisnickihNaloga";
            this.Text = "PrikazKorisnickihNaloga";
            this.Load += new System.EventHandler(this.PrikazKorisnickihNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdwKorisnickiNalozi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdwKorisnickiNalozi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKorisnickoIme;
    }
}
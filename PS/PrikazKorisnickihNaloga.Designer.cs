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
            this.label1 = new System.Windows.Forms.Label();
            this.dgwBlokirani = new System.Windows.Forms.DataGridView();
            this.colKI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdwKorisnickiNalozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBlokirani)).BeginInit();
            this.SuspendLayout();
            // 
            // gdwKorisnickiNalozi
            // 
            this.gdwKorisnickiNalozi.AllowUserToAddRows = false;
            this.gdwKorisnickiNalozi.AllowUserToDeleteRows = false;
            this.gdwKorisnickiNalozi.AllowUserToResizeColumns = false;
            this.gdwKorisnickiNalozi.AllowUserToResizeRows = false;
            this.gdwKorisnickiNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdwKorisnickiNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKorisnickoIme});
            this.gdwKorisnickiNalozi.Location = new System.Drawing.Point(12, 34);
            this.gdwKorisnickiNalozi.Name = "gdwKorisnickiNalozi";
            this.gdwKorisnickiNalozi.ReadOnly = true;
            this.gdwKorisnickiNalozi.Size = new System.Drawing.Size(287, 183);
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
            this.colKorisnickoIme.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(68, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktivni korisnički nalozi";
            // 
            // dgwBlokirani
            // 
            this.dgwBlokirani.AllowUserToAddRows = false;
            this.dgwBlokirani.AllowUserToDeleteRows = false;
            this.dgwBlokirani.AllowUserToResizeColumns = false;
            this.dgwBlokirani.AllowUserToResizeRows = false;
            this.dgwBlokirani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBlokirani.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKI});
            this.dgwBlokirani.Location = new System.Drawing.Point(326, 34);
            this.dgwBlokirani.Name = "dgwBlokirani";
            this.dgwBlokirani.ReadOnly = true;
            this.dgwBlokirani.Size = new System.Drawing.Size(287, 183);
            this.dgwBlokirani.TabIndex = 2;
            this.dgwBlokirani.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBlokirani_CellClick);
            // 
            // colKI
            // 
            this.colKI.HeaderText = "Korisničko ime";
            this.colKI.Name = "colKI";
            this.colKI.ReadOnly = true;
            this.colKI.Width = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blokirani korisnički nalozi";
            // 
            // PrikazKorisnickihNaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwBlokirani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdwKorisnickiNalozi);
            this.MaximumSize = new System.Drawing.Size(645, 268);
            this.MinimumSize = new System.Drawing.Size(645, 268);
            this.Name = "PrikazKorisnickihNaloga";
            this.Text = "PrikazKorisnickihNaloga";
            this.Load += new System.EventHandler(this.PrikazKorisnickihNaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdwKorisnickiNalozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBlokirani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdwKorisnickiNalozi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwBlokirani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKI;
    }
}
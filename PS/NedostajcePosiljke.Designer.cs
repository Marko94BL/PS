namespace PS
{
    partial class NedostajcePosiljke
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
            this.dgvNedostajuce = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedostajuce)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNedostajuce
            // 
            this.dgvNedostajuce.AllowUserToAddRows = false;
            this.dgvNedostajuce.AllowUserToDeleteRows = false;
            this.dgvNedostajuce.AllowUserToResizeColumns = false;
            this.dgvNedostajuce.AllowUserToResizeRows = false;
            this.dgvNedostajuce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNedostajuce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.statusCol});
            this.dgvNedostajuce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNedostajuce.Location = new System.Drawing.Point(0, 0);
            this.dgvNedostajuce.Name = "dgvNedostajuce";
            this.dgvNedostajuce.Size = new System.Drawing.Size(443, 159);
            this.dgvNedostajuce.TabIndex = 0;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Identifikator pošiljke";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 150;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Status pošiljke";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 250;
            // 
            // NedostajcePosiljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 159);
            this.Controls.Add(this.dgvNedostajuce);
            this.MaximumSize = new System.Drawing.Size(459, 198);
            this.MinimumSize = new System.Drawing.Size(459, 198);
            this.Name = "NedostajcePosiljke";
            this.Text = "Pošte Srpske - Pošiljke koje nedostaju";
            this.Load += new System.EventHandler(this.NedostajcePosiljke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNedostajuce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNedostajuce;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
    }
}
using PS.dao;
using PS.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS
{
    public partial class PrikazLinija : Form
    {
        public PrikazLinija()
        {
            InitializeComponent();
            LinijaDAO ldao = DAOFactory.getDAOFactory().getLinijaDAO();

            List<LinijaDTO> lista = ldao.linije();
            int i = 0;
            foreach(LinijaDTO linija in lista)
            {
                dgvLinije.Rows.Add(linija.PoslovnicaSalje.Naziv, linija.PoslovnicaPrima.Naziv, linija.VrijemePolaska.ToString(), linija.VrijemeDolaska.ToString());
            }
        }

        private void PrikazLinija_Load(object sender, EventArgs e)
        {
            dgvLinije.ClearSelection();
        }



        private void dgvLinije_Click(object sender, EventArgs e)
        {
           // LinijaDTO l = new LinijaDTO();
            //string s = dgvLinije.SelectedRow.Cells[0].Text;
            //Console.Write(dgvLinije.cl);
            //new DodavanjeLinija().ShowDialog();

        }

        private void dgvLinije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* int index = e.RowIndex;// get the Row Index
             DataGridViewRow selectedRow = dgvLinije.Rows[index];
             string od = selectedRow.Cells[0].Value.ToString();
             string doo = selectedRow.Cells[1].Value.ToString();
             string vrP = selectedRow.Cells[2].Value.ToString();
             string vrD = selectedRow.Cells[3].Value.ToString();

             LinijaDAO ldao = DAOFactory.getDAOFactory().getLinijaDAO();
             LinijaDTO l = ldao.
             new DodavanjeLinija().ShowDialog();*/

            if (dgvLinije.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dgvLinije.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }



        }
    }
}

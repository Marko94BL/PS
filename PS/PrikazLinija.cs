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
            

            if (dgvLinije.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // MessageBox.Show(dgvLinije.Rows[e.RowIndex].Cells[0].Value.ToString());
                string od = dgvLinije.Rows[e.RowIndex].Cells[0].Value.ToString();
                string doo = dgvLinije.Rows[e.RowIndex].Cells[1].Value.ToString();
                string vrijemeD= dgvLinije.Rows[e.RowIndex].Cells[2].Value.ToString();
                string vrijemeP = dgvLinije.Rows[e.RowIndex].Cells[3].Value.ToString();

                LinijaDTO linija = null;
                PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
                PoslovnicaDTO salje = pdao.pretragaPoNazivu(od);
                PoslovnicaDTO prima = pdao.pretragaPoNazivu(doo);
                TimeSpan vD = TimeSpan.Parse(vrijemeD);
                TimeSpan vP = TimeSpan.Parse(vrijemeP);

                LinijaDAO ldao = DAOFactory.getDAOFactory().getLinijaDAO();
                //linija=ldao.


            }



        }
    }
}

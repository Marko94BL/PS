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
            foreach(LinijaDTO linija in lista)
            {
               // dgvLinije.Rows.Add(tbIdentifikator.Text.Trim());
            }
        }

        private void PrikazLinija_Load(object sender, EventArgs e)
        {
            
        }
    }
}

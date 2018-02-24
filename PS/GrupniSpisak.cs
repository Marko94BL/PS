using PS.dto;
using PS.dao;
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
    public partial class GrupniSpisak : Form
    {
        public GrupniSpisak()
        {
            InitializeComponent();
        }

        private void GrupniSpisak_Load(object sender, EventArgs e)
        {
            LinijaDAO ldao = DAOFactory.getDAOFactory().getLinijaDAO();
            List<LinijaDTO> list = ldao.linije();
            foreach(LinijaDTO linija in list)
            {
                cbLinije.Items.Add(linija);
            }
        }
    }
}

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
    public partial class DodavanjePoslovnice : Form
    {
        public DodavanjePoslovnice()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            combo_PostanskiCentar.Enabled = true;
        }

        private void DodavanjePoslovnice_Load(object sender, EventArgs e)
        {
            MjestoDAO mjestoDAO = DAOFactory.getDAOFactory().getMjestoDAO();
            cb_Mjesto.Items.Add(mjestoDAO.mjesta());
            PoslovnicaDAO poslovnicaDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            combo_PostanskiCentar.Items.Add(poslovnicaDAO.poslovnice());
            combo_PostanskiCentar.Enabled = false;
        }
    }
}

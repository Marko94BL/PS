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
    public partial class DodavanjePoslovnice : Form
    {
        public DodavanjePoslovnice()
        {
            InitializeComponent();
        }

        private void check_PostanskiCentar_CheckedChanged(object sender, EventArgs e)
        {
            combo_PostanskiCentar.Enabled = !check_PostanskiCentar.Checked;
        }

        private void DodavanjePoslovnice_Load(object sender, EventArgs e)
        {
            MjestoDAO mjestoDAO = DAOFactory.getDAOFactory().getMjestoDAO();
            cb_Mjesto.Items.Add(mjestoDAO.mjesta());
            PoslovnicaDAO poslovnicaDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            combo_PostanskiCentar.Items.Add(poslovnicaDAO.poslovnice());
            combo_PostanskiCentar.Enabled = false;
        }

        private void Btn_Potvrda_Click(object sender, EventArgs e)
        {
            if (!("").Equals(tb_Naziv.Text.Trim()) && !("").Equals(tb_Adresa.Text.Trim()) && (cb_Mjesto.SelectedIndex != 0) && (check_PostanskiCentar.Checked || (!check_PostanskiCentar.Checked && combo_PostanskiCentar.SelectedIndex != 0)))
            {
                PoslovnicaDAO poslovnicaDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
                poslovnicaDAO.insert(new PoslovnicaDTO(0, tb_Naziv.Text.Trim(), cb_Mjesto.SelectedItem as MjestoDTO, tb_Adresa.Text.Trim(), check_PostanskiCentar.Checked?null:combo_PostanskiCentar.SelectedItem as PoslovnicaDTO);
            }
        }
    }
}

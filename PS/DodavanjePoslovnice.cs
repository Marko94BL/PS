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

            List<MjestoDTO> lista = mjestoDAO.mjesta();
            foreach (MjestoDTO mjesto in lista)
            {
                cb_Mjesto.Items.Add(mjesto);
            }

            //cb_Mjesto.Items.Add(mjestoDAO.mjesta());
            PoslovnicaDAO poslovnicaDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> listaPoslovnica = poslovnicaDAO.poslovnice();
            foreach (PoslovnicaDTO poslovnica in listaPoslovnica)
            {
                combo_PostanskiCentar.Items.Add(poslovnica);
            }
            combo_PostanskiCentar.Enabled = true;
        }

        private void btn_Potvrda_Click(object sender, EventArgs e)
        {
            if (!("").Equals(tb_Naziv.Text.Trim()) && !("").Equals(tb_Adresa.Text.Trim()) && (cb_Mjesto.SelectedIndex != -1) && (check_PostanskiCentar.Checked || (!check_PostanskiCentar.Checked && combo_PostanskiCentar.SelectedIndex != -1)))
            {
                PoslovnicaDAO poslovnicaDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
                bool flag = poslovnicaDAO.insert(new PoslovnicaDTO(0, tb_Naziv.Text.Trim(), cb_Mjesto.SelectedItem as MjestoDTO, tb_Adresa.Text.Trim(), check_PostanskiCentar.Checked?null:combo_PostanskiCentar.SelectedItem as PoslovnicaDTO));
                if (flag == true)
                {
                    MessageBox.Show("Uspješno ste dodali novu poslovnicu ", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else {
                    MessageBox.Show("Greška prilikom dodavanja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }
    }
}

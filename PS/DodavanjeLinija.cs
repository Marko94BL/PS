﻿using PS.dao;
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
    public partial class DodavanjeLinija : Form
    {
        int pocetna, krajnja;
        long rez;

        internal DodavanjeLinija(LinijaDTO linija)
        {

            InitializeComponent();
            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPocetnaPosta.Items.Add(poslovnica);
                cbKrajnjaPosta.Items.Add(poslovnica);
            }
            cbPocetnaPosta.Text = linija.PoslovnicaSalje.Naziv;
            cbKrajnjaPosta.Text = linija.PoslovnicaPrima.Naziv;
            mtbDolazak.Text = linija.VrijemeDolaska.ToString();
            mtbPolazak.Text = linija.VrijemePolaska.ToString();
            pocetna = linija.PoslovnicaSalje.PoslovnicaId;
            krajnja = linija.PoslovnicaPrima.PoslovnicaId;
        }

        public DodavanjeLinija()
        {
            InitializeComponent();
            cbPocetnaPosta.Text = "Odaberite";
             cbKrajnjaPosta.Text = "Odaberite";
        }

        private void DodavanjeLinija_Load(object sender, EventArgs e)
        {
        

            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPocetnaPosta.Items.Add(poslovnica);
                cbKrajnjaPosta.Items.Add(poslovnica);
                cbStavka.Items.Add(poslovnica);
            }
        }

        private void btnAddStavka_Click(object sender, EventArgs e)
        {
            PoslovnicaDTO stavka = cbStavka.SelectedItem as PoslovnicaDTO;
            TimeSpan vrijeme =TimeSpan.Parse( mtbStavka.Text);
            LinijaStavkaDAO lsdao = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
            LinijaStavkaDTO lstavka = new LinijaStavkaDTO(int.Parse(rez.ToString()), stavka, vrijeme);
            int p = lsdao.insert(lstavka);
            dgvStavka.Rows.Add(lstavka.Poslovnica.Naziv, lstavka.Vrijeme.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = 0;
            String username = GlavnaForma.Prijavljeni.KorisnickoIme;
            PoslovnicaDTO pocetnaPosta = (cbPocetnaPosta.SelectedItem as PoslovnicaDTO);
            PoslovnicaDTO krajnjaPosta = (cbKrajnjaPosta.SelectedItem as PoslovnicaDTO);
            TimeSpan vrijemeP = TimeSpan.Parse(mtbPolazak.Text);
            TimeSpan vrijemeD = TimeSpan.Parse(mtbDolazak.Text);

            if (!(pocetnaPosta.Equals(null) || krajnjaPosta.Equals(null) || vrijemeP == null || vrijemeD == null))
            {
                LinijaDAO lDAO = DAOFactory.getDAOFactory().getLinijaDAO();
                
                LinijaDTO linija1 = new LinijaDTO(id, pocetnaPosta, krajnjaPosta,vrijemeP, vrijemeD );
                 rez = lDAO.insert(linija1, pocetna, krajnja);
                if (rez!=0)
                {
                    MessageBox.Show("Uspješno dodavanje nove linije", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();

                }

            }
        }
    }
}

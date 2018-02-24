using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.dto;
using PS.dao;

namespace PS
{
    public partial class PojedinacniSpisak : Form
    {
        int kartaZakljuckaId;
        List<string> vreceOIdLista = new List<string>();

        public PojedinacniSpisak(string otprema, string od, string za, string datum, int kartaZakljucka)
        {
            InitializeComponent();
            tbOtprema.Text = otprema;
            tbOtprema.Enabled = false;
            tbOd.Text = od;
            tbOd.Enabled = false;
            tbZa.Text = za;
            tbZa.Enabled = false;
            tbDatum.Text = datum;
            tbDatum.Enabled = false;
            this.kartaZakljuckaId = kartaZakljucka;
        } 

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            vreceOIdLista.Add(tbIdentifikator.Text.Trim());
            dgvVrece.Rows.Add(tbIdentifikator.Text.Trim());
        }

        private void btnKreirajSpisak_Click(object sender, EventArgs e)
        {
            VrecaDAO vdao = DAOFactory.getDAOFactory().getVrecaDAO();
            foreach (string vreca in vreceOIdLista)
            {
                KartaZakljuckaDTO karta = new KartaZakljuckaDTO();
                karta.KartaID = kartaZakljuckaId;
                vdao.insert(new VrecaDTO(karta, 0, vreca));
            }

            //kreiranje stringa za upis u fajl
            string text = "                                                                Datum: " + tbDatum.Text + "\r\n" +
                          "                                        " + "Spisak razmjene         Otprema: " + tbOtprema.Text.Trim() + "\r\n\r\n" +
                "            Od: " + tbOd.Text + "                                              Za: " + tbZa.Text + "\r\n" + "Identifikator\r\n_______________\r\n ";
            foreach (string vreca in vreceOIdLista)
            {
                text += vreca + "\r\n";
            }
            System.IO.File.WriteAllText(@".\spiskoviRazmjene\sr" + kartaZakljuckaId + ".txt", text);

            MessageBox.Show("Pojedinacni spisak kreiran!");
            this.Close();
        }

        private void tbIdentifikator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodaj_Click(this, new EventArgs());
            }
        }
    }
}


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
    public partial class Kartovanje : Form
    {
        private KartaZakljuckaDTO kartaZakljucka;
        private string prijemnaPosta;
        private string odredisnaPosta;
        private string datum;

        List<PosiljkaDTO> posiljkeIdLista = new List<PosiljkaDTO>();
        public Kartovanje()
        {
            InitializeComponent();
            cbPrijemnaPosta.Text = "        Odaberite";
            cbOdredisnaPosta.Text = "      Odaberite";
            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPrijemnaPosta.Items.Add(poslovnica);
                cbOdredisnaPosta.Items.Add(poslovnica);
            }
        }

        private void btnDodajNaPopis_Click(object sender, EventArgs e)
        {
            PosiljkaDAO pdao = DAOFactory.getDAOFactory().getPosiljkaDAO();
            PosiljkaDTO posiljka = pdao.vratiPosiljku(int.Parse(tbIdentifikator.Text.Trim()));//sadrzaj text field-a
            if(posiljka!=null)
            {
                posiljkeIdLista.Add(posiljka);
                dgvKartaZakljucka.Rows.Add(tbIdentifikator.Text.Trim());
             }
             else
            { 
                MessageBox.Show("Posiljka sa unijetim ID ne postoji.");
            }
        }

        private void btnKreirajKartu_Click(object sender, EventArgs e)
        {
            prijemnaPosta = (cbPrijemnaPosta.SelectedItem as PoslovnicaDTO).ToString();
            odredisnaPosta = (cbOdredisnaPosta.SelectedItem as PoslovnicaDTO).ToString();
            datum = dtpDatum.Value.ToString();

            KartaZakljuckaDAO kzdao = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
            KorisnickiNalogDTO nalog = new KorisnickiNalogDTO();
            nalog = GlavnaForma.Prijavljeni;
            kartaZakljucka = new KartaZakljuckaDTO(0, "S", dtpDatum.Value, int.Parse(tbOtprema.Text.Trim()), tbNapomena.Text.Trim(),
               nalog, cbPrijemnaPosta.SelectedItem as PoslovnicaDTO, cbOdredisnaPosta.SelectedItem as PoslovnicaDTO);

            PosiljkaStatusDAO psdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();

            kartaZakljucka.KartaID = kzdao.insert(kartaZakljucka);

            foreach (PosiljkaDTO posiljka in posiljkeIdLista)
            {
                psdao.insert(new PosiljkaStatusDTO(new StatusDTO(2, ""), posiljka, kartaZakljucka));
            }
            lbStatus.Text = "Kreirana karta zakljucka!";
            btnKreirajKartu.Enabled = false;
        }

        private void btnKreirajSpisakRazmjene_Click(object sender, EventArgs e)
        {
            new PojedinacniSpisak(tbOtprema.Text.Trim(), prijemnaPosta, odredisnaPosta, datum, kartaZakljucka.KartaID).ShowDialog();
        }
    }
}

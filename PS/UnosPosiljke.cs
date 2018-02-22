using System;
using PS.dto;
using PS.dao;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PS
{
    public partial class UnosPosiljke : Form
    {
        public UnosPosiljke()
        {
            InitializeComponent();
        }

        private void UnosPosiljke_Load(object sender, EventArgs e)
        {
            cbPrijemnaPosta.Text = "                Odaberite";
            cbOdredisnaPosta.Text = "                           Odaberite";
            cbVrstaPosiljke.Text = "    Odabetite";

            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPrijemnaPosta.Items.Add(poslovnica);
                cbOdredisnaPosta.Items.Add(poslovnica);
            }

            PosiljkaTipDAO ptDAO = DAOFactory.getDAOFactory().getPosiljkaTipDAO();
            List<PosiljkaTipDTO> tipovi = ptDAO.posiljkaTipovi();

            foreach (PosiljkaTipDTO tip in tipovi)
            {
                cbVrstaPosiljke.Items.Add(tip);
            }

            string datumString = DateTime.Today.ToString("yyyy-MM-dd");
            tbDatum.Text = datumString;
            tbDatum.Enabled = false;
            tbDatum.ForeColor = Color.Gray;
        }

        private void btnPotvrdiUnos_Click(object sender, EventArgs e)
        {
            String jmb = GlavnaForma.Prijavljeni.Jmb;
            PoslovnicaDTO prijemnaPosta = (cbPrijemnaPosta.SelectedItem as PoslovnicaDTO);
            DateTime vrijeme = DateTime.Now;
            string identifikator = tbIdentifikator.Text.Trim();
            int id = int.Parse(identifikator);
            bool punoPolje = !(tbIdentifikator.MaskFull);
            PosiljkaTipDTO vrstaPosiljke = (cbVrstaPosiljke.SelectedItem as PosiljkaTipDTO);
            byte vanVrece = Convert.ToByte(cbVanVrece.Checked);
            PoslovnicaDTO odredisnaPosta = (cbPrijemnaPosta.SelectedItem as PoslovnicaDTO);

            if (!(prijemnaPosta.Equals(null) || punoPolje || vrstaPosiljke.Equals(null) || odredisnaPosta.Equals(null)))
            {
                PosiljkaDAO pDAO = DAOFactory.getDAOFactory().getPosiljkaDAO();
                ZaposleniDAO zdao = DAOFactory.getDAOFactory().getZapsleniDAO();
                ZaposleniDTO zaposleni = zdao.vratiZaposlenog(GlavnaForma.Prijavljeni.Jmb);
                PosiljkaDTO posiljka = new PosiljkaDTO(id, prijemnaPosta, odredisnaPosta, zaposleni, vrstaPosiljke, vrijeme, vanVrece);
                bool rez = pDAO.insert(posiljka);
                if (rez)
                {
                    this.Close();
                }
            }
        }
    }
}

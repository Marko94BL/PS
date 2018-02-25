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
            cbPrijemnaPosta.Text = "                Odaberite                ";
            cbOdredisnaPosta.Text = "                           Odaberite                           ";

            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();
            
            foreach (PoslovnicaDTO poslovnica in lista)
            {
                //System.Console.Write(poslovnica);
                cbPrijemnaPosta.Items.Add(poslovnica);
                cbOdredisnaPosta.Items.Add(poslovnica);
            }

           // PosiljkaTipDAO ptDAO = DAOFactory.getDAOFactory().getPosiljkaTipDAO();
           // List<PosiljkaTipDTO> tipovi = ptDAO.posiljkaTipovi();

           /* foreach (PosiljkaTipDTO tip in tipovi)
            {
                cbVrstaPosiljke.Items.Add(tip);
            }*/

            string datumString = DateTime.Today.ToString("yyyy-MM-dd");
            tbDatum.Text = datumString;
            tbDatum.Enabled = false;
            tbDatum.ForeColor = Color.Gray;
        }

        private void btnPotvrdiUnos_Click(object sender, EventArgs e)
        {
          //  String jmb = GlavnaForma.Prijavljeni.Jmb;
            PoslovnicaDTO prijemnaPosta = (cbPrijemnaPosta.SelectedItem as PoslovnicaDTO);
            DateTime vrijeme = DateTime.Now;
            string identifikator = tbIdentifikator.Text.Trim();
            bool punoPolje = !(tbIdentifikator.MaskFull);
           // PosiljkaTipDTO vrstaPosiljke = (cbVrstaPosiljke.SelectedItem as PosiljkaTipDTO);
            byte vanVrece = Convert.ToByte(cbVanVrece.Checked);
            PoslovnicaDTO odredisnaPosta = (cbOdredisnaPosta.SelectedItem as PoslovnicaDTO);

            if (!(prijemnaPosta == null || punoPolje || odredisnaPosta == null))
            {
                PosiljkaDAO pDAO = DAOFactory.getDAOFactory().getPosiljkaDAO();
                KorisnickiNalogDAO kdao = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                KorisnikDTO korisnik = kdao.pretragaPoId(GlavnaForma.Prijavljeni.NalogId);
                //System.Console.WriteLine("prijemnaPosta: " + prijemnaPosta + " odredisnaPosta: " + odredisnaPosta + " korisnik: " + korisnik.NalogId + " vrijeme: " + vrijeme + " vanVrece: " + vanVrece + " ident: " + identifikator);
                PosiljkaDTO posiljka = new PosiljkaDTO(0, prijemnaPosta, odredisnaPosta, korisnik, vrijeme, vanVrece, identifikator);
                bool rez = pDAO.insert(posiljka);
                if (rez)
                {
                    MessageBox.Show("Uspješno ste dodali novu pošiljku", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

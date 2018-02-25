using PS.controlers;
using PS.dao;
using PS.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            }

           
        }

        private void btnDodajNaPopis_Click(object sender, EventArgs e)
        {
            PosiljkaDAO pdao = DAOFactory.getDAOFactory().getPosiljkaDAO();
            PosiljkaDTO posiljka = pdao.vratiPosiljku(tbIdentifikator.Text.Trim());
            if(posiljka!=null)
            {
                posiljkeIdLista.Add(posiljka);
                dgvKartaZakljucka.Rows.Add(tbIdentifikator.Text.Trim());
             }
             else
            { 
                MessageBox.Show("Posiljka sa unijetim ID ne postoji.");
            }
            tbIdentifikator.Text = "";
        }

        private void btnKreirajKartu_Click(object sender, EventArgs e)
        {
            if (cbPrijemnaPosta.SelectedIndex > -1 && cbOdredisnaPosta.SelectedIndex > -1 && (tbOtprema != null && !tbOtprema.Text.Equals("")))
            {
                prijemnaPosta = (cbPrijemnaPosta.SelectedItem as PoslovnicaDTO).ToString();
                odredisnaPosta = (cbOdredisnaPosta.SelectedItem as PoslovnicaDTO).ToString();
                datum = dtpDatum.Value.ToString();

            
                KartaZakljuckaDAO kzdao = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
                KorisnikDTO nalog = new KorisnikDTO();
                nalog = GlavnaForma.Prijavljeni;
                kartaZakljucka = new KartaZakljuckaDTO(0, "S", dtpDatum.Value, int.Parse(tbOtprema.Text.Trim()), tbNapomena.Text.Trim(),
                   nalog, cbPrijemnaPosta.SelectedItem as PoslovnicaDTO, cbOdredisnaPosta.SelectedItem as PoslovnicaDTO);

                PosiljkaStatusDAO psdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();

                kartaZakljucka.KartaID = kzdao.insert(kartaZakljucka);

                foreach (PosiljkaDTO posiljka in posiljkeIdLista)
                {
                    psdao.insert(new PosiljkaStatusDTO(new StatusDTO(1, "Poslana", "Pošiljka je poslana"), posiljka, kartaZakljucka, 0));
                }

                PosiljkaDAO pdao = DAOFactory.getDAOFactory().getPosiljkaDAO();
                int brojPosiljaka = pdao.brojPosiljaka(kartaZakljucka.KartaID);

                //kreiranje stringa za upis u fajl
                Printer p = new Printer(1);
                string podvlacenje = "==============================================================================\r\n";
                p.Text = "                                Karta zaključka                                \r\n";
                p.Text += podvlacenje;
                p.Text += "Karta zaključka od: " + prijemnaPosta + ", Za: " + odredisnaPosta + "\r\n";
                p.Text += "Identifikator karte zaključka: " + kartaZakljucka.KartaID + "\r\n";
                p.Text += "Otprema: " + tbOtprema.Text.Trim() + "\r\n";
                p.Text += "Datum kreiranja: " + datum + "\r\n";
                p.Text += "Broj posiljaka: " + brojPosiljaka + "\r\n";
                p.Text += podvlacenje;
                p.Text += "Prijemni brojevi pošiljaka: \r\n";
                for(int i = 0; i < posiljkeIdLista.Count; i++)
                {
                    p.Text += " "+(i+1)+". " + posiljkeIdLista[i].Barkod + "\r\n";
                }
                p.Text += podvlacenje;
                p.PrintToPDF();
                lbStatus.Text = "Kreirana karta zakljucka!";
                btnKreirajKartu.Enabled = false;
                btnKreirajSpisakRazmjene.Enabled = true;
            }
        }

        private void btnKreirajSpisakRazmjene_Click(object sender, EventArgs e)
        {
            new PojedinacniSpisak(tbOtprema.Text.Trim(), prijemnaPosta, odredisnaPosta, datum, kartaZakljucka.KartaID).ShowDialog();
            btnKreirajSpisakRazmjene.Enabled = false;
        }

        private void cbPrijemnaPosta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOdredisnaPosta.Items.Clear();
            PoslovnicaDTO posl = cbPrijemnaPosta.SelectedItem as PoslovnicaDTO;
            bool isPC;
            if (posl.PostanskiCentar == null) isPC = true; else isPC = false;
            Console.Write(isPC);
            PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            if (isPC)
            {
                List<PoslovnicaDTO> listaSvih = pdao.poslovnice();
                foreach (PoslovnicaDTO p in listaSvih)
                {
                    if (p.PostanskiCentar!=null && p.PostanskiCentar.PoslovnicaId == posl.PoslovnicaId && p.PoslovnicaId!=posl.PoslovnicaId)
                    {
                        cbOdredisnaPosta.Items.Add(p);
                    }
                    else if(p.PostanskiCentar==null && p.PoslovnicaId!=posl.PoslovnicaId)
                    {
                        cbOdredisnaPosta.Items.Add(p);
                    }
                }

                
            }else
            {
                PoslovnicaDTO pc = pdao.vratiPoslovnicu(posl.PostanskiCentar.PoslovnicaId);
                cbOdredisnaPosta.Items.Add(pc);
            }
        }

        private void tbIdentifikator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodajNaPopis_Click(this, new EventArgs());
            }
        }

        private void Kartovanje_Load(object sender, EventArgs e)
        {
            btnKreirajSpisakRazmjene.Enabled = false;
           // tbIdentifikator.Select(0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

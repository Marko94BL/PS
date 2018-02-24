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
    public partial class Prijem : Form
    {
        private KartaZakljuckaDTO kartaZakljucka;
        private PosiljkaDTO posiljka;
        private int idPoslovnicaPrima = 0;
        private List<PosiljkaDTO> nedostajucePosiljke ;

        public Prijem()
        {
            InitializeComponent();
        }

        private void Prijem_Load(object sender, EventArgs e)
        {
            btnOdjava.Enabled = false;
        }

        
        private void btnKarta_Click(object sender, EventArgs e)
        {
            KartaZakljuckaDAO kzdao = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
            kartaZakljucka = kzdao.vratiKartaZakljucka(int.Parse(tbIdentifikatorKarte.Text.Trim()));

            tbPolazna.Text = kartaZakljucka.PoslovnicaSalje.ToString();
            tbPolazna.Enabled = false;

            idPoslovnicaPrima = kartaZakljucka.PoslovnicaPrima.PoslovnicaId;

            tbPrijemna.Text = kartaZakljucka.PoslovnicaPrima.ToString();
            tbPrijemna.Enabled = false;
            tbDatumSlanja.Text = kartaZakljucka.Vrijeme.ToString();
            tbDatumSlanja.Enabled = false;

            VrecaDAO vdao = DAOFactory.getDAOFactory().getVrecaDAO();
            List<VrecaDTO> vrece = vdao.vrece(kartaZakljucka);

            PosiljkaStatusDAO psdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            List<PosiljkaStatusDTO> posiljkeStatusLista = psdao.posiljkeStatus(kartaZakljucka);

            foreach (VrecaDTO vreca in vrece)
            {
                dgvVrece.Rows.Add(vreca.Broj, "NOK");
            }
            foreach (PosiljkaStatusDTO posiljkaStatus in posiljkeStatusLista)
            {
               dgvPosiljke.Rows.Add(posiljkaStatus.Posiljka.Barkod, "NOK");
            }
        }

        private void btnVreca_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (DataGridViewRow red in dgvVrece.Rows)
            {
               // System.Console.Write(tbIdentifikatorVrece.Text.Trim() + " "+ red.Cells[0].Value+" *");
                if (red.Cells[0].Value != null && (tbIdentifikatorVrece.Text.Trim()).Equals(red.Cells[0].Value))
                {
                    flag = true;
                    red.Cells[1].Value = "OK";
                    lbStatusVrece.Text = "Vreca pripada karti zakljucka!";
                }
            }
            if(!flag)
                lbStatusVrece.Text = "Vreca ne pripada karti zakljucka!";
        }

        private void btnOvjeraSpiska_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string ok = "OK";
            foreach (DataGridViewRow red in dgvVrece.Rows)
            {
                try
                {
                    if (!(ok.Equals(red.Cells[1].Value.ToString())))
                {
                    counter++;
                }
                }
                catch (Exception ee)
                {
                }
            }
            if (counter == 0)
                lbStatusSpiska.Text = "Primljene sve vreće sa spiska razmjene.";
            else
                lbStatusSpiska.Text = "Broj vreća koje nisu pristigle:" + counter;
        }

        private void btnPosiljke_Click(object sender, EventArgs e)
        {
            PosiljkaDAO pdao = DAOFactory.getDAOFactory().getPosiljkaDAO();
            posiljka = pdao.vratiPosiljku(tbIdentifikatorPosiljke.Text.Trim());
            bool flag = false;
            foreach (DataGridViewRow red in dgvPosiljke.Rows)
            {
                if (red.Cells[0].Value != null && (tbIdentifikatorPosiljke.Text.Trim()).Equals(red.Cells[0].Value))
                {
                    flag = true;
                    red.Cells[1].Value = "OK";
                    lbStatusPosiljke.Text = "Posiljka pripada karti zakljucka!";
                }
            }
            if (!flag)
            {
                lbStatusPosiljke.Text = "Posiljka ne pripada karti zakljucka!";
                btnOdjava.Enabled = true;
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            tbIdentifikatorPosiljke.Text = "";

            PoslovnicaDAO podao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            PoslovnicaDTO odredisnaPosta = podao.vratiPoslovnicu(idPoslovnicaPrima);

            string napomena = "Primljena posiljka pronađena u pošti "+odredisnaPosta.Naziv;
            OdjavaONeispravnostiDAO odao = DAOFactory.getDAOFactory().getOdjavaONeispravnostiDAO();


            OdjavaONeispravnostiDTO odjava = new OdjavaONeispravnostiDTO(0, napomena, posiljka, kartaZakljucka,odredisnaPosta);

            odao.insert(odjava);

            //azuriranje statusa posiljke u visak
            PosiljkaStatusDAO posiljkaStatusDAO = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            System.Console.Write("id posiljka "+posiljka.PosiljkaID+" id karta " +kartaZakljucka.KartaID);
            PosiljkaStatusDTO psDTO = posiljkaStatusDAO.posiljkaStatusKarta(posiljka.PosiljkaID);
            if (psDTO != null)
            {
                psDTO.Status.StatusID = 4;
                posiljkaStatusDAO.update(psDTO);

                MessageBox.Show("Uspješno ste prijavili grešku prilikom prijema", "Uspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             btnOdjava.Enabled = false;
        }

        private void btnOvjeraKarteZakljucka_Click(object sender, EventArgs e) //moram promjeniti status posiljke u primljen tj 2
        {
            KartaZakljuckaDAO kdao = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
            kartaZakljucka.VrijemeStigla = dtpDatumPolaska.Value;
            kdao.azurirajDatum(kartaZakljucka);
            int counter = 0;
            string ok = "OK";
            PosiljkaStatusDAO pdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            PosiljkaStatusDTO posiljkaStatus = new PosiljkaStatusDTO();

            foreach (DataGridViewRow red in dgvPosiljke.Rows)
            {
                //    MessageBox.Show("hhh"+red.Cells[1].Value.ToString()+"hhh");
                try
                {
                    if (ok.Equals(red.Cells[1].Value.ToString()))
                    {
                        PosiljkaDTO p = new PosiljkaDTO();
                        p.PosiljkaID = int.Parse(red.Cells[0].Value.ToString());
                      //  pdao.insert(new PosiljkaStatusDTO(new StatusDTO(1, ""), p, kartaZakljucka));
                    }
                    else
                    {
                        counter++;
                    }
                }
                catch (Exception ee)
                {
                }
            }
            if (counter == 0)
                lbStatusKarte.Text = "Primljene sve posiljke sa karte zakljucka.";
            else
                lbStatusKarte.Text = "Broj pošiljaka koje nisu pristigle:" + counter;
        }

        private void bnPosiljkeNedostaju_Click(object sender, EventArgs e)
        {
            nedostajucePosiljke = new List<PosiljkaDTO>();
            PosiljkaDAO pdao = DAOFactory.getDAOFactory().getPosiljkaDAO();
           // posiljka = pdao.vratiPosiljku(tbIdentifikatorPosiljke.Text.Trim());

            foreach (DataGridViewRow red in dgvPosiljke.Rows)
            {
                // System.Console.Write(tbIdentifikatorVrece.Text.Trim() + " "+ red.Cells[0].Value+" *");
                if (red.Cells[0].Value != null && ("NOK".Equals(red.Cells[1].Value)))
                {
                    nedostajucePosiljke.Add(pdao.vratiPosiljku(red.Cells[0].Value.ToString()));
                }
            }
            new NedostajcePosiljke(nedostajucePosiljke).ShowDialog();
        }
    }
}

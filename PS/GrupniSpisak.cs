using PS.dto;
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
using System.Drawing.Printing;
using PS.controlers;

namespace PS
{
    public partial class GrupniSpisak : Form
    {
        public GrupniSpisak()
        {
            InitializeComponent();
        }

        private void GrupniSpisak_Load(object sender, EventArgs e)
        {
            LinijaDAO ldao = DAOFactory.getDAOFactory().getLinijaDAO();
            List<LinijaDTO> list = ldao.linije();
            foreach (LinijaDTO linija in list)
            {
                cbLinije.Items.Add(linija);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbLinije.SelectedIndex != -1)
            {
                LinijaDTO linija = cbLinije.SelectedItem as LinijaDTO;
                LinijaStavkaDAO ldao = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
                KartaZakljuckaDAO kdao = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
                VrecaDAO vdao = DAOFactory.getDAOFactory().getVrecaDAO();
                int ukupanBrojVreca = 0;
                Printer p = new Printer();
                List<KartaZakljuckaDTO> karte = new List<KartaZakljuckaDTO>();
                List<LinijaStavkaDTO> lista = new List<LinijaStavkaDTO>();// = ldao.stavke(linija.LinijaId);
                DateTime trenutniDatetime = DateTime.Now;
                if (lista != null)
                {
                    foreach (LinijaStavkaDTO stavka in lista)
                    {
                        karte = kdao.kartaZakljuckaZaMjesta(linija.PoslovnicaSalje.PoslovnicaId, stavka.Poslovnica.PoslovnicaId);
                        if (karte != null)
                        {
                            foreach (KartaZakljuckaDTO karta in karte)
                            {
                                ukupanBrojVreca += vdao.brojVreca(karta.KartaID);
                            }
                            p.Text += "Ukupan broj vreca za relaciju(od:" + linija.PoslovnicaSalje.Naziv + ", do:" + stavka.Poslovnica.Naziv + ") je:" + ukupanBrojVreca + "\n";
                            ukupanBrojVreca = 0;
                        }
                    }
                }
                karte = kdao.kartaZakljuckaZaMjesta(linija.PoslovnicaSalje.PoslovnicaId, linija.PoslovnicaPrima.PoslovnicaId);
                if (karte != null)
                {
                    foreach (KartaZakljuckaDTO karta in karte)
                    {
                        ukupanBrojVreca += vdao.brojVreca(karta.KartaID);
                    }
                    //Dodati na listu za printanje
                    p.Text += "Ukupan broj vreca za relaciju(od:" + linija.PoslovnicaSalje.Naziv + ", do:" + linija.PoslovnicaPrima.Naziv + ") je:" + ukupanBrojVreca + "\n";
                }
                p.Text += "Gotov grupni spisak razmjene!";
                p.PrintToPDF();
            }
        }
    }
}
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
                List<KartaZakljuckaDTO> karte = new List<KartaZakljuckaDTO>();
                List<LinijaStavkaDTO> lista = ldao.stavke(linija.LinijaId);
                DateTime trenutniDatetime = DateTime.Now;

                int ukupanBrojVreca = 0;
                Printer p = new Printer(1); // 1 za koristenje Courier fonta
                string stringOd = "|Od";
                string stringDo = "|Do";
                string brojac = "|Broj vreća";
                string potpis = "|Potpis       |\r\n";
                string podvlacenje = "==============================================================================\r\n";

                p.Text += "                            Grupni spisak razmjene                          \r\n";
                p.Text += podvlacenje;

                string linijaInfo = "Linija: " + linija.PoslovnicaSalje + " --> " + linija.PoslovnicaPrima + " \r\n";
                p.Text += linijaInfo;//napusiStringDoBroja(linijaInfo, 78);

                linijaInfo = "Datum i vrijeme stampanja:" + DateTime.Now + " \r\n";
                p.Text += linijaInfo;//napusiStringDoBroja(linijaInfo, 78);

                p.Text += podvlacenje;
                stringOd = Printer.napusiStringDoBroja(stringOd,25);
                stringDo = Printer.napusiStringDoBroja(stringDo,25);
                brojac = Printer.napusiStringDoBroja(brojac, 13);
                p.Text += stringOd + stringDo + brojac + potpis;

                potpis = "|_____________|\r\n";
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

                            { // blok za printanje
                                stringOd = "|"+ linija.PoslovnicaSalje;
                                stringDo = "|"+ stavka.Poslovnica;
                                brojac = "|"+ ukupanBrojVreca;

                                stringOd = Printer.napusiStringDoBroja(stringOd,25);
                                stringDo = Printer.napusiStringDoBroja(stringDo,25);
                                brojac = Printer.napusiStringDoBroja(brojac, 13);

                                p.Text += stringOd + stringDo + brojac + potpis;
                            }

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

                    { // blok za printanje
                        stringOd = "|" + linija.PoslovnicaSalje;
                        stringDo = "|" + linija.PoslovnicaPrima;
                        brojac = "|" + ukupanBrojVreca;

                        stringOd = Printer.napusiStringDoBroja(stringOd,25);
                        stringDo = Printer.napusiStringDoBroja(stringDo,25);
                        brojac = Printer.napusiStringDoBroja(brojac, 13);

                        p.Text += stringOd + stringDo + brojac + potpis;
                    }

                }
                p.Text += podvlacenje;
                p.PrintToPDF();
            }
        }
    }
}
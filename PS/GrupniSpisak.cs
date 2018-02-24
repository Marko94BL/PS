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
            /*string text = "                                                                Datum: " + datum + "\r\n" +
                          "                                        " + "Karta zaključka         Otprema: " + tbOtprema.Text.Trim() + "\r\n\r\n" +
                "            Od: " + prijemnaPosta + "                                Za: " + odredisnaPosta + "\r\n" + "Prijemni broj\r\n_______________\r\n ";
            foreach (PosiljkaDTO posiljka in posiljkeIdLista)
            {
                text += posiljka.Barkod + "\r\n";
            }
            System.IO.File.WriteAllText(@".\karteZakljucaka\kz" + kartaZakljucka.KartaID + ".txt", text);*/
            //PrintDocument document = new PrintDocument();
            //document.TextToPrint = "C:/Windows/Users/Marko/Desktop/Friski todo IP.txt";
            //PrintDialog pd = new PrintDialog();
            //pd.Document = new System.Drawing.Printing.PrintDocument();
            //pd.ShowDialog();
            Printer p = new Printer();
            p.Text = "Testiranje 3!asdddddddddddddddddddddddddddssssssssssssssssseeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww\nTest new Line\ntest123";
            p.PrintToPDF();
        }
    }
}
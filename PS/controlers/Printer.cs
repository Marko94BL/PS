using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.controlers
{
    public class Printer
    {
        /**
         * 
         * Koristiti na sledeci nacin:
         *
            {
               Printer p = new Printer();
               p.Text = "String za ispis";
               p.PrintToPDF();
            }
         * 
         **/
        private PrintDocument document = new PrintDocument();
        private string text;

        public Printer()
        {
            document.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

        }
        public Printer(int dummy)
        {
            document.PrintPage += new PrintPageEventHandler(printDoc_PrintPageCourier);
        }


        public void PrintToPDF()
        {
            document.Print();
        }

        private void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            String textToPrint = Text;
            Font printFont = new Font("Times New Roman", 12);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, 10, 10);
        }

        private void printDoc_PrintPageCourier(Object sender, PrintPageEventArgs e)
        {
            String textToPrint = Text;
            Font printFont = new Font("Consolas", 12);
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, 20, 20);
        }

        public static string napusiStringDoBroja(string pocetni, int broj)  //78 sirina stranice ako se koristi consolas new 
        {
            //System.Console.WriteLine("Pocetni string:"+pocetni+" Len:"+pocetni.Length);
            if (pocetni.Length > broj)
                return pocetni.Substring(0, broj);
            while (pocetni.Length < broj)
            {
                pocetni += " ";
            }
            //System.Console.WriteLine("Finalni tring:" + pocetni + " Len:" + pocetni.Length);
            return pocetni;
        }

        public string Text { get => text; set => text = value; }
    }
}

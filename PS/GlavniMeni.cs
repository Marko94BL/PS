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
    public partial class GlavniMeni : Form
    {
        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void btnNovaPosiljka_Click(object sender, EventArgs e)
        {
            new UnosPosiljke().ShowDialog();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            new PretragaPosiljke().ShowDialog();
        }


        private void btnPrijem_Click(object sender, EventArgs e)
        {
            new Prijem().ShowDialog();
        }

        private void btnKartovanje_Click(object sender, EventArgs e)
        {
            new Kartovanje().ShowDialog();
        }
        
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrupniSpisak_Click(object sender, EventArgs e)
        {
            new GrupniSpisak().ShowDialog();
        }
    }
}

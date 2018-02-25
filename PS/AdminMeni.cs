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
    public partial class AdminMeni : Form
    {
        public AdminMeni()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminMeni_Load(object sender, EventArgs e)
        {

        }

        private void btnDodavanjeLinije_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeLinija form = new DodavanjeLinija();
            form.ShowDialog();
            this.Show();
        }

        private void btnDodavanjePoslovnice_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjePoslovnice form = new DodavanjePoslovnice();
            form.ShowDialog();
            this.Show();
        }

        private void btnDodavanjeZaposlenog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodavanjeZaposlenog form = new DodavanjeZaposlenog();
            form.ShowDialog();
            this.Show();
        }

        private void btnLinijeLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrikazLinija().ShowDialog();
            this.Show();

        }

        private void btnPregledZaposlenih_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrikazKorisnickihNaloga().ShowDialog();
            this.Show();
        }

        private void btnPregledNaloga_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PrikazKorisnickihNaloga().ShowDialog();
            this.Show();
        }
    }
}

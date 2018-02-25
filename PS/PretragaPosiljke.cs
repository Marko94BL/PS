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
    public partial class PretragaPosiljke : Form
    {
        public PretragaPosiljke()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvPosiljke.Rows.Clear();

            string identifikator = tbIdentifikator.Text.Trim();
            System.Console.WriteLine("ident: " + identifikator);

            PosiljkaStatusDAO psdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            List<PracenjePosiljkeDTO> lista = psdao.posiljkeStatusPracenjePosiljke(identifikator);

            foreach (PracenjePosiljkeDTO pracenje in lista)
            {
                System.Console.WriteLine("for each "+pracenje.Status.Naziv);
                System.Console.WriteLine("pracenje.Status.Naziv.Equals(Poslana)=" + pracenje.Status.Naziv.Equals("Poslana") + "; pracenje.Karta.Vrijeme=" + pracenje.Karta.Vrijeme + "pracenje.Karta.VrijemeStigla" + pracenje.Karta.VrijemeStigla);
                if (!checkBox1.Checked || (checkBox1.Checked && (pracenje.Status.Naziv.Equals("Poslana") ? pracenje.Karta.Vrijeme : pracenje.Karta.VrijemeStigla).AddMonths(6) > DateTime.Now))
                {
                    System.Console.WriteLine("uso u if");
                    dgvPosiljke.Rows.Add(pracenje.Karta.PoslovnicaSalje.Naziv, pracenje.Karta.PoslovnicaPrima.Naziv,
                      pracenje.Status.Naziv, (pracenje.Status.Naziv.Equals("Poslana") ? pracenje.Karta.Vrijeme : pracenje.Karta.VrijemeStigla));
                }
            }
        }

        private void PretragaPosiljke_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnPretrazi_Click(sender, e);
        }

        private void tbIdentifikator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPretrazi_Click(this, new EventArgs());
            }
        }
    }
}

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

        private void btnArhiva_Click(object sender, EventArgs e)
        {
            dgvPosiljke.Rows.Clear();
            string identifikator = tbIdentifikator.Text.Trim();
            int id = int.Parse(identifikator);
            PosiljkaStatusDAO pdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            List<PosiljkaStatusDTO> lista = pdao.posiljkeStatus();

            foreach (PosiljkaStatusDTO posiljka in lista)
            {
                if (id == posiljka.Posiljka.PosiljkaID)
                {
                    dgvPosiljke.Rows.Add(posiljka.Karta.PoslovnicaSalje.Naziv, posiljka.Karta.PoslovnicaPrima.Naziv,
                        posiljka.Status.Naziv, (posiljka.Status.Naziv.Equals("Poslana") ? posiljka.Karta.Vrijeme : posiljka.Karta.VrijemeStigla));
                }
                }
        }
    }
}

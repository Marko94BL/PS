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
            PosiljkaDAO pDAO = DAOFactory.getDAOFactory().getPosiljkaDAO();
            PosiljkaDTO posiljka = pDAO.vratiPosiljku(identifikator);

            PosiljkaStatusDAO psdao = DAOFactory.getDAOFactory().getPosiljkaStatusDAO();
            List<PosiljkaStatusDTO> lista = psdao.posiljkeStatus();

            foreach (PosiljkaStatusDTO posiljkaStatus in lista)
            {
                if (identifikator.Equals(posiljkaStatus.Posiljka.PosiljkaID))
                {
                    //dgvPosiljke.Rows.Add(posiljka.Karta.PoslovnicaSalje.Naziv, posiljka.Karta.PoslovnicaPrima.Naziv,
                      //  posiljka.Status.Naziv, (posiljka.Status.Naziv.Equals("Poslana") ? posiljka.Karta.Vrijeme : posiljka.Karta.VrijemeStigla));
                }
            }
        }
    }
}

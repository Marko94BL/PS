using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.dao;
using PS.dto;

namespace PS
{
    public partial class NedostajcePosiljke : Form
    {
        private List<PosiljkaDTO> nedostajucePosiljke;

        public NedostajcePosiljke()
        {
            InitializeComponent();
        }

        internal NedostajcePosiljke(List<PosiljkaDTO> nedostajucePosiljke1)
        {
            InitializeComponent();
            this.NedostajucePosiljke = nedostajucePosiljke1;
        }

        internal List<PosiljkaDTO> NedostajucePosiljke { get => nedostajucePosiljke; set => nedostajucePosiljke = value; }

        private void NedostajcePosiljke_Load(object sender, EventArgs e)
        {
            foreach (PosiljkaDTO posiljka in nedostajucePosiljke)
            {
                OdjavaONeispravnostiDAO odDAO = DAOFactory.getDAOFactory().getOdjavaONeispravnostiDAO();
                OdjavaONeispravnostiDTO odDTO = odDAO.OdjavaPosiljka(posiljka.PosiljkaID);
                if (odDTO != null)
                {
                    dgvNedostajuce.Rows.Add(posiljka.Barkod, odDTO.Napomena);
                }
                else {
                    dgvNedostajuce.Rows.Add(posiljka.Barkod, "Pošiljka nije pronađena");
                }
                
            }
        }
    }
}

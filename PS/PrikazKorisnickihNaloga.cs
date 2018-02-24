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
    public partial class PrikazKorisnickihNaloga : Form
    {
        public PrikazKorisnickihNaloga()
        {
            InitializeComponent();
            var editColumn = new DataGridViewButtonColumn
            {
                Text = "Blokiraj",
                UseColumnTextForButtonValue = true,
                Name = "Blokiraj",
                DataPropertyName = "Blokiraj"
            };
            gdwKorisnickiNalozi.Columns.Add(editColumn);
        }

        private void PrikazKorisnickihNaloga_Load(object sender, EventArgs e)
        {

            ucitajTabelu();
        }

        private void ucitajTabelu() {

            gdwKorisnickiNalozi.Rows.Clear();
            KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
            List<KorisnikDTO> lista = knDAO.vratiKorisnike();

            foreach (KorisnikDTO korisnik in lista)
            {
                if (!korisnik.KorisnickoIme.Equals(GlavnaForma.Prijavljeni.KorisnickoIme))
                {
                    gdwKorisnickiNalozi.Rows.Add(korisnik.KorisnickoIme);
                }
            }
        }

        private void gdwKorisnickiNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                System.Console.WriteLine("u ifu je");
                KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                KorisnikDTO kDTO = knDAO.pronadjiKorisnika(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                kDTO.Akrivan = 0;
               // System.Console.WriteLine("kornsik " + kDTO.KorisnickoIme + " " + kDTO.NalogId);
                knDAO.update(kDTO);

                ucitajTabelu();
            }
        }
    }
}

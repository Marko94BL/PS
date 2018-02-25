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

            var editColumn1 = new DataGridViewButtonColumn
            {
                Text = "Odblikiraj",
                UseColumnTextForButtonValue = true,
                Name = "Odblikiraj",
                DataPropertyName = "Odblokiraj"
            };
            dgwBlokirani.Columns.Add(editColumn1);
        }

        private void PrikazKorisnickihNaloga_Load(object sender, EventArgs e)
        {

            ucitajTabelu();
            ucitajTabelu1();
        }

        private void ucitajTabelu() {

            gdwKorisnickiNalozi.Rows.Clear();
            KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
            List<KorisnikDTO> lista = knDAO.vratiKorisnike();
            System.Console.WriteLine("Broj aktivnih "+lista.Count);
            foreach (KorisnikDTO korisnik in lista)
            {
                if (!korisnik.KorisnickoIme.Equals(GlavnaForma.Prijavljeni.KorisnickoIme))
                {
                    gdwKorisnickiNalozi.Rows.Add(korisnik.KorisnickoIme);
                }
            }
        }

        private void ucitajTabelu1()
        {

            dgwBlokirani.Rows.Clear();
            KorisnickiNalogDAO knDAO1 = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
            List<KorisnikDTO> lista1 = knDAO1.vratiKorisnikeBlokirane();
            System.Console.WriteLine("Broj blokiranih " + lista1.Count);
            foreach (KorisnikDTO korisnik in lista1)
            {
                
                    dgwBlokirani.Rows.Add(korisnik.KorisnickoIme);
                
            }
        }

        private void gdwKorisnickiNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
           // System.Console.WriteLine("index "+);
            if (e.ColumnIndex != -1) {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    // System.Console.WriteLine("u ifu je");
                    KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                    KorisnikDTO kDTO = knDAO.pronadjiKorisnika(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    kDTO.Akrivan = 0;
                    // System.Console.WriteLine("kornsik " + kDTO.KorisnickoIme + " " + kDTO.NalogId);
                    knDAO.update(kDTO);

                    ucitajTabelu();
                    ucitajTabelu1();
                }
            }
        }

        private void dgwBlokirani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid1 = (DataGridView)sender;
            if (e.ColumnIndex != -1)
            {
                if (senderGrid1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    // System.Console.WriteLine("u ifu je");
                    KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                    KorisnikDTO kDTO = knDAO.pronadjiBanovanogKorisnika(senderGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    kDTO.Akrivan = 1;
                    // System.Console.WriteLine("kornsik " + kDTO.KorisnickoIme + " " + kDTO.NalogId);
                    knDAO.update(kDTO);

                    ucitajTabelu();
                    ucitajTabelu1();
                }
            }
        }
    }
}

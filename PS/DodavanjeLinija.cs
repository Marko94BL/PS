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
    public partial class DodavanjeLinija : Form
    {
        int pocetna, krajnja;
        long rez=0;
        //int idLinije=0;

        internal DodavanjeLinija(LinijaDTO linija)
        {
            rez = linija.LinijaId;
            Console.WriteLine("rez u kontruktoru update: "+rez);
            InitializeComponent();
            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPocetnaPosta.Items.Add(poslovnica);
                cbKrajnjaPosta.Items.Add(poslovnica);
            }
            cbPocetnaPosta.Text = linija.PoslovnicaSalje.Naziv;
            cbKrajnjaPosta.Text = linija.PoslovnicaPrima.Naziv;
            mtbDolazak.Text = linija.VrijemeDolaska.ToString();
            mtbPolazak.Text = linija.VrijemePolaska.ToString();
            pocetna = linija.PoslovnicaSalje.PoslovnicaId;
            krajnja = linija.PoslovnicaPrima.PoslovnicaId;
            btnZavrsi.Text = "Završi izmjenu";

            DataGridViewButtonColumn obrisiColumn = new DataGridViewButtonColumn();
            obrisiColumn.Name = "Obriši";
            obrisiColumn.Text = "Obriši";
            int columnIndex = 2;
            if (dgvStavka.Columns["Obriši"] == null)
            {
                dgvStavka.Columns.Insert(columnIndex, obrisiColumn);
            }
            dgvStavka.Columns[0].Width = 140;
            dgvStavka.Columns[1].Width = 140;
            dgvStavka.Columns[2].Width = 56;


            LinijaStavkaDAO lsDAO = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
            List<LinijaStavkaDTO> listastavke = lsDAO.stavke(linija.LinijaId);

            foreach (LinijaStavkaDTO stavka in listastavke)
            {
                dgvStavka.Rows.Add(stavka.Poslovnica.Naziv, stavka.Vrijeme.ToString());
            }
        }

        public DodavanjeLinija()
        {
            InitializeComponent();
            //idLinije = 0;
            rez = 0;
            Console.WriteLine("rez u kontruktoru nova: " + rez);
            cbPocetnaPosta.Text = "Odaberite";
             cbKrajnjaPosta.Text = "Odaberite";
        }

        private void DodavanjeLinija_Load(object sender, EventArgs e)
        {
            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPocetnaPosta.Items.Add(poslovnica);
                cbKrajnjaPosta.Items.Add(poslovnica);
                cbStavka.Items.Add(poslovnica);
            }

            dgvStavka.Enabled = false;
            cbStavka.Enabled = false;
            mtbStavka.Enabled = false;
            btnAddStavka.Enabled = false;

        }

        private void btnAddStavka_Click(object sender, EventArgs e)
        {
            PoslovnicaDTO stavka = cbStavka.SelectedItem as PoslovnicaDTO;
            TimeSpan vrijeme ;
            try {
                 vrijeme = TimeSpan.Parse(mtbStavka.Text);
            }
            catch (Exception ec)
            {
                return;
            }
            
            LinijaStavkaDAO lsdao = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
            Console.WriteLine("rez prilikom dodavaanja stavke: " + rez);
            LinijaStavkaDTO lstavka = new LinijaStavkaDTO(int.Parse(rez.ToString()), stavka, vrijeme);
          
            int p = lsdao.insert(lstavka);
            dgvStavka.Rows.Add(lstavka.Poslovnica.Naziv, lstavka.Vrijeme.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbPocetnaPosta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvStavka.Enabled = false;
            //cbStavka.Enabled = false;
            //mtbStavka.Enabled = false;
            //btnAddStavka.Enabled = false;
        }

        private void dgvStavka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex != -1)
            {
                LinijaStavkaDAO lsDAO = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
                PoslovnicaDAO posl = DAOFactory.getDAOFactory().getPoslovnicaDAO();
                PoslovnicaDTO poslovnica = posl.vratiSaImenom(dgvStavka.Rows[e.RowIndex].Cells[0].Value.ToString());

                LinijaStavkaDTO lsDTO = new LinijaStavkaDTO();
                Console.WriteLine("rez kad kliknem na delete: " + rez);
                lsDTO.LinijaId = int.Parse(rez.ToString());//idLinije
                lsDTO.Poslovnica = poslovnica;
                lsDAO.delete(lsDTO);
                ucitajTabelu();
            }
        }
        private void ucitajTabelu()
        {

            dgvStavka.Rows.Clear();
            LinijaStavkaDAO lsDAO = DAOFactory.getDAOFactory().GetLinijaStavkaDAO();
            Console.WriteLine("rez azuriram tabelu: " + rez);
            List<LinijaStavkaDTO> listastavke = lsDAO.stavke(int.Parse(rez.ToString()));//idLinije

            foreach (LinijaStavkaDTO stavka in listastavke)
            {
                dgvStavka.Rows.Add(stavka.Poslovnica.Naziv, stavka.Vrijeme.ToString());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = 0;
            String username = GlavnaForma.Prijavljeni.KorisnickoIme;
            PoslovnicaDTO pocetnaPosta = (cbPocetnaPosta.SelectedItem as PoslovnicaDTO);
            PoslovnicaDTO krajnjaPosta = (cbKrajnjaPosta.SelectedItem as PoslovnicaDTO);

            if (!(pocetnaPosta==null|| krajnjaPosta==null || ":".Equals(mtbPolazak.Text.Trim()) || ":".Equals(mtbDolazak.Text.Trim())))
            {
                TimeSpan vrijemeP;
                TimeSpan vrijemeD;
                try
                {
                    vrijemeP = TimeSpan.Parse(mtbPolazak.Text);
                    vrijemeD = TimeSpan.Parse(mtbDolazak.Text);
                }
                catch (Exception ec) {
                    return;
                }

                btnZavrsi.Enabled = true;
                cbStavka.Enabled = true;
                mtbStavka.Enabled = true;
                btnAddStavka.Enabled = true;

                LinijaDAO lDAO = DAOFactory.getDAOFactory().getLinijaDAO();
                Console.WriteLine("rez kad dodajem liniju: " + rez);
                LinijaDTO linija1 = new LinijaDTO(int.Parse(rez.ToString()), pocetnaPosta, krajnjaPosta,vrijemeP, vrijemeD );//umjesto rez=id
                 rez = lDAO.insert(linija1, pocetna, krajnja);
                Console.WriteLine("rez kad dodajem liniju nakon inserta: " + rez);

                if (rez!=0)
                {
                    MessageBox.Show("Uspješno dodavanje nove linije", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }

                cbPocetnaPosta.Enabled = false;
                cbKrajnjaPosta.Enabled = false;
                mtbPolazak.Enabled = false;
                mtbDolazak.Enabled = false;
                btnOk.Enabled = false;

            }
        }
    }
}

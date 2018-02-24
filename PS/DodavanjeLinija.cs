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
       

        internal DodavanjeLinija(LinijaDTO linija)
        {
            cbPocetnaPosta.Text = linija.PoslovnicaSalje.Naziv;
            cbKrajnjaPosta.Text = linija.PoslovnicaPrima.Naziv;
            mtbDolazak.Text = linija.VrijemeDolaska.ToString();
            mtbPolazak.Text = linija.VrijemePolaska.ToString();
        }

        public DodavanjeLinija()
        {
            InitializeComponent();
        }

        private void DodavanjeLinija_Load(object sender, EventArgs e)
        {
            cbPocetnaPosta.Text = "Odaberite";
            cbKrajnjaPosta.Text = "Odaberite";

            PoslovnicaDAO pDAO = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            List<PoslovnicaDTO> lista = pDAO.poslovnice();

            foreach (PoslovnicaDTO poslovnica in lista)
            {
                cbPocetnaPosta.Items.Add(poslovnica);
                cbKrajnjaPosta.Items.Add(poslovnica);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = 0;
            String username = GlavnaForma.Prijavljeni.KorisnickoIme;
            PoslovnicaDTO pocetnaPosta = (cbPocetnaPosta.SelectedItem as PoslovnicaDTO);
            PoslovnicaDTO krajnjaPosta = (cbKrajnjaPosta.SelectedItem as PoslovnicaDTO);
            TimeSpan vrijemeP = TimeSpan.Parse(mtbPolazak.Text);
            TimeSpan vrijemeD = TimeSpan.Parse(mtbDolazak.Text);

            if (!(pocetnaPosta.Equals(null) || krajnjaPosta.Equals(null) || vrijemeP == null || vrijemeD == null))
            {
                LinijaDAO lDAO = DAOFactory.getDAOFactory().getLinijaDAO();
                
                LinijaDTO linija = new LinijaDTO(id, pocetnaPosta, krajnjaPosta,vrijemeP, vrijemeD );
                bool rez = lDAO.insert(linija);
                if (rez)
                {
                    MessageBox.Show("Uspješno dodavanje nove linije", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}

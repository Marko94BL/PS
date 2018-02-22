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
    public partial class GlavnaForma : Form
    {
        private static KorisnickiNalogDTO prijavljeni = null;
        internal static KorisnickiNalogDTO Prijavljeni { get => prijavljeni; set => prijavljeni = value; }

        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
             String ime = tbKorisnickoIme.Text.Trim();
             String loz = tbLozinka.Text.Trim();
             if (!(String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(loz)))
             {
                 KorisnickiNalogDAO kDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                 Prijavljeni = kDAO.pronadjiKorisnika(ime, loz);
                 if (Prijavljeni != null)
                 {
                     this.Hide();
                     GlavniMeni form = new GlavniMeni();
                     form.ShowDialog();
                     this.Show();
                 }
             }
             tbKorisnickoIme.Clear();
             tbLozinka.Clear();
        }
    }

}

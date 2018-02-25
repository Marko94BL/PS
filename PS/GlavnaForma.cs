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
        private static KorisnikDTO prijavljeni = null;
        internal static KorisnikDTO Prijavljeni { get => prijavljeni; set => prijavljeni = value; }

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
                Prijavljeni = kDAO.pronadjiKorisnika(ime);
                if (Prijavljeni != null)
                {
         
                    string saltILozinka = Prijavljeni.Salt + loz + "POSTESRPSKE"; //aplikativni salt

                    var crypt = new System.Security.Cryptography.SHA256Managed();
                    string hash = string.Empty;
                    byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(saltILozinka));
                    for (int i = 0; i <Prijavljeni.HashCount; i++)
                    {
                        crypto = crypt.ComputeHash(crypto);
                    }
                    hash = Convert.ToBase64String(crypto);
                    if (hash.Equals(Prijavljeni.HashValue))
                    {
                        if (Prijavljeni.Privilegije == 1) //admin ima privilegije 1, ostali korisnici 0
                        {
                            this.Hide();
                            AdminMeni form = new AdminMeni();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            this.Hide();
                            GlavniMeni form = new GlavniMeni();
                            form.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji korisnički nalog", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKorisnickoIme.Text = "";
                        tbLozinka.Text = "";
                    }
                }
            }
            tbKorisnickoIme.Clear();
            tbLozinka.Clear();
        }

        private void tbLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrijava_Click(this, new EventArgs());
            }
        }
    }

}

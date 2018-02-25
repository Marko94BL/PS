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
    public partial class DodavanjeZaposlenog : Form
    {
        public DodavanjeZaposlenog()
        {
            InitializeComponent();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            string korisnickoIme = tbKorisnickoIme.Text.Trim();
            string lozinka = tbLozinka.Text.Trim();
            string lozinka2 = tbLozinka2.Text.Trim();
            if (!(String.IsNullOrEmpty(korisnickoIme) || String.IsNullOrEmpty(lozinka) || String.IsNullOrEmpty(lozinka2)))
            {
                if (lozinka.Equals(lozinka2))
                {
                    KorisnickiNalogDAO knDAO = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();

                    bool postoji = knDAO.daLiPostojiKorisnik(korisnickoIme);
                    if (postoji == false)
                    {
                        KorisnikDTO knDTO = new KorisnikDTO();
                        knDTO.KorisnickoIme = korisnickoIme;
                        if (cbIsAdmin.Checked)
                        {
                            knDTO.Privilegije = 1;
                        }
                        else
                        {
                            knDTO.Privilegije = 0;
                        }
                        knDTO.Akrivan = 1;

                        Random rand = new Random();
                        knDTO.HashCount = rand.Next(10) + 1; //vrsi hesiranje max 10puta

                        knDTO.Salt = rand.Next().ToString();

                        string saltILozinka = knDTO.Salt + lozinka + "POSTESRPSKE"; //aplikativni salt

                        var crypt = new System.Security.Cryptography.SHA256Managed();
                        string hash = string.Empty;
                        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(saltILozinka));
                        for (int i = 0; i < knDTO.HashCount; i++)
                        {
                            crypto = crypt.ComputeHash(crypto);
                        }
                        hash = Convert.ToBase64String(crypto);
                        knDTO.HashValue = hash;

                        bool tmp = knDAO.insert(knDTO);
                        if (tmp == true)
                        {
                            MessageBox.Show("Uspješno ste dodali novi korisnički nalog!", "Uspješno dodavanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbKorisnickoIme.Text = "";
                            tbLozinka.Text = "";
                            tbLozinka2.Text = "";
                            cbIsAdmin.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Došlo je greške prilikom dodavanja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbKorisnickoIme.Text = "";
                            tbLozinka.Text = "";
                            tbLozinka2.Text = "";
                            cbIsAdmin.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Korisnik sa navedenim korisničkim imenom postoji. Unesite drugo korisničko ime!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKorisnickoIme.Text = "";
                        tbLozinka.Text = "";
                        tbLozinka2.Text = "";
                        cbIsAdmin.Checked = false;

                    }
                }
                else
                {
                    MessageBox.Show("Unesena i ponovljena lozinka se ne poklapaju.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //tbKorisnickoIme.Text = "";
                    tbLozinka.Text = "";
                    tbLozinka2.Text = "";
                    cbIsAdmin.Checked = false;
                }
            }
            
        }

        private void DodavanjeZaposlenog_Load(object sender, EventArgs e)
        {         
            
        }
    }
}

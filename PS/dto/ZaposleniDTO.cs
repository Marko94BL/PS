using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{ //OVA KLASA NAM NE TREBA
    class ZaposleniDTO
    {
        private string jmb;
        private string prezime;
        private string ime;
        private DateTime datumRodjenja;
        private string telefon;
        private string adresa;
        private MjestoDTO mjesto;

        public ZaposleniDTO() { }

        public ZaposleniDTO(string jmb, string prezime, string ime, DateTime datumRodjenja, string telefon, string adresa, MjestoDTO mjesto)
        {
            this.jmb = jmb;
            this.prezime = prezime;
            this.ime = ime;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
            this.adresa = adresa;
            this.mjesto = mjesto;
        }

        public string Jmb { get => jmb; set => jmb = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Ime { get => ime; set => ime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        internal MjestoDTO Mjesto { get => mjesto; set => mjesto = value; }
    }
}

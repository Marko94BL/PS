using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class KorisnickiNalogDTO
    {
        private string korisnickoIme;
        private int nalogId;
        private string salt;
        private byte akrivan;
        private ZaposleniDTO zaposleni;
        //private string jmb;
        //private string lozinka;
        private string hashValue;
        

        public KorisnickiNalogDTO() { }

        public KorisnickiNalogDTO(string korisnickoIme, byte akrivan, ZaposleniDTO zaposleni, string hash)
        {
            this.korisnickoIme = korisnickoIme;
            this.akrivan = akrivan;
            this.zaposleni = zaposleni;
            //this.Lozinka = lozinka;
            //this.jmb = jmb;
            this.hashValue = hash;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public byte Akrivan { get => akrivan; set => akrivan = value; }
        public int NalogId { get => nalogId; set => nalogId = value; }
        public string Salt { get => salt; set => salt = value; }
        public string HashValue { get => hashValue; set => hashValue = value; }
        //public string Jmb { get => jmb; set => jmb = value; }
        //public string Lozinka { get => lozinka; set => lozinka = value; }
        internal ZaposleniDTO Zaposleni { get => zaposleni; set => zaposleni = value; }
    }
}

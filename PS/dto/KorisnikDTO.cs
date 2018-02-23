using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class KorisnikDTO
    {
        private string korisnickoIme;
        private int nalogId;
        private string salt;
        private byte akrivan;
        private int hashCount;
        //private ZaposleniDTO zaposleni;
        //private string jmb;
        //private string lozinka;
        private string hashValue;
        private byte privilegije;
        

        public KorisnikDTO() { }

        public KorisnikDTO(string korisnickoIme, int nalogId, string salt, byte akrivan, int hashCount, string hashValue, byte privilegije)
        {
            this.KorisnickoIme = korisnickoIme;
            this.NalogId = nalogId;
            this.Salt = salt;
            this.Akrivan = akrivan;
            this.HashCount = hashCount;
            this.HashValue = hashValue;
            this.Privilegije = privilegije;
        }

        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public int NalogId { get => nalogId; set => nalogId = value; }
        public string Salt { get => salt; set => salt = value; }
        public byte Akrivan { get => akrivan; set => akrivan = value; }
        public int HashCount { get => hashCount; set => hashCount = value; }
        public string HashValue { get => hashValue; set => hashValue = value; }
        public byte Privilegije { get => privilegije; set => privilegije = value; }




        //public string Jmb { get => jmb; set => jmb = value; }
        //public string Lozinka { get => lozinka; set => lozinka = value; }
        //internal ZaposleniDTO Zaposleni { get => zaposleni; set => zaposleni = value; }
    }
}

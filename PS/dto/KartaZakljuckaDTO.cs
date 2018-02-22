using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class KartaZakljuckaDTO
    {
        private int kartaID;
        private string vrstaZakljucka;
        private DateTime vrijeme;
        private int redniBrojOtpreme;
        private string napomena;
        private KorisnickiNalogDTO nalog;
        private PoslovnicaDTO poslovnicaSalje;
        private PoslovnicaDTO poslovnicaPrima;
        private DateTime vrijemeStigla;

        public KartaZakljuckaDTO() { }

        public KartaZakljuckaDTO(int kartaID, string vrstaZakljucka, DateTime vrijeme, int redniBrojOtpreme, string napomena, KorisnickiNalogDTO nalog, PoslovnicaDTO poslovnicaSalje, PoslovnicaDTO poslovnicaPrima, DateTime vrijemeStigla)
        {
            this.kartaID = kartaID;
            this.vrstaZakljucka = vrstaZakljucka;
            this.vrijeme = vrijeme;
            this.redniBrojOtpreme = redniBrojOtpreme;
            this.napomena = napomena;
            this.nalog = nalog;
            this.poslovnicaSalje = poslovnicaSalje;
            this.poslovnicaPrima = poslovnicaPrima;
            this.vrijemeStigla = vrijemeStigla;
        }

        public KartaZakljuckaDTO(int kartaID, string vrstaZakljucka, DateTime vrijeme, int redniBrojOtpreme, string napomena, KorisnickiNalogDTO nalog, PoslovnicaDTO poslovnicaSalje, PoslovnicaDTO poslovnicaPrima )
        {
            this.kartaID = kartaID;
            this.vrstaZakljucka = vrstaZakljucka;
            this.vrijeme = vrijeme;
            this.redniBrojOtpreme = redniBrojOtpreme;
            this.napomena = napomena;
            this.nalog = nalog;
            this.poslovnicaSalje = poslovnicaSalje;
            this.poslovnicaPrima = poslovnicaPrima;
        }

        public int KartaID { get => kartaID; set => kartaID = value; }
        public string VrstaZakljucka { get => vrstaZakljucka; set => vrstaZakljucka = value; }
        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }
        public int RedniBrojOtpreme { get => redniBrojOtpreme; set => redniBrojOtpreme = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public DateTime VrijemeStigla { get => vrijemeStigla; set => vrijemeStigla = value; }
        internal KorisnickiNalogDTO Nalog { get => nalog; set => nalog = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaSalje = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
    }
}

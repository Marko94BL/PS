using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class OdjavaONeispravnostiDTO
    {
        private int idOdjavaONeispravnosti;
        private string napomena;
        private PosiljkaDTO posiljka;
        private KartaZakljuckaDTO kartaZakljucka;
       // private DateTime vrijeme;
        private PoslovnicaDTO poslovnica;
       // private string v;

        public OdjavaONeispravnostiDTO() { }

        public OdjavaONeispravnostiDTO(string v)
        {
            this.napomena = v;
        }

        public OdjavaONeispravnostiDTO(int idOdjavaONeispravnosti, string napomena, PosiljkaDTO posiljka, KartaZakljuckaDTO kartaZakljucka, PoslovnicaDTO poslovnica)
        {
            this.IdOdjavaONeispravnosti = idOdjavaONeispravnosti;
            this.Napomena = napomena;
            this.Posiljka = posiljka;
            this.KartaZakljucka = kartaZakljucka;
            this.Poslovnica = poslovnica;
        }

        public int IdOdjavaONeispravnosti { get => idOdjavaONeispravnosti; set => idOdjavaONeispravnosti = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        internal PosiljkaDTO Posiljka { get => posiljka; set => posiljka = value; }
        internal KartaZakljuckaDTO KartaZakljucka { get => kartaZakljucka; set => kartaZakljucka = value; }
        internal PoslovnicaDTO Poslovnica { get => poslovnica; set => poslovnica = value; }
    }
}

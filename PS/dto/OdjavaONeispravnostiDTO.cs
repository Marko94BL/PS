using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{ //OVA KLASA NAM NE TREBA
    class OdjavaONeispravnostiDTO
    {
        private string napomena;
        private PosiljkaDTO posiljka;
        private DateTime vrijeme;
        private PoslovnicaDTO poslovnica;

        public OdjavaONeispravnostiDTO() { }

        public OdjavaONeispravnostiDTO(string napomena, PosiljkaDTO posiljka, DateTime vrijeme, PoslovnicaDTO poslovnica)
        {
            this.napomena = napomena;
            this.posiljka = posiljka;
            this.vrijeme = vrijeme;
            this.poslovnica = poslovnica;
        }

        public string Napomena { get => napomena; set => napomena = value; }
        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }
        internal PosiljkaDTO Posiljka { get => posiljka; set => posiljka = value; }
        internal PoslovnicaDTO Poslovnica { get => poslovnica; set => poslovnica = value; }
    }
}

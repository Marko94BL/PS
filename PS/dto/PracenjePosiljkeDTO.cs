using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class PracenjePosiljkeDTO
    {
        private PosiljkaDTO posiljka;
        private PoslovnicaDTO poslovnicaPrima;
        private PoslovnicaDTO poslovnicaSalje;
        private StatusDTO status;
        private KartaZakljuckaDTO karta;

        public PracenjePosiljkeDTO(PosiljkaDTO posiljka, PoslovnicaDTO poslovnicaPrima, PoslovnicaDTO poslovnicaSalje, StatusDTO status, KartaZakljuckaDTO karta)
        {
            this.Posiljka = posiljka;
            this.PoslovnicaPrima = poslovnicaPrima;
            this.PoslovnicaSalje = poslovnicaSalje;
            this.Status = status;
            this.Karta = karta;
        }

        internal PosiljkaDTO Posiljka { get => posiljka; set => posiljka = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaSalje = value; }
        internal StatusDTO Status { get => status; set => status = value; }
        internal KartaZakljuckaDTO Karta { get => karta; set => karta = value; }
    }
}

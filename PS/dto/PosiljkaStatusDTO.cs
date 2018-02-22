using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class PosiljkaStatusDTO
    {
        private int posiljkaStatusId;
        private StatusDTO status;
        private PosiljkaDTO posiljka;
        private KartaZakljuckaDTO karta;

        public PosiljkaStatusDTO() { }

        public PosiljkaStatusDTO(StatusDTO status, PosiljkaDTO posiljka, KartaZakljuckaDTO karta, int psID)
        {
            this.status = status;
            this.posiljka = posiljka;
            this.karta = karta;
            this.posiljkaStatusId = psID;
        }

        public int PosiljkaStatusId { get => posiljkaStatusId; set => posiljkaStatusId = value; }
        internal StatusDTO Status { get => status; set => status = value; }
        internal PosiljkaDTO Posiljka { get => posiljka; set => posiljka = value; }
        internal KartaZakljuckaDTO Karta { get => karta; set => karta = value; }
    }
}

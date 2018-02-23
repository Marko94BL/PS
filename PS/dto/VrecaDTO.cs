using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class VrecaDTO
    {
        private KartaZakljuckaDTO kartaZakljucka;
        private int broj;
        private int vrecaId;

        public VrecaDTO(KartaZakljuckaDTO kartaId, int vrecaId, int broj)
        {
            this.kartaZakljucka = kartaId;
            this.vrecaId = vrecaId;
            this.broj = broj;

        }

        public int VrecaId { get => vrecaId; set => vrecaId = value; }
        public int Broj { get => broj; set => broj = value; }
        internal KartaZakljuckaDTO KartaZakljucka { get => kartaZakljucka; set => kartaZakljucka = value; }
    }
}

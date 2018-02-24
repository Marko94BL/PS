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
        private string broj;
        private int vrecaId;

        public VrecaDTO(KartaZakljuckaDTO kartaId, int vrecaId, string broj)
        {
            this.KartaZakljucka = kartaId;
            this.VrecaId = vrecaId;
            this.Broj = broj;

        }

        public string Broj { get => broj; set => broj = value; }
        public int VrecaId { get => vrecaId; set => vrecaId = value; }
        internal KartaZakljuckaDTO KartaZakljucka { get => kartaZakljucka; set => kartaZakljucka = value; }
    }
}

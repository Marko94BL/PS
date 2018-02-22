using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class LinijaDTO
    {
        private int linijaId;
        private PoslovnicaDTO poslovnicaSalje;
        private PoslovnicaDTO poslovnicaPrima;
        private DateTime vrijemePolaska;//da li ovde ide Time
        private DateTime vrijemeDolaska;

        public LinijaDTO() { }

        public LinijaDTO(int linijaId, PoslovnicaDTO poslovnicaS, PoslovnicaDTO poslovnicaP, DateTime vrijemeP, DateTime vrijemeD)
        {
            this.linijaId = linijaId;
            this.poslovnicaSalje = poslovnicaS;
            this.poslovnicaPrima = poslovnicaP;
            this.vrijemePolaska = vrijemeP;
            this.vrijemeDolaska = vrijemeD;
        }

        public int LinijaId { get => linijaId; set => linijaId = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaPrima = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
        public DateTime VrijemePolaska { get => vrijemePolaska; set => vrijemePolaska = value; }
        public DateTime VrijemeDolaska { get => vrijemeDolaska; set => vrijemeDolaska = value; }
    }
}

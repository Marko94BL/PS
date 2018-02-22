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
        private TimeSpan vrijemePolaska;
        private TimeSpan vrijemeDolaska;

        public LinijaDTO() { }

        public LinijaDTO(int linijaId, PoslovnicaDTO poslovnicaSalje, PoslovnicaDTO poslovnicaPrima, TimeSpan vrijemePolaska, TimeSpan vrijemeDolaska)
        {
            this.linijaId = linijaId;
            this.poslovnicaSalje = poslovnicaSalje;
            this.poslovnicaPrima = poslovnicaPrima;
            this.vrijemePolaska = vrijemePolaska;
            this.vrijemeDolaska = vrijemeDolaska;
        }

        public int LinijaId { get => linijaId; set => linijaId = value; }
        public TimeSpan VrijemePolaska { get => vrijemePolaska; set => vrijemePolaska = value; }
        public TimeSpan VrijemeDolaska { get => vrijemeDolaska; set => vrijemeDolaska = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaSalje = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
    }
}

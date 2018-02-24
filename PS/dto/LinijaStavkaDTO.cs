using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class LinijaStavkaDTO
    {
        private int linijaId;
        private PoslovnicaDTO poslovnica;
        private TimeSpan vrijeme;

        public LinijaStavkaDTO(int linija, PoslovnicaDTO poslovnica, TimeSpan vrijeme)
        {
            this.linijaId = linija;
            this.poslovnica = poslovnica;
            this.vrijeme = vrijeme;
        }

        public TimeSpan Vrijeme { get => vrijeme; set => vrijeme = value; }
        internal int LinijaId { get => linijaId; set => linijaId = value; }
        internal PoslovnicaDTO Poslovnica { get => poslovnica; set => poslovnica = value; }

        
    }
}

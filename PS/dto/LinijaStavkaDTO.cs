using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class LinijaStavkaDTO
    {
        private LinijaDTO linija;//int???
        private PoslovnicaDTO poslovnica;//int???
        private TimeSpan vrijeme;//Time

        public LinijaStavkaDTO(LinijaDTO linija, PoslovnicaDTO poslovnica, TimeSpan vrijeme)
        {
            this.linija = linija;
            this.poslovnica = poslovnica;
            this.vrijeme = vrijeme;
        }

        public TimeSpan Vrijeme { get => vrijeme; set => vrijeme = value; }
        internal LinijaDTO Linija { get => linija; set => linija = value; }
        internal PoslovnicaDTO Poslovnica { get => poslovnica; set => poslovnica = value; }
    }
}

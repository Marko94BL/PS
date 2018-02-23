using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class PosiljkaDTO
    {
        private int posiljkaID;
        private DateTime vrijeme;
        private PoslovnicaDTO poslovnicaSalje;
        private PoslovnicaDTO poslovnicaPrima;
        private byte vanVerce;
        private KorisnikDTO nalog;
        private string barkod;

        public PosiljkaDTO() { }

        public PosiljkaDTO(int posiljkaID, PoslovnicaDTO poslovnicaSalje, PoslovnicaDTO poslovnicaPrima, KorisnikDTO nalog, DateTime vrijeme, byte vanVerce, string barkod)
        {
            this.PosiljkaID = posiljkaID;
            this.Vrijeme = vrijeme;
            this.PoslovnicaSalje = poslovnicaSalje;
            this.PoslovnicaPrima = poslovnicaPrima;
            this.VanVerce = vanVerce;
            this.Nalog = nalog;

            this.Barkod = barkod;

        }

        public int PosiljkaID { get => posiljkaID; set => posiljkaID = value; }
        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }
        public byte VanVerce { get => vanVerce; set => vanVerce = value; }
        public string Barkod { get => barkod; set => barkod = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaSalje = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
        internal KorisnikDTO Nalog { get => nalog; set => nalog = value; }
    }
}

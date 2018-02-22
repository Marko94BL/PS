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
        private ZaposleniDTO zaposleni;
        private PosiljkaTipDTO oznaka;
        private string barkod;

        public PosiljkaDTO() { }

        public PosiljkaDTO(int posiljkaID, PoslovnicaDTO poslovnicaSalje, PoslovnicaDTO poslovnicaPrima, ZaposleniDTO zaposleni, PosiljkaTipDTO oznaka, DateTime vrijeme, byte vanVerce, string barkod)
        {
            this.PosiljkaID = posiljkaID;
            this.Vrijeme = vrijeme;
            this.PoslovnicaSalje = poslovnicaSalje;
            this.PoslovnicaPrima = poslovnicaPrima;
            this.VanVerce = vanVerce;
            this.Zaposleni = zaposleni;
            this.Oznaka = oznaka;
            this.barkod = barkod;

        }

        public int PosiljkaID { get => posiljkaID; set => posiljkaID = value; }
        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }
        public byte VanVerce { get => vanVerce; set => vanVerce = value; }
        public string Barkod { get => barkod; ste => barkod = value; }
        internal PoslovnicaDTO PoslovnicaSalje { get => poslovnicaSalje; set => poslovnicaSalje = value; }
        internal PoslovnicaDTO PoslovnicaPrima { get => poslovnicaPrima; set => poslovnicaPrima = value; }
        internal ZaposleniDTO Zaposleni { get => zaposleni; set => zaposleni = value; }
        internal PosiljkaTipDTO Oznaka { get => oznaka; set => oznaka = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class PosiljkaTipDTO
    {
        private string oznaka;
        private string naziv;

        public PosiljkaTipDTO() { }

        public PosiljkaTipDTO(string oznaka, string naziv)
        {
            this.oznaka = oznaka;
            this.naziv = naziv;
        }

        public string Oznaka { get => oznaka; set => oznaka = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return oznaka;
        }
    }
}

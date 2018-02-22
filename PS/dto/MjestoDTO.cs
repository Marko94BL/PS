using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class MjestoDTO
    {
        private int mjestoId;
        private string naziv;
        // private string drzava;
        private int postanskiBroj;

        public MjestoDTO() { }

        public MjestoDTO(int mjestoId, string naziv, int pb)
        {
            this.mjestoId = mjestoId;
            this.naziv = naziv;
            this.PostanskiBroj = pb;
        }

        public int MjestoId { get => mjestoId; set => mjestoId = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }

        public override string ToString()
        {
            return PostanskiBroj + " " + naziv;
        }
    }
}

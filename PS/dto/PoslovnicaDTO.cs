using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class PoslovnicaDTO
    {
        private int poslovnicaId;
        private PoslovnicaDTO postanskiCentar;
        private MjestoDTO mjesto;
        private string naziv;
        private string adresa;
       // private string telefon;

        public PoslovnicaDTO() { }

        public PoslovnicaDTO(int poslovnicaId, string naziv, MjestoDTO mjesto, string adresa, PoslovnicaDTO postanskiCentar)
        {
            this.poslovnicaId = poslovnicaId;
            this.postanskiCentar = postanskiCentar;
            this.mjesto = mjesto;
            this.naziv = naziv;
            this.adresa = adresa;
           // this.telefon = telefon;
        }

        public int PoslovnicaId { get => poslovnicaId; set => poslovnicaId = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
       // public string Telefon { get => telefon; set => telefon = value; }
        internal PoslovnicaDTO PostanskiCentar { get => postanskiCentar; set => postanskiCentar = value; }
        internal MjestoDTO Mjesto { get => mjesto; set => mjesto = value; }

        public override string ToString()
        {
            return PoslovnicaId + " " + Naziv;
        }
    }
}

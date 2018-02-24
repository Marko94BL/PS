using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dto
{
    class StatusDTO
    {
        private int statusID;
        private string naziv;
        private string opis;

        public StatusDTO() { }

        public StatusDTO(int statusID)
        {
            this.statusID = statusID;
        }

        public StatusDTO(int statusID, string naziv, string opis)
        {
            this.statusID = statusID;
            this.naziv = naziv;
            this.opis = opis;
        }

        public int StatusID { get => statusID; set => statusID = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
    }
}

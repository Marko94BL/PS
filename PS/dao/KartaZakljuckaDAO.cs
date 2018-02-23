using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface KartaZakljuckaDAO
    {


        //List<KartaZakljuckaDTO> karteZakljucka();
        KartaZakljuckaDTO vratiKartaZakljucka(int kartaId);
        bool azurirajDatum(KartaZakljuckaDTO kartaZakljucka);
        int insert(KartaZakljuckaDTO kartaZakljucka);
        // bool update(KartaZakljuckaDTO kartaZakljucka);
        // bool delete(int id);

    }
}

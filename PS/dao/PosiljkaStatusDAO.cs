using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface PosiljkaStatusDAO
    {
        List<PosiljkaStatusDTO> posiljkeStatus();
        List<PosiljkaStatusDTO> posiljkeStatus(KartaZakljuckaDTO karta);
        bool insert(PosiljkaStatusDTO posiljkaStatus);
        PosiljkaStatusDTO posiljkaStatusKartaIPosiljka(int posiljkaID, int kartaID);
        bool update(PosiljkaStatusDTO psDTO);
        PosiljkaStatusDTO posiljkaStatusKarta(int posiljkaID);
        List<PracenjePosiljkeDTO> posiljkeStatusPracenjePosiljke(string barkod);
        // bool update(PosiljkaStatusDTO posiljkaStatus);

    }
}

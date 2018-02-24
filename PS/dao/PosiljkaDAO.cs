using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface PosiljkaDAO
    {
        // List<PosiljkaDTO> posiljke();
        // List<PosiljkaDTO> posiljke(DateTime datum);
        PosiljkaDTO vratiPosiljku(string barkod);
        PosiljkaDTO vratiPosiljku(int posiljkaId);
        bool insert(PosiljkaDTO posiljka);
        // bool update(PosiljkaDTO posiljka);
        //  bool delete(String id);

    }
}

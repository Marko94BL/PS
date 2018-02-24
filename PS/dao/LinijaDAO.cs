using PS.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dao
{
    interface LinijaDAO
    {
        bool insert(LinijaDTO linija);
        List<LinijaDTO> linije();
        LinijaDTO pretragaLinijaOdDO(int idsalje, int idprima);
    }
}

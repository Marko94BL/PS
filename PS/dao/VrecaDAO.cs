using PS.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dao
{
    interface VrecaDAO
    {
        List<VrecaDTO> vrece(KartaZakljuckaDTO karta);
        bool insert(VrecaDTO vreca);
    }
}

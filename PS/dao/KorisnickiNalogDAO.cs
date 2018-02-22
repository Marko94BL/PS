using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface KorisnickiNalogDAO
    {
        KorisnickiNalogDTO pretragaPoId(int id);
    }
}

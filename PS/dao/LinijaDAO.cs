﻿using PS.dto;
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
        //LinijaDTO pretragaLinija(string salje, string prima);
    }
}

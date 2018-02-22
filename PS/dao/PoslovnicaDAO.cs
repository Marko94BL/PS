using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;

namespace PS.dao
{
    interface PoslovnicaDAO
    {
        List<PoslovnicaDTO> poslovnice();
        PoslovnicaDTO vratiPostanskiCentar(int poslovnicaId);
        PoslovnicaDTO vratiPoslovnicu(int poslovnicaId);
       /* bool insert(PoslovnicaDTO poslovnica);
        bool delete(String nazivFakulteta);
        */
    }
}

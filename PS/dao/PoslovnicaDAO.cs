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
        List<PoslovnicaDTO> postanskiCentri();
        PoslovnicaDTO vratiPostanskiCentar(int poslovnicaId);
        PoslovnicaDTO vratiPoslovnicu(int poslovnicaId);
        bool insert(PoslovnicaDTO poslovnica);
        bool delete(String nazivFakulteta);
        PoslovnicaDTO pretragaPoNazivu(string naziv);
        PoslovnicaDTO vratiSaImenom(string naziv);
    }
}

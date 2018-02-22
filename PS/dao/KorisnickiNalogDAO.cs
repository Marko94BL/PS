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
        KorisnickiNalogDTO pronadjiKorisnika(string korisnickoIme);
        bool daLiPostojiKorisnik(string korisnickoIme);
        bool insert(KorisnickiNalogDTO kn);
        KorisnickiNalogDTO pretragaPoId(int id);
    }
}

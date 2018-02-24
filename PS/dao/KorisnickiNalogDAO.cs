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
        KorisnikDTO pronadjiKorisnika(string korisnickoIme);
        bool daLiPostojiKorisnik(string korisnickoIme);
        bool insert(KorisnikDTO kn);
        KorisnikDTO pretragaPoId(int id);
        List<KorisnikDTO> vratiKorisnike();
        void update(KorisnikDTO kDTO);
    }
}

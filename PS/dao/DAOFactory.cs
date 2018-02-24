using PS.dao.mysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.dao
{
   abstract class DAOFactory
    {
        public abstract PoslovnicaDAO getPoslovnicaDAO();
        public abstract PosiljkaDAO getPosiljkaDAO();
        public abstract MjestoDAO getMjestoDAO();
        public abstract PosiljkaStatusDAO getPosiljkaStatusDAO();
        public abstract KorisnickiNalogDAO getKorisnickiNalogDAO();
        public abstract KartaZakljuckaDAO getKartaZakljuckaDAO();
        public abstract VrecaDAO getVrecaDAO();
        public abstract OdjavaONeispravnostiDAO getOdjavaONeispravnostiDAO();
        public abstract LinijaDAO getLinijaDAO();
        public abstract StatusDAO getStatusDAO();

        public static DAOFactory getDAOFactory()
        {
            return new MySQLDAOFactory();
        }
    }
}

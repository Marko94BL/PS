using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PS.dao.mysql
{
    class MySQLKorisnickiNalogDAO : KorisnickiNalogDAO
    {
        public KorisnickiNalogDTO pretragaPoId(int id)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM korisnicki_nalog WHERE korisnickoIme = @korisnickoIme AND " +
             "lozinka = @lozinka AND aktivan = 1";

            cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", lozinka);

            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                KorisnickiNalogDTO k = new KorisnickiNalogDTO(reader.GetString(0), reader.GetByte(1), null, reader.GetString(2), reader.GetString(3));
                reader.Close();
                conn.Close();
                return k;
            }

            reader.Close();
            conn.Close();
            return null;
            */
        }
    }
}

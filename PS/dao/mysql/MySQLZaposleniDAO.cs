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
    class MySQLZaposleniDAO : ZaposleniDAO
    {
        public ZaposleniDTO vratiZaposlenog(string jmb)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            ZaposleniDTO z = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM zaposleni WHERE JMB = @jmb";

            cmd.Parameters.AddWithValue("@jmb", jmb);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(6));
                z = new ZaposleniDTO(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), m);
            }
            reader.Close();
            conn.Close();
            return z;*/
        }
    }
}

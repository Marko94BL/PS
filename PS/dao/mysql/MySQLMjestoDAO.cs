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
    class MySQLMjestoDAO : MjestoDAO
    {
        public List<MjestoDTO> mjesta()
        {
            
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<MjestoDTO> lista = new List<MjestoDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM mjesto";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new MjestoDTO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
            }
            reader.Close();
            conn.Close();
            return lista;

        }

        public MjestoDTO vratiMjesto(int mjestoId)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MjestoDTO mjesto = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM mjesto WHERE IdMjesto = @mjestoId";

            cmd.Parameters.AddWithValue("@mjestoId", mjestoId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                mjesto = new MjestoDTO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }
            reader.Close();
            conn.Close();
            return mjesto;
        }
    }
}

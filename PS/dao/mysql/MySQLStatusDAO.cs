using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PS.dto;

namespace PS.dao.mysql
{
    class MySQLStatusDAO : StatusDAO
    {
        public StatusDTO vratiStatus(int id)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            // List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();
            StatusDTO status = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljkastatus WHERE IdStatus = @IdStatus";
            //cmd.Parameters.AddWithValue("@kartaId", kartaID);
            cmd.Parameters.AddWithValue("@IdStatus", id);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                status = new StatusDTO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            conn.Close();
            return status;
        }
    }
}

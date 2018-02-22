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
    class MySQLPosiljkaTipDAO : PosiljkaTipDAO
    {
        public List<PosiljkaTipDTO> posiljkaTipovi()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaTipDTO> lista = new List<PosiljkaTipDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka_tip";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PosiljkaTipDTO p = new PosiljkaTipDTO(reader.GetString(0), reader.GetString(1));
                lista.Add(p);
            }
            reader.Close();
            conn.Close();
            return lista;
        }

        public PosiljkaTipDTO vratiPosiljku(string oznaka)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PosiljkaTipDTO posiljkaTip = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka_tip WHERE Oznaka = @oznaka";
            
            cmd.Parameters.AddWithValue("@oznaka", oznaka);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                posiljkaTip = new PosiljkaTipDTO(reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            conn.Close();
            return posiljkaTip;
        }
    }
}

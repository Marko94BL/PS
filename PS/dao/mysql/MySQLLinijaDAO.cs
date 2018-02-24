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
    class MySQLLinijaDAO : LinijaDAO
    {
        public bool insert(LinijaDTO linija)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO linija VALUES(@IdLinija, @IdPoslovnicaSalje, @IdPoslovnicaPrima, @VrijemePolaska, @VrijemeDolaska)";

                cmd.Parameters.AddWithValue("@IdLinija", linija.LinijaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaSalje", linija.PoslovnicaSalje.PoslovnicaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaPrima", linija.PoslovnicaPrima.PoslovnicaId);
                cmd.Parameters.AddWithValue("@VrijemePolaska", linija.VrijemePolaska);
                cmd.Parameters.AddWithValue("@VrijemeDolaska", linija.VrijemeDolaska);
                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                e.ErrorCode.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public List<LinijaDTO> linije()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<LinijaDTO> lista = new List<LinijaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM linija";

            MySqlDataReader reader = cmd.ExecuteReader();
            PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            PoslovnicaDTO prima = null, salje = null;
            while (reader.Read())
            {
                salje = pdao.vratiPoslovnicu(reader.GetInt32(1));
                prima = pdao.vratiPoslovnicu(reader.GetInt32(2));
                lista.Add(new LinijaDTO(reader.GetInt32(0), salje, prima, reader.GetTimeSpan(3), reader.GetTimeSpan(4)));
            }
            reader.Close();
            conn.Close();
            return lista;
        }

        public LinijaDTO pretragaLinijaOdDO(int idsalje, int idprima)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<LinijaDTO> lista = new List<LinijaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM linija WHERE idPoslovnicaSalje=@idSalje AND idPoslovnicaPrima=@idPrima";

            cmd.Parameters.AddWithValue("@idSalje", idsalje);
            cmd.Parameters.AddWithValue("@idPrima", idprima);


            MySqlDataReader reader = cmd.ExecuteReader();
            PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            PoslovnicaDTO prima = null, salje = null;
            //LinijaDTO linija= 
            while (reader.Read())
            {
                salje = pdao.vratiPoslovnicu(reader.GetInt32(1));
                prima = pdao.vratiPoslovnicu(reader.GetInt32(2));
                lista.Add(new LinijaDTO(reader.GetInt32(0), salje, prima, reader.GetTimeSpan(3), reader.GetTimeSpan(4)));
            }
            reader.Close();
            conn.Close();
            return null;
        }


    }
}

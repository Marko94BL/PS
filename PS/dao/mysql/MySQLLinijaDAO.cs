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
                cmd.Parameters.AddWithValue("@IdPoslovnicaSalje", linija.PoslovnicaSalje);
                cmd.Parameters.AddWithValue("@IdPoslovnicaPrima", linija.PoslovnicaPrima);
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
    }
}

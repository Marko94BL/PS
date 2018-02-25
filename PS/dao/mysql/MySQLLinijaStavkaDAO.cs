using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PS.dto;

namespace PS.dao.mysql
{
    class MySQLLinijaStavkaDAO: LinijaStavkaDAO
    {
        public int insert(LinijaStavkaDTO linija)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO linijastavka VALUES(@IdLinija, @IdPoslovnica, @Vrijeme)";

                cmd.Parameters.AddWithValue("@IdLinija", linija.LinijaId);
                cmd.Parameters.AddWithValue("@IdPoslovnica", linija.Poslovnica.PoslovnicaId);
                cmd.Parameters.AddWithValue("@Vrijeme", linija.Vrijeme);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("greska pri insert linija stavka");
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return 1;
        }

        
    }
}

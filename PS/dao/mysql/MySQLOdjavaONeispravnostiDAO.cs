using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Reflection;

namespace PS.dao.mysql
{
    class MySQLOdjavaONeispravnostiDAO : OdjavaONeispravnostiDAO
    {
        public bool insert(OdjavaONeispravnostiDTO odjava)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO odjava_o_neispravnosti VALUES(@napomena, @posiljkaId," +
                    "@vrijeme, @poslovnica)";

                cmd.Parameters.AddWithValue("@napomena", odjava.Napomena);
                cmd.Parameters.AddWithValue("@posiljkaId", odjava.Posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@vrijeme", odjava.Vrijeme);
                cmd.Parameters.AddWithValue("@poslovnica", odjava.Poslovnica.PoslovnicaId);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {

                MessageBox.Show(this.GetType().Name + " " + MethodBase.GetCurrentMethod().Name + ": posiljka sa datim statusom vec postoji!",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
            */
        }
    }
}

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
           // throw new NotImplementedException();
          
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO objavaoneispravnosti VALUES(@IdObjavaONeispravnosti, @Napomena," +
                    "@IdPosiljka, @IdKartaZakljucka, @IdPoslovnica)";

                cmd.Parameters.AddWithValue("@IdObjavaONeispravnosti", 0);
                cmd.Parameters.AddWithValue("@Napomena", odjava.Napomena);
                cmd.Parameters.AddWithValue("@IdPosiljka", odjava.Posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@IdKartaZakljucka", odjava.KartaZakljucka.KartaID);
                cmd.Parameters.AddWithValue("@IdPoslovnica", odjava.Poslovnica.PoslovnicaId);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {

                MessageBox.Show(this.GetType().Name + " " + MethodBase.GetCurrentMethod().Name + ": došlo je do greške!",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

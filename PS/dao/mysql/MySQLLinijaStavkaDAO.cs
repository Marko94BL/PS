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
        public int insert(LinijaStavkaDTO stavka)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            
            try
            {
                conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO linijastavka VALUES(@IdLinija, @IdPoslovnica, @Vrijeme)";

                    cmd.Parameters.AddWithValue("@IdLinija", stavka.LinijaId);
                    cmd.Parameters.AddWithValue("@IdPoslovnica", stavka.Poslovnica.PoslovnicaId);
                    cmd.Parameters.AddWithValue("@Vrijeme", stavka.Vrijeme);
                    Console.Write(stavka.LinijaId+" "+stavka.Poslovnica.PoslovnicaId+" "+stavka.Vrijeme);
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

        public void delete(LinijaStavkaDTO stavka)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM linijastavka WHERE IdLinija=@IdLinija AND IdPoslovnica=@IdPoslovnica";
                
                cmd.Parameters.AddWithValue("@IdLinija", stavka.LinijaId);
                cmd.Parameters.AddWithValue("@IdPoslovnica", stavka.Poslovnica.PoslovnicaId);
                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Greska pri delete stavka", "Greska", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Console.WriteLine(e.StackTrace);

                e.ErrorCode.ToString();


            }
            finally
            {
                conn.Close();
            }
           
        }

        public List<LinijaStavkaDTO> stavke(int idLinija)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<LinijaStavkaDTO> lista = new List<LinijaStavkaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM linijastavka WHERE IdLinija=@IdLinija";
            cmd.Parameters.AddWithValue("@IdLinija", idLinija);

            MySqlDataReader reader = cmd.ExecuteReader();
            PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            while (reader.Read())
            {
                PoslovnicaDTO poslovnica = pdao.vratiPoslovnicu(reader.GetInt32(1));
                lista.Add(new LinijaStavkaDTO(reader.GetInt32(0), poslovnica, reader.GetTimeSpan(2)));
            }
            reader.Close();
            conn.Close();
            return lista;
        }
    }
}

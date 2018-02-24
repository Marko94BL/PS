using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

namespace PS.dao.mysql
{
    class MySQLPosiljkaStatusDAO : PosiljkaStatusDAO
    {
        public bool insert(PosiljkaStatusDTO posiljkaStatus)
        {


            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();
                MessageBox.Show(posiljkaStatus.Posiljka.PosiljkaID + "  " + posiljkaStatus.Karta.KartaID + "  " + posiljkaStatus.Status.StatusID);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO posiljkastatus VALUES( @idPosiljkaStatus, @IdPosiljka, @IdKartaZakljucka, @IdStatus)";

                cmd.Parameters.AddWithValue("@idPosiljkaStatus", posiljkaStatus.PosiljkaStatusId);
                cmd.Parameters.AddWithValue("@IdPosiljka", posiljkaStatus.Posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@IdKartaZakljucka", posiljkaStatus.Karta.KartaID);
                cmd.Parameters.AddWithValue("@IdStatus", posiljkaStatus.Status.StatusID);

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

        }

        public List<PosiljkaStatusDTO> posiljkeStatus()
        {


            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaStatusDTO> lista = new List<PosiljkaStatusDTO>();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM posiljkastatus";//drugi izraz tako da mi vrati Salje, Prima, Status, Vrijeme


            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //?????
            }
            reader.Close();
            conn.Close();
            return lista;

        }

        public List<PosiljkaStatusDTO> posiljkeStatus(KartaZakljuckaDTO karta)//??? sta radi ova metoda????
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljkastatus WHERE KartaZakljuckaID = @kartaId AND StatusID = 2";//status nije dobar
            cmd.Parameters.AddWithValue("@kartaId", karta.KartaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               // PosiljkaDTO posiljka = new MySQLPosiljkaDAO().vratiPosiljku(reader.GetInt32(0));
                // posiljkeS.Add(new PosiljkaStatusDTO(new StatusDTO(reader.GetInt32(2), ""), posiljka, karta));//????
            }
            reader.Close();
            conn.Close();
            return posiljkeS;

        }

        public bool update(PosiljkaStatusDTO posiljkaStatus)
        {
            throw new NotImplementedException();
        }
    }
}

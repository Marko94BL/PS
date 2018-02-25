using MySql.Data.MySqlClient;
using PS.dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS.dao.mysql
{
    class MySQLVrecaDAO : VrecaDAO
    {
        public bool insert(VrecaDTO vreca)
        {


            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            long id;
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO vreca VALUES(@IdVreca, @Broj, @IdKartaZakljucka)";

                cmd.Parameters.AddWithValue("@IdVreca", vreca.VrecaId);
                cmd.Parameters.AddWithValue("@Broj", vreca.Broj);
                cmd.Parameters.AddWithValue("@IdKartaZakljucka", vreca.KartaZakljucka.KartaID);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number == 1062 ? "Postoji vreca sa datim id."
                                    : "Greška prilikom dodavanja nove vrece.");
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;

        }

        public List<VrecaDTO> vrece(KartaZakljuckaDTO karta)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<VrecaDTO> vrece = new List<VrecaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM vreca WHERE IdKartaZakljucka = @IdKartaZakljucka";
            cmd.Parameters.AddWithValue("@IdKartaZakljucka", karta.KartaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vrece.Add(new VrecaDTO(karta, reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            conn.Close();
            return vrece;

        }

        int brojVreca(int IdKartaZakljucka)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            int retVal = 0;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM vreca WHERE IdKartaZakljucka=@karta";

            cmd.Parameters.AddWithValue("@karta", IdKartaZakljucka);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                retVal = reader.GetInt32(0);
            }
            reader.Close();
            conn.Close();
            return retVal;
        }
    }
}

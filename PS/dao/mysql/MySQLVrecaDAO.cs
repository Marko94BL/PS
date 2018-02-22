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
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            long id;
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO vreca VALUES(@kartaId, @vrecaId)";

                cmd.Parameters.AddWithValue("@kartaId", vreca.KartaId.KartaID);
                cmd.Parameters.AddWithValue("@vrecaId", vreca.VrecaId);
               
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
            */
        }

        public List<VrecaDTO> vrece(KartaZakljuckaDTO karta)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<VrecaDTO> vrece = new List<VrecaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM vreca WHERE KartaZakljuckaId = @kartaId";
            cmd.Parameters.AddWithValue("@kartaId", karta.KartaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vrece.Add(new VrecaDTO(karta, reader.GetString(1)));
            }
            reader.Close();
            conn.Close();
            return vrece;
            */
        }
    }
}

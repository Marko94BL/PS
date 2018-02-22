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
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();
             //   MessageBox.Show(posiljkaStatus.Posiljka.PosiljkaID + "  " + posiljkaStatus.Karta.KartaID + "  " + posiljkaStatus.Status.StatusID);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO posiljka_status VALUES(@posiljkaId, @kartaZakljuckaId, @statusId)";

                cmd.Parameters.AddWithValue("@posiljkaId", posiljkaStatus.Posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@kartaZakljuckaId", posiljkaStatus.Karta.KartaID);
                cmd.Parameters.AddWithValue("@statusId", posiljkaStatus.Status.StatusID);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {

                //MessageBox.Show(this.GetType().Name + " " + MethodBase.GetCurrentMethod().Name + ": posiljka sa datim statusom vec postoji!",
               //     "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
            */
        }

        public List<PosiljkaStatusDTO> posiljkeStatus()
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaStatusDTO> lista = new List<PosiljkaStatusDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            
            cmd.CommandText = "SELECT * FROM pracenje_posiljke";
            

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PoslovnicaDTO salje = new PoslovnicaDTO();
                salje.Naziv = reader.GetString(1);
                PoslovnicaDTO prima = new PoslovnicaDTO();
                prima.Naziv = reader.GetString(2);
                KartaZakljuckaDTO karta = new KartaZakljuckaDTO();
                karta.PoslovnicaSalje = salje;
                karta.PoslovnicaPrima = prima;
                try {
                    karta.Vrijeme = reader.GetDateTime(4);
                    karta.VrijemeStigla = reader.GetDateTime(5);
                } catch (Exception ) {}
                StatusDTO status = new StatusDTO();
                status.Naziv = reader.GetString(3);
                PosiljkaDTO posiljka = new PosiljkaDTO();
                posiljka.PosiljkaID = reader.GetInt32(0);
                lista.Add(new PosiljkaStatusDTO(status,posiljka,karta));
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }

        public List<PosiljkaStatusDTO> posiljkeStatus(KartaZakljuckaDTO karta)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka_status WHERE KartaZakljuckaID = @kartaId AND StatusID = 2";
            cmd.Parameters.AddWithValue("@kartaId", karta.KartaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PosiljkaDTO posiljka = new MySQLPosiljkaDAO().vratiPosiljku(reader.GetInt32(0));
                posiljkeS.Add(new PosiljkaStatusDTO(new StatusDTO(reader.GetInt32(2), ""), posiljka, karta));
            }
            reader.Close();
            conn.Close();
            return posiljkeS;
            */
        }

        public bool update(PosiljkaStatusDTO posiljkaStatus)
        {
            throw new NotImplementedException();
        }
    }
}

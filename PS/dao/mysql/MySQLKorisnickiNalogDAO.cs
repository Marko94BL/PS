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
    class MySQLKorisnickiNalogDAO : KorisnickiNalogDAO
    {
        public KorisnikDTO pronadjiKorisnika(string korisnickoIme)
        {
            //throw new NotImplementedException();
            
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM korisnik WHERE korisnickoIme = @korisnickoIme AND " +
             "aktivan = 1";

            cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
            //cmd.Parameters.AddWithValue("@hashVrijednost", hashVrijednost);

            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                KorisnikDTO k = new KorisnikDTO(reader.GetString(1),reader.GetInt32(0),reader.GetString(2),reader.GetByte(5),reader.GetInt32(3),reader.GetString(4),reader.GetByte(6));
                reader.Close();
                conn.Close();
                return k;
            }

            reader.Close();
            conn.Close();
            return null;
            
        }

        public bool daLiPostojiKorisnik(string korisnickoIme)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM korisnik WHERE korisnickoIme = @korisnickoIme AND " +
             "aktivan = 1";

            cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //KorisnickiNalogDTO k = new KorisnickiNalogDTO(reader.GetInt32(0), reader.GetString(1), reader.GetByte(5), reader.GetString(2), reader.GetString(4));
                reader.Close();
                conn.Close();
                return true;
            }

            reader.Close();
            conn.Close();
            return false;

        }       

        public bool insert(KorisnikDTO kn)
        {          
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO korisnik VALUES(@IdKorisnik, @KorisnickoIme, @HashSalt, @HashCount, @HashVrijednost, @Aktivan, @Privilegije)";

                    cmd.Parameters.AddWithValue("@IdKorisnik", 0);
                    cmd.Parameters.AddWithValue("@KorisnickoIme", kn.KorisnickoIme);
                    cmd.Parameters.AddWithValue("@HashSalt", kn.Salt);
                    cmd.Parameters.AddWithValue("@HashCount", kn.HashCount);
                    cmd.Parameters.AddWithValue("@HashVrijednost", kn.HashValue);
                    cmd.Parameters.AddWithValue("@Aktivan", kn.Akrivan);
                    cmd.Parameters.AddWithValue("@Privilegije", kn.Privilegije);
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

        public KorisnikDTO pretragaPoId(int id)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM korisnik WHERE @IdKorisnik=?";

            cmd.Parameters.AddWithValue("@IdKorisnik", id);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                KorisnikDTO k = new KorisnikDTO(reader.GetString(1), reader.GetInt32(0), reader.GetString(2), reader.GetByte(5), reader.GetInt32(3), reader.GetString(4), reader.GetByte(6));
                reader.Close();
                conn.Close();
                return k;
            }

            reader.Close();
            conn.Close();
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using PS.dao;

namespace PS.dao.mysql
{
    class MySQLPosiljkaDAO : PosiljkaDAO
    {
        public bool delete(string id)
        {
            throw new NotImplementedException();
            //return true;
        }

        public bool insert(PosiljkaDTO posiljka)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO posiljka VALUES(@IdPosiljka, @Barkod, @Vrijeme,@IdKorisnik, @IdPoslovnicaSalje, @IdPoslovnicaPrima, @VanVrece)";

                cmd.Parameters.AddWithValue("@IdPosiljka", posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@Barkod", posiljka.Barkod);
                cmd.Parameters.AddWithValue("@Vrijeme", posiljka.Vrijeme);
                cmd.Parameters.AddWithValue("@IdKorisnik", posiljka.Nalog);
                cmd.Parameters.AddWithValue("@IdPoslovnicaSalje", posiljka.PoslovnicaSalje.PoslovnicaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaPrima", posiljka.PoslovnicaPrima.PoslovnicaId);
                cmd.Parameters.AddWithValue("@VanVrece", posiljka.VanVerce);
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

        public List<PosiljkaDTO> posiljke()
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaDTO> lista = new List<PosiljkaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(vratiPosiljku(reader.GetInt32(0)));
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }

        public List<PosiljkaDTO> posiljke(DateTime datum)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaDTO> lista = new List<PosiljkaDTO>();

            MySqlCommand cmd = conn.CreateCommand();

            DateTime prijeSestMjeseci = datum.AddDays(-180);
            cmd.CommandText = "SELECT * FROM posiljka WHERE Vrijeme >= @datum";

            cmd.Parameters.AddWithValue("@datum", prijeSestMjeseci);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(vratiPosiljku(reader.GetInt32(0)));
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }

        public bool update(PosiljkaDTO posiljka)
        {
            throw new NotImplementedException();
        }

        public PosiljkaDTO vratiPosiljku(string barkod)
        {


            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PosiljkaDTO posiljka = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka WHERE Barkod = @barkod";

            cmd.Parameters.AddWithValue("@barkod", barkod);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PoslovnicaDAO pdao = new MySQLDAOFactory().getPoslovnicaDAO();
                PoslovnicaDTO pSalje = pdao.vratiPoslovnicu(reader.GetInt32(4));//vrati poslovnicu sa id koji mu je vracen kroz rezultat
                PoslovnicaDTO pPrima = pdao.vratiPoslovnicu(reader.GetInt32(5));
                KorisnickiNalogDAO knDAO = new MySQLKorisnickiNalogDAO();
                KorisnikDTO nalog = knDAO.pretragaPoId(reader.GetInt32(3));

                posiljka = new PosiljkaDTO(reader.GetInt32(0), pSalje, pPrima, nalog, reader.GetDateTime(2), reader.GetByte(6), reader.GetString(1));
            }
            reader.Close();
            conn.Close();
            return posiljka;

        }

        public PosiljkaDTO vratiPosiljku(int posiljkaId)
        {


            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PosiljkaDTO posiljka = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljka WHERE posiljkaID = @posiljkaId";

            cmd.Parameters.AddWithValue("@posiljkaId", posiljkaId);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PoslovnicaDAO pdao = new MySQLDAOFactory().getPoslovnicaDAO();
                PoslovnicaDTO pSalje = pdao.vratiPoslovnicu(reader.GetInt32(4));//vrati poslovnicu sa id koji mu je vracen kroz rezultat
                PoslovnicaDTO pPrima = pdao.vratiPoslovnicu(reader.GetInt32(5));
                KorisnickiNalogDAO knDAO = new MySQLKorisnickiNalogDAO();
                KorisnikDTO nalog = knDAO.pretragaPoId(reader.GetInt32(3));

                posiljka = new PosiljkaDTO(reader.GetInt32(0), pSalje, pPrima, nalog, reader.GetDateTime(2), reader.GetByte(6), reader.GetString(1));
            }
            reader.Close();
            conn.Close();
            return posiljka;

        }

    }
}

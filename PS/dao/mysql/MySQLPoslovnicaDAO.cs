using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PS.dto;
using System.Windows.Forms;

namespace PS.dao.mysql
{
    class MySQLPoslovnicaDAO : PoslovnicaDAO
    {
        public bool delete(string nazivFakulteta)
        {
            throw new NotImplementedException();
            //return true;
        }

        public bool insert(PoslovnicaDTO poslovnica)
        {
            throw new NotImplementedException();
            /*MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO poslovnica VALUES(@poslovnicaID, @postanskiCentar, @naziv, " +
                    "@adresa, @telefon, @mjestoId)";

                cmd.Parameters.AddWithValue("@poslovnicaID", poslovnica.PoslovnicaId);
                cmd.Parameters.AddWithValue("@postanskiCentar", poslovnica.PostanskiCentar.PoslovnicaId);
                cmd.Parameters.AddWithValue("@naziv", poslovnica.Naziv);
                cmd.Parameters.AddWithValue("@adresa", poslovnica.Adresa);
                cmd.Parameters.AddWithValue("@telefon", poslovnica.Telefon);
                cmd.Parameters.AddWithValue("@mjesto", poslovnica.Mjesto.MjestoId);

                int brojRedova = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                e.ErrorCode.ToString();
            }
            finally
            {
                conn.Close();
            }

            return true;
            */
        }

        public List<PoslovnicaDTO> poslovnice()
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PoslovnicaDTO> lista = new List<PoslovnicaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica";
           
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int tmp;
                PoslovnicaDTO pc = null;
                try
                {
                    tmp = reader.GetInt32(1);
                    pc = vratiPostanskiCentar(reader.GetInt32(1));
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(5));
                PoslovnicaDTO p = new PoslovnicaDTO(reader.GetInt32(0), pc, reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), m);
                lista.Add(p);
            }
            reader.Close();
            conn.Close();
            return lista;
            */
        }
        List<PoslovnicaDTO> postanskiCentri()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PoslovnicaDTO> lista = new List<PoslovnicaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica WHERE IDPoslovnicaPC IS NULL";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = 0;
                string naziv = String.Empty;
                int idMjesto = 0;
                string adresa = String.Empty;
                PoslovnicaDTO pCentar = null;
                try
                {
                    id = reader.GetInt32(0);
                    naziv = reader.GetString(1);
                    idMjesto = reader.GetInt32(2);
                    adresa = reader.GetString(3);
                    pCentar = null;
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                MjestoDAO mdao = DAOFactory.getDAOFactory().getMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(idMjesto);
                PoslovnicaDTO p = new PoslovnicaDTO(id, naziv, m, adresa, pCentar);
                lista.Add(p);
            }
            reader.Close();
            conn.Close();
            return lista;
        }

        public PoslovnicaDTO vratiPostanskiCentar(int poslovnicaId)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PoslovnicaDTO poslovnica = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica WHERE poslovnicaID = @poslovnicaId";

            cmd.Parameters.AddWithValue("@poslovnicaId", poslovnicaId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(5));
                poslovnica = new PoslovnicaDTO(reader.GetInt32(0), null, reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), m);
            }
            reader.Close();
            conn.Close();
            return poslovnica;
            */
        }

        public PoslovnicaDTO vratiPoslovnicu(int poslovnicaId)
        {
            throw new NotImplementedException();
            /*
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PoslovnicaDTO p = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica WHERE poslovnicaID = @poslovnicaId";

            cmd.Parameters.AddWithValue("@poslovnicaId", poslovnicaId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int tmp;
                PoslovnicaDTO pc = null;
                try
                {
                    tmp = reader.GetInt32(1);
                    pc = vratiPostanskiCentar(reader.GetInt32(1));
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(5));
                p = new PoslovnicaDTO(reader.GetInt32(0), pc, reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), m);
            }
            reader.Close();
            conn.Close();
            return p;
            */
        }
    }
}

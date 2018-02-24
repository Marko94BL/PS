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
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO poslovnica VALUES(@IdPoslovnica, @Naziv, @IdMjesto, " +
                    "@Adresa, @IdPoslovnicaPC)";

                cmd.Parameters.AddWithValue("@IdPoslovnica", 0);
                cmd.Parameters.AddWithValue("@Naziv", poslovnica.Naziv);
                cmd.Parameters.AddWithValue("@IdMjesto", poslovnica.Mjesto.MjestoId);
                cmd.Parameters.AddWithValue("@Adresa", poslovnica.Adresa);
                if (poslovnica.PostanskiCentar != null)
                {
                    cmd.Parameters.AddWithValue("@IdPoslovnicaPC", poslovnica.PostanskiCentar.PoslovnicaId);
                }
                else {
                    cmd.Parameters.AddWithValue("@IdPoslovnicaPC", null);
                }

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
            
        }

        public List<PoslovnicaDTO> poslovnice()
        {


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
                    pc = vratiPostanskiCentar(reader.GetInt32(4));
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(2));
                PoslovnicaDTO p = new PoslovnicaDTO(reader.GetInt32(0),reader.GetString(1),m,reader.GetString(3),pc);
                lista.Add(p);
            }
            reader.Close();
            conn.Close();
            return lista;

        }
        public List<PoslovnicaDTO> postanskiCentri()
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
            
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PoslovnicaDTO poslovnica = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica WHERE IdPoslovnica = @IdPoslovnica";

            cmd.Parameters.AddWithValue("@IdPoslovnica", poslovnicaId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(2));
                poslovnica = new PoslovnicaDTO(reader.GetInt32(0), reader.GetString(1), m, reader.GetString(3), null);
            }
            reader.Close();
            conn.Close();
            return poslovnica;
            
        }

        public PoslovnicaDTO vratiPoslovnicu(int poslovnicaId)
        {
            
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            PoslovnicaDTO p = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM poslovnica WHERE IdPoslovnica = @IdPoslovnica";

            cmd.Parameters.AddWithValue("@IdPoslovnica", poslovnicaId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int tmp;
                PoslovnicaDTO pc = null;
                try
                {
                    tmp = reader.GetInt32(1);
                    pc = vratiPostanskiCentar(reader.GetInt32(4));//vrati postanski centar sa idOm iz kolone 1
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                MjestoDAO mdao = new MySQLMjestoDAO();
                MjestoDTO m = mdao.vratiMjesto(reader.GetInt32(2));
                p = new PoslovnicaDTO(reader.GetInt32(0), reader.GetString(1), m, reader.GetString(3), pc);
            }
            reader.Close();
            conn.Close();
            return p;
            
        }


    }
}

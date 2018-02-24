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
                //MessageBox.Show(posiljkaStatus.Posiljka.PosiljkaID + "  " + posiljkaStatus.Karta.KartaID + "  " + posiljkaStatus.Status.StatusID);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO posiljkastatus VALUES(@idPosiljkaStatus, @IdPosiljka, @IdKartaZakljucka, @IdStatus)";

                cmd.Parameters.AddWithValue("@idPosiljkaStatus", 0);
                cmd.Parameters.AddWithValue("@IdPosiljka", posiljkaStatus.Posiljka.PosiljkaID);
                cmd.Parameters.AddWithValue("@IdKartaZakljucka", posiljkaStatus.Karta.KartaID);
                cmd.Parameters.AddWithValue("@IdStatus", posiljkaStatus.Status.StatusID);
                Console.Write(posiljkaStatus.PosiljkaStatusId + " " + posiljkaStatus.Posiljka.PosiljkaID + " " + posiljkaStatus.Karta.KartaID
                    + " " + posiljkaStatus.Status.StatusID);

                int brojRedova = cmd.ExecuteNonQuery();
                Console.Write("****");
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine("posiljkaID " + posiljkaStatus.Posiljka.PosiljkaID+" kartaID "+ posiljkaStatus.Karta.KartaID+" statusID "+ posiljkaStatus.Status.StatusID);
                MessageBox.Show(this.GetType().Name + " " + MethodBase.GetCurrentMethod().Name + ": posiljka status greska!",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;

        }

        public PosiljkaStatusDTO posiljkaStatusKarta(int posiljkaID)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            // List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();
            PosiljkaStatusDTO pt = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljkastatus WHERE IdPosiljka = @IdPosiljka and IdStatus=1";//status poslane - te trebaju za prijem!
            //cmd.Parameters.AddWithValue("@kartaId", kartaID);
            cmd.Parameters.AddWithValue("@IdPosiljka", posiljkaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PosiljkaDAO posDAO = DAOFactory.getDAOFactory().getPosiljkaDAO();
                PosiljkaDTO posiljka = posDAO.vratiPosiljku(reader.GetInt32(1));

                KartaZakljuckaDAO kzDAO = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
                KartaZakljuckaDTO karta = kzDAO.vratiKartaZakljucka(reader.GetInt32(2));

                StatusDAO sDAO = DAOFactory.getDAOFactory().getStatusDAO();
                StatusDTO sDTO = sDAO.vratiStatus(reader.GetInt32(3));

                pt = new PosiljkaStatusDTO(sDTO, posiljka, karta, reader.GetInt32(0));
            }
            else
            {
                MessageBox.Show("Pošiljka ne postoji", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reader.Close();
            conn.Close();
            return pt;
        }

        public PosiljkaStatusDTO posiljkaStatusKartaIPosiljka(int posiljkaID, int kartaID)
        {
            // throw new NotImplementedException();
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            // List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();
            PosiljkaStatusDTO pt = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM posiljkastatus WHERE IdKartaZakljucka = @kartaId AND IdPosiljka = @IdPosiljka";//status poslane - te trebaju za prijem!
            cmd.Parameters.AddWithValue("@kartaId", kartaID);
            cmd.Parameters.AddWithValue("@IdPosiljka", posiljkaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PosiljkaDAO posDAO = DAOFactory.getDAOFactory().getPosiljkaDAO();
                PosiljkaDTO posiljka = posDAO.vratiPosiljku(reader.GetInt32(1));

                KartaZakljuckaDAO kzDAO = DAOFactory.getDAOFactory().getKartaZakljuckaDAO();
                KartaZakljuckaDTO karta = kzDAO.vratiKartaZakljucka(reader.GetInt32(2));

                StatusDAO sDAO = DAOFactory.getDAOFactory().getStatusDAO();
                StatusDTO sDTO = sDAO.vratiStatus(reader.GetInt32(3));

                pt = new PosiljkaStatusDTO(sDTO, posiljka, karta, reader.GetInt32(0));
            }
            reader.Close();
            conn.Close();
            return pt;
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

        public List<PosiljkaStatusDTO> posiljkeStatus(KartaZakljuckaDTO karta)//ovu metodu dragana popravila i treba njoj ovakava
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<PosiljkaStatusDTO> posiljkeS = new List<PosiljkaStatusDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            System.Console.WriteLine("upit "+ karta.KartaID);
            cmd.CommandText = "SELECT * FROM posiljkastatus WHERE IdKartaZakljucka = @kartaId AND IdStatus = 1";//status poslane - te trebaju za prijem!
            cmd.Parameters.AddWithValue("@kartaId", karta.KartaID);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //System.Console.WriteLine("**********************************************");
                PosiljkaDTO posiljka = new MySQLPosiljkaDAO().vratiPosiljku(reader.GetInt32(1));
               // System.Console.WriteLine("********************************************** "+posiljka.Barkod);
                posiljkeS.Add(new PosiljkaStatusDTO(new StatusDTO(reader.GetInt32(3)), posiljka, karta, reader.GetInt32(0))); //????
            }
            reader.Close();
            conn.Close();
            return posiljkeS;

        }

        public bool update(PosiljkaStatusDTO posiljkaStatus)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();
                // MessageBox.Show(posiljkaStatus.Posiljka.PosiljkaID + "  " + posiljkaStatus.Karta.KartaID + "  " + posiljkaStatus.Status.StatusID);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE posiljkastatus SET  IdPosiljka=@IdPosiljka,IdKartaZakljucka=@IdKartaZakljucka,IdStatus= @IdStatus WHERE IdPosiljkaStatus= @idPosiljkaStatus";

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


        public List<PracenjePosiljkeDTO> posiljkeStatusPracenjePosiljke(string barkod)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "SELECT idPosiljka FROM posiljka WHERE BarKod = @barkod";
            cmd1.Parameters.AddWithValue("@barkod", barkod);
            List<int> listaIdenta = new List<int>();
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                listaIdenta.Add(reader1.GetInt32(0));
            }
            reader1.Close();
            List<PracenjePosiljkeDTO> lista = new List<PracenjePosiljkeDTO>();

            foreach (int idPosiljka in listaIdenta)
            {
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT * FROM pracenje_posiljke WHERE IdPosiljka = @idPosiljka";
                cmd.Parameters.AddWithValue("@idPosiljka", idPosiljka);

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
                    try
                    {
                        karta.Vrijeme = reader.GetDateTime(4);
                        karta.VrijemeStigla = reader.GetDateTime(5);
                    }
                    catch (Exception) { }
                    StatusDTO status = new StatusDTO();
                    status.Naziv = reader.GetString(3);
                    PosiljkaDTO posiljka = new PosiljkaDTO();
                    posiljka.PosiljkaID = reader.GetInt32(0);
                    lista.Add(new PracenjePosiljkeDTO(posiljka, salje, prima, status, karta));
                }
                reader.Close();
            }


            conn.Close();
            return lista;
        }
    }
}

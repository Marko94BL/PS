using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace PS.dao.mysql
{
    class MySQLKartaZakljuckaDAO : KartaZakljuckaDAO
    {
        public bool azurirajDatum(KartaZakljuckaDTO kartaZakljucka)//napisati obicni upit a ne preko procedure
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                /*cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "vrijeme_prijema_karte_zakljucka"; // Naziv procedure
                cmd.Parameters.AddWithValue("@id", kartaZakljucka.KartaID);
                cmd.Parameters["@id"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@vrijeme", kartaZakljucka.VrijemeStigla);
                cmd.Parameters["@vrijeme"].Direction = ParameterDirection.Input;*/
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number == 1062 ? "Postoji ..... sa datim brojem pošte."
                : "Greška prilikom dodavanja novog mesta.");
                return false;
            }
            finally { conn.Close(); }
            return true;
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public int insert(KartaZakljuckaDTO kartaZakljucka)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            long id;
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO kartazakljucka VALUES(@IdKartaZakljucka, @IdPoslovnicaSalje, @IdPoslovnicaPrima, @VrijemePoslana, " +
                    "@VrijemeStigla, @VrstaZakljucka,  @RedniBrojOtpreme,  @Napomena, @IdKorisnik)";

                cmd.Parameters.AddWithValue("@IdKartaZakljucka", kartaZakljucka.KartaID);
                cmd.Parameters.AddWithValue("@IdPoslovnicaSalje", kartaZakljucka.PoslovnicaSalje.PoslovnicaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaPrima", kartaZakljucka.PoslovnicaPrima.PoslovnicaId);
                cmd.Parameters.AddWithValue("@VrijemePoslana", kartaZakljucka.Vrijeme);
                cmd.Parameters.AddWithValue("@VrijemeStigla", kartaZakljucka.VrijemeStigla);
                cmd.Parameters.AddWithValue("@VrstaZakljucka", kartaZakljucka.VrstaZakljucka);
                cmd.Parameters.AddWithValue("@RedniBrojOtpreme", kartaZakljucka.RedniBrojOtpreme);
                cmd.Parameters.AddWithValue("@IdKorisnik", kartaZakljucka.Nalog.NalogId);
                cmd.Parameters.AddWithValue("@Napomena", kartaZakljucka.Napomena);


                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Number == 1062 ? "Postoji karta zakljucka."
                                    : "Greška prilikom dodavanja karte zakljucka.");
                return 0;
            }
            finally
            {
                conn.Close();
            }
            return (int)id;
        }

        public List<KartaZakljuckaDTO> karteZakljucka()
        {
            throw new NotImplementedException();
        }

        public bool update(KartaZakljuckaDTO kartaZakljucka)
        {
            throw new NotImplementedException();
        }


        public KartaZakljuckaDTO vratiKartaZakljucka(int kartaId)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            KartaZakljuckaDTO kz = null;

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM karta_zakljucka WHERE IdKartaZakljucka = @IdKartaZakljucka";

            cmd.Parameters.AddWithValue("@IdKArtaZakljucka", kartaId);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
                PoslovnicaDTO poslovnicaSalje = pdao.vratiPoslovnicu(reader.GetInt32(1));
                PoslovnicaDTO poslovnicaPrima = pdao.vratiPoslovnicu(reader.GetInt32(2));

                KorisnickiNalogDAO kndao = DAOFactory.getDAOFactory().getKorisnickiNalogDAO();
                KorisnikDTO nalog = kndao.pretragaPoId(reader.GetInt32(8));

                kz = new KartaZakljuckaDTO(reader.GetInt32(0),reader.GetString(4),reader.GetDateTime(3),reader.GetInt32(5),reader.GetString(7),nalog,poslovnicaSalje,poslovnicaPrima);
            }
            reader.Close();
            conn.Close();
            return kz;


        }
    }
}

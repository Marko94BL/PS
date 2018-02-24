﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.dto;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PS.dao.mysql
{
    class MySQLLinijaDAO : LinijaDAO
    {
        public bool insert(LinijaDTO linija)
        {

            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO linija VALUES(@IdLinija, @IdPoslovnicaSalje, @IdPoslovnicaPrima, @VrijemePolaska, @VrijemeDolaska)";

                cmd.Parameters.AddWithValue("@IdLinija", linija.LinijaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaSalje", linija.PoslovnicaSalje.PoslovnicaId);
                cmd.Parameters.AddWithValue("@IdPoslovnicaPrima", linija.PoslovnicaPrima.PoslovnicaId);
                cmd.Parameters.AddWithValue("@VrijemePolaska", linija.VrijemePolaska);
                cmd.Parameters.AddWithValue("@VrijemeDolaska", linija.VrijemeDolaska);
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

        public List<LinijaDTO> linije()
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["BP_PosteSrpske"].ConnectionString);
            conn.Open();

            List<LinijaDTO> lista = new List<LinijaDTO>();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM linija";

            MySqlDataReader reader = cmd.ExecuteReader();
            PoslovnicaDAO pdao = DAOFactory.getDAOFactory().getPoslovnicaDAO();
            PoslovnicaDTO prima = null, salje = null;
            while (reader.Read())
            {
                salje = pdao.vratiPoslovnicu(reader.GetInt32(1));
                prima = pdao.vratiPoslovnicu(reader.GetInt32(2));
                lista.Add(new LinijaDTO(reader.GetInt32(0),salje, prima, TimeSpan.Parse(reader.GetInt32(3).ToString()), TimeSpan.Parse(reader.GetInt32(4).ToString()));
            }
            reader.Close();
            conn.Close();
            return lista;
        }
    }
}

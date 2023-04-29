﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using StrongManGym.Models;
using System.Data.SqlClient;

namespace StrongManGym.Repositories
{
    public class ZaposleniRepository
    {
        public static Zaposleni GetZaposleni (int id)
        {
            string query = $"SELECT * FROM Login WHERE Id = {id}";
            return FetchZaposleni(query);
        }

        private static Zaposleni FetchZaposleni(string query)
        {
            Zaposleni zaposleni = null;
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read();
                zaposleni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposleni;
        }

        private static Zaposleni CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstname = reader["Ime"].ToString();
            string lastname = reader["Prezime"].ToString();

            string username = reader["Korisničko ime"].ToString();
            string password = reader["Lozinka"].ToString();

            var zaposleni = new Zaposleni()
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                Username = username,
                Password = password
            };
            return zaposleni;
        }
        public static Zaposleni GetZaposleni(string username)
        {
            Zaposleni zaposleni = null;
            string query = $"SELECT * FROM Login WHERE Korisničko ime = '{username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read() ;
                zaposleni = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zaposleni;
        }
    }
}

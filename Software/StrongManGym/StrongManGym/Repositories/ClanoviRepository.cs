using DBLayer;
using StrongManGym.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Repositories
{
    public class ClanoviRepository
    {
        public static Clanovi GetClanovi(int id) 
        {
            Clanovi clanovi = null;
            string query = $"SELECT * FROM Clanovi WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read();
                clanovi = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return clanovi;
        }
        public static List <Clanovi> GetClanovis()
        {
            var clanovi = new List<Clanovi>();
            string query = "SELECT * FROM Clanovi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            while (reader.Read())
            {
                Clanovi clanovi1 = CreateObject(reader);
                clanovi.Add(clanovi1);
            }
            reader.Close();
            DB.CloseConnection();
            return clanovi;
        }

        private static Clanovi CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstname = reader["Name"].ToString();
            string lastname = reader["Lastname"].ToString();
            string status = reader["Status_članarine"].ToString();

            var clanovi = new Clanovi
            {
                Id = id,
                FirstName = firstname,
                LastName = lastname,
                StatusClanarine = status,
            };
            return clanovi;
        }
     
    }
}

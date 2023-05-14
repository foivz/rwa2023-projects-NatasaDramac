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
        public static Clan GetClan(int id)
        {
            Clan clan = null;
            string query = $"SELECT Clanovi.*, Clanarine.NazivClanarine FROM Clanovi LEFT JOIN Clanarine ON Clanovi.IdClanarine = Clanarine.IdClanarine WHERE IdClana = {id}"; 
            DB.OpenConnection();
            using (var reader = DB.GetDataReader(query))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    clan = CreateObject(reader);
                    reader.Close();
                }
            }
            DB.CloseConnection();
            return clan;
        }
        public static List<Clan> GetClanovis()
        {
            var clanovi = new List<Clan>();
            string query = "SELECT Clanovi.*, Clanarine.NazivClanarine FROM Clanovi LEFT JOIN Clanarine ON Clanovi.IdClanarine = Clanarine.IdClanarine";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            while (reader.Read())
            {
                Clan clanovi1 = CreateObject(reader);
                clanovi.Add(clanovi1);
            }
            reader.Close();
            DB.CloseConnection();
            return clanovi;
        }

        private static Clan CreateObject(SqlDataReader reader)
        {
            
            if (reader != null && reader.HasRows)
            {
                int id = int.Parse(reader["IdClana"].ToString());
                string firstname = reader["FirstName"].ToString();
                string lastname = reader["Lastname"].ToString();
                int status = int.Parse(reader["IdClanarine"].ToString());
                string email = reader["E_mail"].ToString();
                string dateofbirth = reader["DateOfBirth"].ToString();
                string contact = reader["Kontakt"].ToString();
                DateTime enteredDate = DateTime.Parse(dateofbirth);
                string nazivClanarine = reader["NazivClanarine"].ToString();
                var clanovi = new Clan
                {
                    IdClana = id,
                    IdClanarine = status,
                    E_mail = email,
                    DateOfBirth = enteredDate,
                    Kontakt = contact,
                    FirstName = firstname,
                    LastName = lastname,
                    NazivClanarine=nazivClanarine,
                };
                return clanovi;
            }
            return null;
            
        }
        public static void InsertNovogClana(Clan clanovi)
        {
            string query = $"INSERT INTO Clanovi (IdClana, FirstName, LastName, E_mail, DateOfBirth, Kontakt, IdClanarine) VALUES ({clanovi.IdClana},'{clanovi.FirstName}','{clanovi.LastName}','{clanovi.E_mail}','{clanovi.DateOfBirth:yyyy-MM-dd}','{clanovi.Kontakt}','{clanovi.IdClanarine}')";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }
    }
}


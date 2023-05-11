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
        public static Clan GetClanovi(int id) 
        {
            Clan clanovi = null;
            string query = $"SELECT * FROM Clanovi WHERE IdClana = {id}";
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
        public static List <Clan> GetClanovis()
        {
            var clanovi = new List<Clan>();
            string query = "SELECT * FROM Clanovi";
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
            
            int id = int.Parse(reader["IdClana"].ToString());
            string firstname = reader["FirstName"].ToString();
            string lastname = reader["Lastname"].ToString();
            string status = reader["Status_članarine"].ToString();
            string email = reader["E_mail"].ToString() ;
            string dateofbirth = reader["DateOfBirth"].ToString() ;
            string contact = reader["Kontakt"].ToString();
            DateTime enteredDate = DateTime.Parse(dateofbirth);
            var clanovi = new Clan
            {
                IdClana = id,
                StatusClanarine = status,
                E_mail = email,
                DateOfBirth = enteredDate,
                Kontakt = contact,
                FirstName = firstname,
                LastName = lastname,
            };
            return clanovi;
        }
        public static void InsertNovogClana(Clan clanovi)
        {
            string query = $"INSERT INTO Clanovi (IdClana, FirstName, LastName, E_mail, DateOfBirth, Kontakt, Status_članarine) VALUES ({clanovi.IdClana},'{clanovi.FirstName}','{clanovi.LastName}','{clanovi.E_mail}','{clanovi.DateOfBirth:yyyy-MM-dd}','{clanovi.Kontakt}','{clanovi.StatusClanarine}')";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }
    }
}

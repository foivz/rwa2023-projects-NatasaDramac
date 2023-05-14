using DBLayer;
using StrongManGym.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Repositories
{
    public class UlazIzlazRepostiroy
    {
        public static void InsertUlaz(UlazIzlaz ulaz)
        {
            string query = $"INSERT INTO UlazIzlaz (IdClana, Ulaz) VALUES ({ulaz.IdClana},'{ulaz.Ulaz:yyyy-MM-dd HH:mm:ss}')";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        public static void InsertIzlaz(UlazIzlaz izlaz)
        {
            string query = $"INSERT INTO UlazIzlaz (IdClana, Izlaz) VALUES ({izlaz.IdClana},'{izlaz.Izlaz:yyyy-MM-dd HH:mm:ss}')";
            DB.OpenConnection();
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        public static UlazIzlaz GetUlazIzlaz(int idUlazIzlaz)
        {
            UlazIzlaz ulazIzlaz = null;
            string query = $"SELECT Ulaz,Izlaz FROM UlazIzlaz WHERE IdUlazIzlaz = {idUlazIzlaz}";
            DB.OpenConnection();
            var reader  = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read();
                ulazIzlaz = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return ulazIzlaz;
        }

        public static List<UlazIzlaz> GetUlazIzlazs(int idClana)
        {
            List<UlazIzlaz> ulaziIzlazi = new List<UlazIzlaz>();
            string query = $"SELECT * FROM UlazIzlaz WHERE IdClana = {idClana}";
            DB.OpenConnection();
            var reader  = DB.GetDataReader(query);
            while (reader.Read())
            {
                UlazIzlaz ulazIzlaz1 = CreateObject(reader);
                ulaziIzlazi.Add(ulazIzlaz1);
            }
            reader.Close();
            DB.CloseConnection();
            return ulaziIzlazi;
        }
        
        private static UlazIzlaz CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdUlazIzlaz"].ToString());
            int idClana = int.Parse(reader["IdClana"].ToString());
            
            DateTime? dateUlaz = null;
            if (!string.IsNullOrEmpty(reader["Ulaz"].ToString()))
                dateUlaz = DateTime.Parse(reader["Ulaz"].ToString());

            DateTime? dateIzlaz = null;
            if(!string.IsNullOrEmpty(reader["Izlaz"].ToString()))
                dateIzlaz = DateTime.Parse(reader["Izlaz"].ToString());

           

            var ulazIzlaz = new UlazIzlaz
            {
                IdUlazIzlaz = id,
                IdClana = idClana,
                Ulaz = dateUlaz,
                Izlaz = dateIzlaz,
            };
            return ulazIzlaz;
        }

        public static UlazIzlaz GetPosljednjiUlazIzlaz(int idClana)
        {
            UlazIzlaz ulaz = null;
            string query = $"SELECT TOP 1 * FROM UlazIzlaz WHERE IdClana = {idClana} ORDER BY IdUlazIzlaz DESC";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read();
                ulaz = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return ulaz;
        }

        public static UlazIzlaz GetPosljednjiUlaz(int idClana)
        {
            UlazIzlaz izlaz = null;
            string query = $"SELECT TOP 1 * FROM UlazIzlaz WHERE IdClana = {idClana} AND Ulaz IS NOT NULL ORDER BY Izlaz DESC";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            if (reader.HasRows)
            {
                reader.Read();
                izlaz = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();
            return izlaz;
        }

    }
}

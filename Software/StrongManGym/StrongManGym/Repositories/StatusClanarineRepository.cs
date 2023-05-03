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
    public class StatusClanarineRepository
    {
        public static StatusClanarine GetStatusClanarine(int id)
        {
            StatusClanarine statusClanarine = null;
            string query = $"SELECT * FROM Clanarine WHERE IdClanarine = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query) ;
            if (reader.HasRows)
            {
                reader.Read() ;
                statusClanarine = CreateObject(reader) ;
                reader.Close() ;
            }
            DB.CloseConnection();
            return statusClanarine ;
        }

        private static StatusClanarine CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["IdClanarine"].ToString());   
            string naziv = reader["NazivClanarine"].ToString();

            var statusClanarine = new StatusClanarine()
            {
                IdClanarine = id,
                NazivClanarine = naziv
            };
            return statusClanarine;
        }
        public static List <StatusClanarine> GetStatusClanarines() 
        {
            List <StatusClanarine> statusClana = new List<StatusClanarine>();
            string query = "SELECT * FROM Clanarine";
            DB.OpenConnection();
            var reader = DB.GetDataReader(query);
            while (reader.Read())
            {
                StatusClanarine statusClanarine = CreateObject(reader);
                statusClana.Add(statusClanarine);
            }
            reader.Close(); 
            DB.CloseConnection(); 
            return statusClana ;
        }
    }
}

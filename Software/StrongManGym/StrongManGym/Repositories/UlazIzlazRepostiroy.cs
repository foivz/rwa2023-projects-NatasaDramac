using DBLayer;
using StrongManGym.Models;
using System;
using System.Collections.Generic;
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
    }
}

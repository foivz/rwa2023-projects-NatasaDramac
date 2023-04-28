using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Teretana.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Data.SqlClient;



namespace Teretana.Repositories
{
    public class ZaposleniRepository
    {
        public static Zaposleni GetZaposleni (string username)
        {
            string connectionString = "Data Source=31.147.204.119;Initial Catalog=RWA_ndramac_DB;User ID=RWA_ndramac_User;Password=TRs8W#Qw;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT password FROM users WHERE username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedPassword = reader["password"].ToString();
                        if (storedPassword == password)
                        {
                            Console.WriteLine("Lozinka je ispravna.");
                        }
                        else
                        {
                            Console.WriteLine("Lozinka nije ispravna.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Korisničko ime nije pronađeno.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Dogodila se greška: " + ex.Message);
                }
            }


            return Fetchzaposleni(sql);
        }
    }
}
        
   


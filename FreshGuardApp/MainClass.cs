using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshGuardApp
{
    internal class MainClass
    {
        /*public static readonly string con_string = "Server=database-1.c58s00oc6nv8.eu-central-1.rds.amazonaws.com;Database=my_database;User ID=admin;Password=cbuteam2024.RM;Port=3306;";
        public static SqlConnection connection = new SqlConnection(con_string);

        static void Main(string[] args)
        {
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı başarılı!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı hatası: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Bağlantı kapatıldı.");
                }
            }
        }*/
    }
}

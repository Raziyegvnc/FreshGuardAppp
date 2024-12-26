using FreshGuardApp.Helper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FreshGuardApp
    
{
    
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DatabaseHelper Example
            //DatabaseHelper dbHelper = new DatabaseHelper();

            /* Bağlantıyı test ettik
            if (dbHelper.GetConnection())
            {
                Console.WriteLine("Veritabanı ile bağlantı kuruldu.");
            }
            else
            {
                Console.WriteLine("Veritabanı bağlantısı başarısız.");
            }
            */

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}

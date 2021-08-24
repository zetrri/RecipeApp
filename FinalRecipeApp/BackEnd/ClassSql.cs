using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalRecipeApp.BackEnd
{
    public static class ClassSql
    {

        public static MySqlConnection auth { get; set; }
        public static bool conn_status { get; set; }

        public static bool status(string username, string password, string host, string database)
        {
            MySqlConnection con = new MySqlConnection();
            string cs = "SERVER=" + host + ";DATABASE=" + database + ";Uid=" + username + ";Pwd=" + password + ";SslMode = none";
            Console.WriteLine(cs);

            //var con = new MySqlConnection(cs);
            con = new MySqlConnection(cs);
            try
            {
                con.Open();
                auth = con;
                Console.WriteLine($"MySQL version : {con.ServerVersion}");
                conn_status = true;
                return true;
            }
            catch
            {
                Console.WriteLine("Error");
                conn_status = false;
                return false;
            };


           
        }

        
    }
}


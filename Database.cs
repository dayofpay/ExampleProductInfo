using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ExampleProductInfo
{
    class Database
    {
        public static MySqlConnection connection { get; set; }
        public static string server { get; set; }
        public static string database { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string port { get; set; }
        public static string connectionString { get; set; }
        public static string sslM { get; set; }
        public static string conString { get; set; }
        public static void Connect()
        {
            server = Properties.Settings.Default.server;
            database = Properties.Settings.Default.database;
            user = Properties.Settings.Default.username;
            password = Properties.Settings.Default.password;
            port = Properties.Settings.Default.port;
            sslM = Properties.Settings.Default.ssl;
            Properties.Settings.Default.Save();
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            connection.Open();
        }
    }
}

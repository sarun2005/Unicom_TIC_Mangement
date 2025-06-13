using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Repositories
{
    internal class DataBaseConnection
    {
        private static string connectionString = "Data Source=UnicomDB.db;Version=3;";


        // Detabase Connection Method Create =================================================
        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}

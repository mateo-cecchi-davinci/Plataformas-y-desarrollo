using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controllers
{
    public static class DB_controller
    {
        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = "IOLNOTE-ITFC\\SQLEXPRESS";
            builder.InitialCatalog = "hardhouse";
            builder.IntegratedSecurity = true;
            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);
            Trace.WriteLine("Conexión a la DB: " + connectionString);
        }





    }
}

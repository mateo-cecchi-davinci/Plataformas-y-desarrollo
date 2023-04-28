using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controladores
{
    public static class DB_Controller
    {
        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = "(localdb)\\MateServer";
            builder.InitialCatalog = "ecomm";
            builder.IntegratedSecurity = true;

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);

            Trace.WriteLine("Conexion a la DB: " + connection);

        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class Clientes_Controller
    {
        public static bool agregarCliente(Cliente cliente)
        {
            string query = "INSERT INTO dbo.clientes (nombre, direccion, email, dni,  tipo) VALUES " +
               "(@nombre, " +
               "@direccion, " +
               "@email, " +
               "@dni, " +
               "@tipo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@dni", cliente.Dni);
            cmd.Parameters.AddWithValue("@tipo", cliente.Tipo);
            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
                return false;

            }
        }

        public static Cliente buscarCliente(string dni)
        {
            Cliente cliente = new Cliente();


            string query = "SELECT * FROM dbo.clientes WHERE dbo.clientes.dni =  @dni";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cliente._id = reader.GetInt32(0);
                    cliente.Nombre = reader.GetString(1);
                    cliente.Direccion = reader.GetString(2);
                    cliente.Email = reader.GetString(3);
                    cliente.Dni = reader.GetString(4);
                    cliente.Tipo = reader.GetInt32(5);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }

            return cliente;
        }
    }
}

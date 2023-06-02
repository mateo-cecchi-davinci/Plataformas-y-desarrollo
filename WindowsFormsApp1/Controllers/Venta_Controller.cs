using System;
using System.Data.SqlClient;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Controllers
{
    public static class Venta_Controller
    {

        public static bool agregarVenta(VentaDTO venta)
        {
            int numeroDeFilas;

            string query = "INSERT INTO dbo.venta (total, fecha, id_cliente, id_vendedor) VALUES " +
               "(@total, " +
               "@fecha, " +
               "@id_cliente, " +
               "@id_vendedor " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@total", venta.total);
            cmd.Parameters.AddWithValue("@fecha", venta.fecha);
            cmd.Parameters.AddWithValue("@id_cliente", venta.cliente);
            cmd.Parameters.AddWithValue("@id_vendedor", venta.vendedor);

            try
            {
                DB_controller.connection.Open();
                numeroDeFilas = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }

            return numeroDeFilas > 0 ? true : false;
        }

    }
}

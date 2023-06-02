using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1.Controllers
{
    public static class Item_Venta_Controller
    {
        public static bool agregarItemVenta(ItemVentaDTO itemVenta)
        {
            int numeroDeFilas;

            string query = "INSERT INTO dbo.item_venta (id_producto, id_venta, cantidad) VALUES " +
               "(@id_producto, " +
               "(SELECT TOP 1 id FROM dbo.venta ORDER BY fecha DESC), " +
               "@cantidad " +
               ");"; 

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id_producto", itemVenta.id_producto);
            cmd.Parameters.AddWithValue("@cantidad", itemVenta.cantidad);

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

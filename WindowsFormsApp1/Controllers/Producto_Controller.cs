using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Controllers
{
    public class Producto_Controller
    {
        public void addProducto(Producto producto)
        {
            string query = "INSERT INTO dbo.producto (nombre, descripcion, stock, precio, imagen, categoria, activo) VALUES " +
               "(@nombre, " +
               "@descripcion, " +
               "@stock, " +
               "@precio, " +
               "@imagen, " +
               "@categoria," +
               "@activo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@imagen", producto.Imagen);
            cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@activo", producto.Activo);


            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_controller.connection.Close();

            
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);

            }

        }
    }
}

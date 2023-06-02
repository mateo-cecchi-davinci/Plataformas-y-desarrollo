using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Controllers
{
    public static class Producto_Controller 
    {
        public static bool addProducto(Producto producto)
        {
            string query = "INSERT INTO dbo.producto (nombre, descripcion, stock, precio, categoria, activo, image) VALUES " +
               "(@nombre, " +
               "@descripcion, " +
               "@stock, " +
               "@precio, " +
               "@categoria," +
               "@activo, " +
               "@imagen" +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@activo", producto.Activo);
            cmd.Parameters.AddWithValue("@imagen", producto.Image);
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
        //public static int obtenerTotalDeVentas()
        //{
        //    int total = 0;
        //    try
        //    {
        //        DB_controller.connection.Open();

        //        string query = "SELECT COUNT(*) FROM dbo.venta;";
        //        SqlCommand cmd = new SqlCommand();



        //        cmd.CommandText = query;
        //        cmd.Connection = DB_controller.connection;
        //    }
        //}


        public static bool actualizarStock (int nuevoStock, long id)
        {
            int numeroDeFilas;

            string query = @"UPDATE dbo.producto 
                                SET stock = @nuevoStock 
                                WHERE id = @idProducto;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@idProducto", id);
            cmd.Parameters.AddWithValue("@nuevoStock", nuevoStock);

            try
            {
                DB_controller.connection.Open();
                numeroDeFilas = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }

            return numeroDeFilas > 0 ? true : false;
        }

        public static List<Producto> obtenerTodos(string text = null )
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                DB_controller.connection.Open();

                string query = "select * from dbo.producto";
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(text))
                {
                    query += " WHERE nombre LIKE @text";

                    cmd.Parameters.Add(new SqlParameter("@text", $"%{text}%"));

                }

                cmd.CommandText = query;
                cmd.Connection = DB_controller.connection;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Id = reader.GetInt64(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Descripcion = reader.GetString(2);
                    prod.Stock = reader.GetInt32(3);
                    prod.Precio = reader.GetDecimal(4);
                    prod.Categoria = reader.GetInt32(5);
                    prod.Activo = reader.GetBoolean(6);
                    byte[] imagenBytes = (byte[])reader["image"]; // Lee la imagen como bytes
                    prod.Image = imagenBytes;
                    lista.Add(prod);

                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return lista;
        }
        public static Producto findById(long id)
        {
            Producto prod = new Producto();


            string query = "select * from dbo.producto where dbo.producto.id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prod.Id = reader.GetInt64(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Descripcion = reader.GetString(2);
                    prod.Stock = reader.GetInt32(3);
                    prod.Precio = reader.GetDecimal(4);
                    prod.Categoria = reader.GetInt32(5);
                    prod.Activo = reader.GetBoolean(6);

                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return prod;
        }

        public static bool cambiarEstado(long id, bool activo)
        {
            string query = "update dbo.producto set activo = @activo where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            
            cmd.Parameters.AddWithValue("@activo", activo ? false : true);

            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public static List<Producto> obtenerTodosPorCategoria(string categoria)
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                //SELECT*
                //FROM producto
                //INNER JOIN categoria ON producto.categoria = categoria.id
                //WHERE categoria.nombre = 'Refrigeracion Liquida';

                DB_controller.connection.Open();

                string query = @"SELECT * 
                                 FROM dbo.producto 
                                 INNER JOIN dbo.categoria 
                                 ON dbo.producto.categoria = dbo.categoria.id
                                 WHERE dbo.categoria.nombre LIKE @categoria";

                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@categoria", $"%{categoria}%"));

                cmd.CommandText = query;
                cmd.Connection = DB_controller.connection;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Id = reader.GetInt64(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Descripcion = reader.GetString(2);
                    prod.Stock = reader.GetInt32(3);
                    prod.Precio = reader.GetDecimal(4);
                    prod.Categoria = reader.GetInt32(5);
                    prod.Activo = reader.GetBoolean(6);
                    byte[] imagenBytes = (byte[])reader["image"]; // Lee la imagen como bytes
                    prod.Image = imagenBytes;
                    lista.Add(prod);

                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return lista;
        }

        public static bool actualizarStock(long id, int nuevoStock)
        {
            string query = @"UPDATE dbo.producto SET stock = @nuevoStock
                                WHERE id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nuevoStock", nuevoStock);
            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public static int obtenerTotalDeVentas()
        {
            int total = 0;
            try
            {
                DB_controller.connection.Open();

                string query = "SELECT COUNT(*) FROM dbo.venta;";
                SqlCommand cmd = new SqlCommand();



                cmd.CommandText = query;
                cmd.Connection = DB_controller.connection;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    total = reader.GetInt32(0);
                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return total;
        }

        public static bool actualizarProducto(long id, Producto producto)
        {
            string query = "update dbo.producto set nombre = @nombre, descripcion = @descripcion, stock = @stock, precio = @precio, categoria = @categoria where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@stock", producto.Stock);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);
            cmd.Parameters.AddWithValue("@categoria", producto.Categoria);

            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);

            }
        }
    }


    }


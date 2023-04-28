using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2.Controladores
{
    public class Producto_Controlador
    {
        static string ruta = "../../Resources/productos.txt";

        public static bool crearProducto(Producto prod)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.producto values" +
               "(@id, " +
               "@nombre, " +
               "@descripcion, " +
               "@activo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
            cmd.Parameters.AddWithValue("@activo", prod.Activo);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }


            //Darlo de alta en un txt
            try
            {
                string linea = prod.Id + ";" + prod.Nombre + ";" + prod.Descripcion + ";" + prod.Activo ;
                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(linea);
                archivo.Close();

                return true;
            }
            catch(Exception ex)
            {
                Trace.WriteLine("Ocurrio un error al intenta escribir el producto: " + ex.Message);
                return false;
            }
        }

        public static bool cambiarEstado(int id, int estado)
        {
            string query = "update dbo.producto set activo = @estado where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@estado", estado);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }

        public static bool editarProducto(Producto newProd)
        {
            //Actualizarlo en la BBDD
            string query = "update dbo.producto set nombre = @nombre, descripcion = @descripcion where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", newProd.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", newProd.Descripcion);
            cmd.Parameters.AddWithValue("@id", newProd.Id);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex )
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            
        }

        public static Producto obtenerProducto(int id)
        {
            Producto prod = new Producto();
            string query = "select * from dbo.producto where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Trace.WriteLine("Prod encontrado, nombre: " + reader.GetString(1));
                    prod = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
                    
                }

                reader.Close();
                DB_Controller.connection.Close();
                return prod;

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static List<Producto> obtenerTodos()
        {
            List<Producto> list = new List<Producto>();
            string query = "select * from dbo.producto;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3)));
                    Trace.WriteLine("Prod encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch(Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }


    }
}

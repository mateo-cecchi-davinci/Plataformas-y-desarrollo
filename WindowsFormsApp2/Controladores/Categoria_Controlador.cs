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
    public class Categoria_Controlador
    {

        public static bool crearCategoria(Categoria cat)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.categoria values" +
               "(@id, " +
               "@nombre, " +
               "@padre, " +
               "@activo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            cmd.Parameters.AddWithValue("@padre", cat.padre.Id);
            cmd.Parameters.AddWithValue("@activo", cat.Activo);

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

        public static bool cambiarEstado(int id, int estado)
        {
            string query = "update dbo.categoria set activo = @estado where id = @id;";

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

        public static bool editarCategoria(Categoria newCat)
        {
            //Actualizarlo en la BBDD
            string query = "update dbo.categoria set nombre = @nombre where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", newCat.Nombre);
            cmd.Parameters.AddWithValue("@id", newCat.padre.Id);

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

        public static Categoria obtenerCategoria(int id)
        {
            
            string query = "select * from dbo.categoria where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Categoria cat = new Categoria();
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //Para que esto funque hay q hacer una tabla en el Microsoft Server Managment Studio (1:26:00 Clase del 21/04)
                    cat.Id = reader.GetInt32(0);
                    cat.Nombre = reader.GetString(1);

                    if(reader.GetInt32(2) != -1)
                    {
                        // TIENE UN PADRE, LO BUSCAMOS
                        cat.padre = obtenerCategoria(reader.GetInt32(2));
                    }

                    cat.Activo = reader.GetBoolean(3);
                    Trace.WriteLine("Categoria encontrada, nombre: " + reader.GetString(1));

                }

                reader.Close();
                DB_Controller.connection.Close();
                return cat;

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static List<Categoria> obtenerTodos()
        {
            List<Categoria> list = new List<Categoria>();
            string query = "select * from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Categoria cat = new Categoria();
                    cat.Id = reader.GetInt32(0);
                    cat.Nombre = reader.GetString(1);

                    if (reader.GetInt32(2) != -1)
                    {
                        // TIENE UN PADRE, LO BUSCAMOS
                        cat.padre = obtenerCategoria(reader.GetInt32(2));
                    }

                    cat.Activo = reader.GetBoolean(3);

                    list.Add(cat);
                    Trace.WriteLine("Cat encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Controllers
{
    public static class Categoria_Controller
    {
        /*
        public bool crearUsuario(Usuario usuario)
        {
            //Darlo de alta en la BBDD
            string query = "INSERT INTO dbo.usuario (nombre, apellido, dni, nombre_usuario, contraseña, admin, activo) VALUES " +
               "(@nombre, " +
               "@apellido, " +
               "@dni, " +
               "@nombre_usuario, " +
               "@contraseña, " +
               "@admin " +
               "@activo, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", usuario.Name);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@dni", usuario.Dni);
            cmd.Parameters.AddWithValue("@nombre_usuario", usuario.UserName);
            cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@admin", true);
            cmd.Parameters.AddWithValue("@activo", true);

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
            return false;
        }
        */

        /* public Usuario findByUserName(string username)
         {
             string query = "select * from dbo.usuario where dbo.usuario.nombre_usuario = @userName;";
             Usuario usuario = null;

             SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
             cmd.Parameters.AddWithValue("@userName", username);
             try
             {
                 DB_controller.connection.Open();
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     usuario = new Usuario(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)
                         , reader.GetString(4), reader.GetString(5), reader.GetBoolean(6), reader.GetBoolean(7), reader.GetString(8));

                 }
                 reader.Close();
                 DB_controller.connection.Close();
             }
             catch (Exception ex)
             {
                 throw new Exception("Hay un error en la query: " + ex.Message);
             }

             return usuario;
         }
         */

        public static Categoria findById(long id)
        {
            string query = "select * from dbo.categoria where dbo.categoria.id = @id;";
            Categoria cat = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Categoria();
                    cat.Id = reader.GetInt64(0);
                    cat.Nombre = reader.GetString(1);
                    cat.Padre = reader.GetInt64(2);
                    cat.Activo = reader.GetBoolean(3);
                }
                reader.Close();
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cat;
        }
        public static Categoria findByName(String nombre)
        {
            string query = "select * from dbo.categoria where dbo.categoria.nombre = @nombre;";
            Categoria cat = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cat = new Categoria();
                    cat.Id = reader.GetInt64(0);
                    cat.Nombre = reader.GetString(1);
                    cat.Padre = reader.GetInt64(2);
                    cat.Activo = reader.GetBoolean(3);
                }
                reader.Close();
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cat;
        }
        public static List<Categoria> obtenerTodas()
        {
            List<Categoria> list = new List<Categoria>();
            List<Categoria> listOrdenada = new List<Categoria>();
            List<Categoria> response = new List<Categoria>();

            string query = "select * from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = reader.GetInt64(0);
                    categoria.Nombre = reader.GetString(1);
                    categoria.Padre = reader.GetInt64(2);
                    categoria.Activo = reader.GetBoolean(3);
                    if (categoria.Padre == -1)
                    {
                        listOrdenada.Add(categoria);
                    }
                    else
                    {
                        list.Add(categoria);
                    }
                }
                reader.Close();
                DB_controller.connection.Close();

                foreach (Categoria cat in listOrdenada)
                {
                    Categoria toResponse = new Categoria();
                    toResponse.Id = cat.Id;
                    toResponse.Nombre = cat.Nombre;
                    toResponse.Padre = cat.Padre;
                    toResponse.Activo = cat.Activo;
                    toResponse.subcategorias = ordenarCategorias(list, cat);
                    response.Add(toResponse);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            return response;
        }
        private static List<Categoria> ordenarCategorias(List<Categoria> list, Categoria catPadre)
        {
            List<Categoria> subcategorias = new List<Categoria>();
            foreach (Categoria cat in list) {
                if (catPadre.Id == cat.Padre)
                {
                    subcategorias.Add(cat);
                    if (list.Where(x => x.Padre == cat.Id).Count() > 0)
                    {
                        cat.subcategorias = ordenarCategorias(list, cat);
                    }
                }
            }
            return subcategorias;
        }

        public static bool addCategoria(Categoria cat)
        {
            string query = "INSERT INTO dbo.categoria (nombre, padre, activo) VALUES " +
               "(@nombre, " +
               "@padre, " +
               "@activo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            cmd.Parameters.AddWithValue("@padre", cat.Padre);
            cmd.Parameters.AddWithValue("@activo", cat.Activo);
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




        public static bool cambiarEstado(long id, bool activo)
        {
            string query = "update dbo.categoria set activo = @activo where id = @id;";

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
        public static bool actualizarCategoria(long id, Categoria categoria)
        {
            string query = "update dbo.categoria  set nombre = @nombre, padre = @padre, activo = @activo where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);

            cmd.Parameters.AddWithValue("@id", id); 
            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
            cmd.Parameters.AddWithValue("@padre", categoria.Padre);
            cmd.Parameters.AddWithValue("@activo", categoria.Activo);

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




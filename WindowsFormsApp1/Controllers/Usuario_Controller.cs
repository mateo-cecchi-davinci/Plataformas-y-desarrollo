using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Controllers
{
    public static class Usuario_Controller
    {

        public static bool crearUsuario(Usuario usuario)
        {
            //Darlo de alta en la BBDD
            string query = "INSERT INTO dbo.usuario (nombre, apellido, dni, nombre_usuario, contraseña, admin, activo, image) VALUES " +
               "(@nombre, " +
               "@apellido, " +
               "@dni, " +
               "@nombre_usuario, " +
               "@contraseña, " +
               "@admin, " +
               "@activo, " +
               "@image " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", usuario.Name );
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@dni", usuario.Dni);
            cmd.Parameters.AddWithValue("@nombre_usuario", usuario.UserName);
            cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@admin", true);
            cmd.Parameters.AddWithValue("@activo", true);
            cmd.Parameters.AddWithValue("@image", usuario.Imagen);

            try
            {
                DB_controller.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }
            return true;
        }

        public static byte[] getImagenDePerfilUsuario(long id)
        {
            byte[] imagen = null;

            string query = @"select dbo.usuario.image
                                from dbo.usuario 
                                    where dbo.usuario.id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    imagen = (byte[])reader["image"]; // Lee la imagen como bytes
                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return imagen;
        }

        public static bool validarDNI (string dni)
        {
            string dniRegistrado = string.Empty;

            string query = @"select dbo.usuario.dni
                                from dbo.usuario 
                                    where dbo.usuario.dni = @dni";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dniRegistrado = reader.GetString(0);
                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return string.IsNullOrEmpty(dniRegistrado) ? true : false;
        }

        public static bool validoNombreCompleto(string nombre, string apellido)
        {
            string nombreCompleto = string.Empty;

            string query = @"select dbo.usuario.nombre, dbo.usuario.apellido 
                                from dbo.usuario 
                                    where dbo.usuario.nombre = @nombre AND dbo.usuario.apellido = @apellido";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nombreCompleto = reader.GetString(0);
                    nombreCompleto += " " + reader.GetString(1);
                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return string.IsNullOrEmpty(nombreCompleto) ? true : false;
        }

        public static Usuario findById(long id)
        {
            Usuario usuario = new Usuario();


            string query = "select * from dbo.usuario where dbo.usuario.id = @id";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario._id = reader.GetInt64(0);
                    usuario.Name = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.Dni = reader.GetString(3);
                    usuario.UserName = reader.GetString(4);
                    usuario.Contraseña = reader.GetString(5);
                    usuario.Admin = reader.GetBoolean(6);
                    usuario.Activo = reader.GetBoolean(7);
                    byte[] imagenBytes = (byte[])reader["image"]; // Lee la imagen como bytes
                    usuario.Imagen = imagenBytes;

                }
                reader.Close();
                DB_controller.connection.Close();

            }
            catch (Exception ex)
            {
                DB_controller.connection.Close();
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usuario;
        }

        public static Usuario findByUserName(string username)
        {
            Usuario usuario = new Usuario();
            string query = "select * from dbo.usuario where dbo.usuario.nombre_usuario = @userName;";
            

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@userName", username );
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario._id = reader.GetInt64(0);
                    usuario.Name = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.Dni = reader.GetString(3);
                    usuario.UserName = reader.GetString(4);
                    usuario.Contraseña = reader.GetString(5);
                    usuario.Admin = reader.GetBoolean(6);
                    usuario.Activo = reader.GetBoolean(7);
                    byte[] imagenBytes = (byte[])reader["image"]; // Lee la imagen como bytes
                    usuario.Imagen = imagenBytes;

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
        public static bool actualizarUsuario(long id, Usuario usuario)
        {
            //Darlo de alta en la BBDD
            string query = @"UPDATE dbo.usuario 
                            SET nombre=@nombre,
                                apellido=@apellido,
                                dni=@dni,
                                nombre_usuario=@nombre_usuario,
                                contraseña=@contraseña,
                                admin=@admin, 
                                activo=@activo
                                    WHERE id=@id;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
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
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }
            return true;
        }
    
        public static List<Usuario> usuarios(string text = null)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                DB_controller.connection.Open();

                string query = "SELECT * FROM dbo.usuario";
                SqlCommand cmd = new SqlCommand();

                if(!string.IsNullOrEmpty(text))
                {
                    query += @" WHERE nombre LIKE @text 
                                OR apellido LIKE @text 
                                OR dni LIKE @text";

                    cmd.Parameters.Add(new SqlParameter("@text", $"%{text}%"));
                }

                cmd.CommandText = query;
                cmd.Connection = DB_controller.connection;
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario._id = reader.GetInt64(0);
                    usuario.Name = reader.GetString(1);
                    usuario.Apellido = reader.GetString(2);
                    usuario.Dni = reader.GetString(3);
                    usuario.UserName = reader.GetString(4);
                    usuario.Contraseña = reader.GetString(5);
                    usuario.Admin = reader.GetBoolean(6);
                    usuario.Activo = reader.GetBoolean(7);
                    usuarios.Add(usuario);
                }
                reader.Close(); 
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usuarios;
        }

        public static  bool cambiarContraseña(int dni, string contraseña)
        {

            string query = "UPDATE dbo.usuario SET dbo.usuario.contraseña=@contraseña WHERE dbo.usuario.dni = @dni;";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

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
            return false;
        }

        public static bool cambiarEstadoUsuario(long id, bool activo )
        {

            string query = "UPDATE dbo.usuario SET dbo.usuario.activo=@activo WHERE dbo.usuario.id = @id;";

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
            return false;
        }



    }
}

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
            string query = "INSERT INTO dbo.usuario (nombre, apellido, dni, nombre_usuario, contraseña, admin, activo) VALUES " +
               "(@nombre, " +
               "@apellido, " +
               "@dni, " +
               "@nombre_usuario, " +
               "@contraseña, " +
               "@admin, " +
               "@activo " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@nombre", usuario.Name );
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
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_controller.connection.Close();
            }
            return true;
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
                    usuario.Activo = reader.GetBoolean(6);

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
            string query = "select * from dbo.usuario where dbo.usuario.nombre_usuario = @userName;";
            Usuario usuario = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@userName", username );
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
    
        public static List<Usuario> usuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "select * from dbo.usuario";
            Usuario usuario = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario = new Usuario(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)
                        , reader.GetString(4), reader.GetString(5), reader.GetBoolean(6), reader.GetBoolean(7));
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

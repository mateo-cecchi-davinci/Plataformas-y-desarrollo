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

namespace WindowsFormsApp1.Controllers
{
    public class Usuario_Controller
    {

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
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            return false;
        }

        public Usuario findByUserName(string username)
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
    }
}

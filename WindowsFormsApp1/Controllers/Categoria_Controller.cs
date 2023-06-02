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
                    cat =new Categoria();
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
                    categoria.Padre =  reader.GetInt64(2);
                    categoria.Activo = reader.GetBoolean(3);
                    if( categoria.Padre == -1)
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

                foreach(Categoria cat in listOrdenada)
                {
                    Categoria toResponse= new Categoria();
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
            foreach(Categoria cat in list){
                if(catPadre.Id == cat.Padre)
                {
                    subcategorias.Add(cat);
                    if(list.Where(x => x.Padre == cat.Id).Count() > 0)
                    {
                        cat.subcategorias = ordenarCategorias(list, cat);
                    }
                }
            }
            return subcategorias;
        }

    }

}

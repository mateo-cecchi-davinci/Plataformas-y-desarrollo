
using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Models.Graficos;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WindowsFormsApp1.Controllers
{
    public static class Venta_Controller
    {

        public static bool agregarVenta(VentaDTO venta)
        {
            int numeroDeFilas;

            string query = "INSERT INTO dbo.venta (total, fecha, id_cliente, id_vendedor) VALUES " +
               "(@total, " +
               "@fecha, " +
               "@id_cliente, " +
               "@id_vendedor " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            cmd.Parameters.AddWithValue("@total", venta.total);
            cmd.Parameters.AddWithValue("@fecha", venta.fecha);
            cmd.Parameters.AddWithValue("@id_cliente", venta.cliente);
            cmd.Parameters.AddWithValue("@id_vendedor", venta.vendedor);

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

        public static List<GraficoCategoriaBestSellerModel> getListaGraficoBestSeller()
        {
            List<GraficoCategoriaBestSellerModel> lista = new List<GraficoCategoriaBestSellerModel>();
            string query = "SELECT c.id, c.nombre, COUNT(iv.id_producto) AS cantidad_vendida FROM categoria c JOIN producto p ON c.id = p.categoria JOIN item_venta iv ON p.id = iv.id_producto GROUP BY c.id, c.nombre ORDER BY cantidad_vendida DESC;";
            GraficoCategoriaBestSellerModel model = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model = new GraficoCategoriaBestSellerModel();
                    model.Id = reader.GetInt64(0);
                    model.NombreCategoria = reader.GetString(1);
                    model.CantidadDeVentas = reader.GetInt32(2);
                    lista.Add(model);
                }
                reader.Close();
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return lista;
        }
        public static List<GraficoProductoBestSellerModel> getListaGraficoProductoBestSeller()
        {
            List<GraficoProductoBestSellerModel> lista = new List<GraficoProductoBestSellerModel>();
            string query = "SELECT TOP 5 p.id, p.nombre, SUM(iv.cantidad) AS total_vendido FROM Producto p JOIN item_venta iv ON p.id = iv.id_producto GROUP BY p.id, p.nombre ORDER BY total_vendido DESC;";
            GraficoProductoBestSellerModel model = null;

            SqlCommand cmd = new SqlCommand(query, DB_controller.connection);
            try
            {
                DB_controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model = new GraficoProductoBestSellerModel();
                    model.Id = reader.GetInt64(0);
                    model.NombreProducto = reader.GetString(1);
                    model.CantidadDeVentas = reader.GetInt32(2);
                    lista.Add(model);
                }
                reader.Close();
                DB_controller.connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return lista;
        }
        
    }
}

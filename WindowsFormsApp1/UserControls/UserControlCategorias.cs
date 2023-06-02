using iTextSharp.tool.xml.html.table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.UserControls
{
    public partial class UserControlCategorias : UserControl
    {
        public UserControlCategorias()
        {
            InitializeComponent();
            MostrarCategorias(null);
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria(1,0);
            DialogResult dialogResult = formCategoria.ShowDialog();
            if ( dialogResult == DialogResult.OK)
            {
                formCategoria.Close();
                MostrarCategorias(null);
            }
        }



        public void MostrarCategorias(string text = null)
        {
            
                List<Categoria> categorias = new List<Categoria>();

                if (!string.IsNullOrEmpty(text))
                {
                    tablaCategorias.Rows.Clear();
                    categorias = Categoria_Controller.obtenerTodas();
                foreach (Categoria cat in categorias)
                {

                    int rowIndex = tablaCategorias.Rows.Add();
                    tablaCategorias.Rows[rowIndex].Height = 100;

                    tablaCategorias.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                    tablaCategorias.Rows[rowIndex].Cells[1].Value = cat.Nombre;
                    tablaCategorias.Rows[rowIndex].Cells[2].Value = "No tiene";
                    tablaCategorias.Rows[rowIndex].Cells[3].Value = cat.Activo;

                    foreach (Categoria subcat in cat.subcategorias)
                    {

                        int rowIndex2 = tablaCategorias.Rows.Add();
                        tablaCategorias.Rows[rowIndex2].Height = 100;

                        tablaCategorias.Rows[rowIndex2].Cells[0].Value = subcat.Id.ToString();
                        tablaCategorias.Rows[rowIndex2].Cells[1].Value = subcat.Nombre;
                        tablaCategorias.Rows[rowIndex2].Cells[2].Value = Categoria_Controller.findById(subcat.Id).Nombre;
                        tablaCategorias.Rows[rowIndex2].Cells[3].Value = subcat.Activo;
                    }
                }
            }
                else
                {
                tablaCategorias.Rows.Clear();
                categorias = Categoria_Controller.obtenerTodas();

                foreach (Categoria cat in categorias)
                {
                    
                    int rowIndex = tablaCategorias.Rows.Add();
                    tablaCategorias.Rows[rowIndex].Height = 60;

                    tablaCategorias.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                    tablaCategorias.Rows[rowIndex].Cells[1].Value = cat.Nombre;
                    tablaCategorias.Rows[rowIndex].Cells[2].Value = "No tiene";
                    tablaCategorias.Rows[rowIndex].Cells[3].Value = cat.Activo;
                    
                        foreach (Categoria subcat in cat.subcategorias)
                        {
                        
                        int rowIndex2 = tablaCategorias.Rows.Add();
                        tablaCategorias.Rows[rowIndex2].Height = 60;

                        tablaCategorias.Rows[rowIndex2].Cells[0].Value = subcat.Id.ToString();
                        tablaCategorias.Rows[rowIndex2].Cells[1].Value = subcat.Nombre;
                        tablaCategorias.Rows[rowIndex2].Cells[2].Value = Categoria_Controller.findById(subcat.Padre).Nombre;
                        tablaCategorias.Rows[rowIndex2].Cells[3].Value = subcat.Activo;
                    }
                }
                
            }

        }

        private void buttonEstadoProducto_Click(object sender, EventArgs e)
        {
            if (tablaCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaCategorias.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["idCategoria"].Value.ToString();
                String celdaEstado = filaSeleccionada.Cells["estadoCategoria"].Value.ToString();
                long id = Int64.Parse(celdaId);
                bool activo = Boolean.Parse(celdaEstado);
                if (Categoria_Controller.cambiarEstado(id, activo))
                {
                    MessageBox.Show("Estado de categoria actualizado correctamente", "Cambio de estado de producto");

                }
                MostrarCategorias();
            }
            else
            {
                MessageBox.Show("Debes seleccionar una categoria en la tabla", "Error al querer cambiar estado");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if( tablaCategorias.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaCategorias.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["idCategoria"].Value.ToString();
                long id = Int64.Parse(celdaId);
                FormCategoria formCategoria = new FormCategoria(0, id);

                DialogResult dialogResult = formCategoria.ShowDialog();
                
                    MostrarCategorias(null);
                
            } else
            {
                MessageBox.Show("Debes seleccionar una categoria.", "Error categorias");
            }
            
        }
    }
}

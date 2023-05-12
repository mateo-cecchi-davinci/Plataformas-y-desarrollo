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


namespace WindowsFormsApp1.UserControls
{
    public partial class UserControl_Productos : UserControl
    {
        public UserControl_Productos()
        {
            InitializeComponent();
            MostrarProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregar = new FormAgregarProducto("ADD",0);

            DialogResult dialogResult = formAgregar.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                MostrarProductos();
            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarProductos(string text = null)
        {
            List<Producto> productos = new List<Producto>();

            if (!string.IsNullOrEmpty(text))
            {
                tablaProductos.Rows.Clear();
                productos = Producto_Controller.obtenerTodos(text);

                foreach (Producto prod in productos)
                {
                    int rowIndex = tablaProductos.Rows.Add();
                    tablaProductos.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    tablaProductos.Rows[rowIndex].Cells[1].Value = prod.Nombre;
                    tablaProductos.Rows[rowIndex].Cells[2].Value = prod.Descripcion;
                    tablaProductos.Rows[rowIndex].Cells[3].Value = prod.Stock.ToString();
                    tablaProductos.Rows[rowIndex].Cells[4].Value = prod.Precio.ToString();
                    tablaProductos.Rows[rowIndex].Cells[5].Value = prod.Activo.ToString();
                    tablaProductos.Rows[rowIndex].Cells[6].Value = Categoria_Controller.findById(prod.Categoria).Nombre;
                }
            }
            else
            {
                productos = Producto_Controller.obtenerTodos();
                tablaProductos.Rows.Clear();
                foreach (Producto prod in productos)
                {
                    int rowIndex = tablaProductos.Rows.Add();
                    tablaProductos.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    tablaProductos.Rows[rowIndex].Cells[1].Value = prod.Nombre;
                    tablaProductos.Rows[rowIndex].Cells[2].Value = prod.Descripcion;
                    tablaProductos.Rows[rowIndex].Cells[3].Value = prod.Stock.ToString();
                    tablaProductos.Rows[rowIndex].Cells[4].Value = prod.Precio.ToString();
                    tablaProductos.Rows[rowIndex].Cells[5].Value = prod.Activo.ToString();
                    tablaProductos.Rows[rowIndex].Cells[6].Value = Categoria_Controller.findById(prod.Categoria).Nombre;
                }
            }
        }

        private void buttonCambiarEstadoProducto_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaProductos.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["idProducto"].Value.ToString();
                String celdaEstado = filaSeleccionada.Cells["estadoProducto"].Value.ToString();
                long id = Int64.Parse(celdaId);
                bool activo = Boolean.Parse(celdaEstado);
                if(Producto_Controller.cambiarEstado(id, activo))
                {
                    MessageBox.Show("Estado de producto actualizado correctamente", "Cambio de estado de producto");

                }
               MostrarProductos();
            } else
            {
                MessageBox.Show("Debes seleccionar un producto en la tabla","Error al querer borrar");
            }
        }

        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaProductos.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["idProducto"].Value.ToString();

                long id = Int64.Parse(celdaId);

                FormAgregarProducto formAgregar = new FormAgregarProducto("EDIT", id);

                DialogResult dialogResult = formAgregar.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    MostrarProductos();
                }
    
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto en la tabla", "Error");
            }
        }
        private void buttonBuscadorProductos_Click(object sender, EventArgs e)
        {
            MostrarProductos(textBoxBuscarProductos.Text);
            textBoxBuscarProductos.Text = string.Empty;
        }
    }
}
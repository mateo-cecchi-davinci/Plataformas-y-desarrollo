using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controladores;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2.UserControls
{
    public partial class Productos : UserControl
    {

        List<Producto> productos;
        public Productos()
        {
            InitializeComponent();
            mostrarProductos();
        }

        private void mostrarProductos()
        {

            productos = Producto_Controlador.obtenerTodos();
            tablaProductos.Rows.Clear();
            foreach (Producto prod in productos)
            {
                int rowIndex = tablaProductos.Rows.Add();

                tablaProductos.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                tablaProductos.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                tablaProductos.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                tablaProductos.Rows[rowIndex].Cells[3].Value = prod.Activo.ToString();

                if (prod.Activo)
                {
                    tablaProductos.Rows[rowIndex].Cells[4].Value = "Desactivar";
                }
                else
                {
                    tablaProductos.Rows[rowIndex].Cells[4].Value = "Activar";
                }

                tablaProductos.Rows[rowIndex].Cells[5].Value = "Editar";

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            DialogResult dialogResult = form1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");
                mostrarProductos();
            }
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int id = int.Parse(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex].Name == "Acciones" && e.RowIndex >= 0)
            {

                //  ACTUALIZAR EL ESTADO

                string estado = tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (estado == "True")
                {
                    Producto_Controlador.cambiarEstado(id, 0);
                }
                else
                {
                    Producto_Controlador.cambiarEstado(id, 1);
                }
                mostrarProductos();

                /*
                Producto prodEditar = Producto_Controlador.obtenerProducto(id);

                Form1 productForm = new Form1(prodEditar);
                DialogResult dialogResult = productForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Producto_Controlador.editarProducto(id, productForm.productoEditar);
                }
                */

            }

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {

                //  EDITAR

                Producto prodEditar = Producto_Controlador.obtenerProducto(id);

                Form1 form1 = new Form1(prodEditar);

                DialogResult dialogResult = form1.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Trace.WriteLine("OK");
                    mostrarProductos();
                }

            }
        }
    }
}

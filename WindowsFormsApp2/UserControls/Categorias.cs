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
    public partial class Categorias : UserControl
    {
        List<Categoria> categorias;
        public Categorias()
        {
            InitializeComponent();
            mostrarCategorias();
        }

        private void mostrarCategorias()
        {

            categorias = Categoria_Controlador.obtenerTodos();
            panelCategorias.Rows.Clear();
            foreach (Categoria cat in categorias)
            {
                int rowIndex = panelCategorias.Rows.Add();

                panelCategorias.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                panelCategorias.Rows[rowIndex].Cells[1].Value = cat.Nombre.ToString();
                panelCategorias.Rows[rowIndex].Cells[2].Value = cat.padre.Nombre.ToString();
                panelCategorias.Rows[rowIndex].Cells[3].Value = cat.Activo.ToString();

                if (cat.Activo)
                {
                    panelCategorias.Rows[rowIndex].Cells[4].Value = "Desactivar";
                }
                else
                {
                    panelCategorias.Rows[rowIndex].Cells[4].Value = "Activar";
                }

                panelCategorias.Rows[rowIndex].Cells[5].Value = "Editar";

            }
        }

        private void panelCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int id = int.Parse(panelCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (senderGrid.Columns[e.ColumnIndex].Name == "Acciones" && e.RowIndex >= 0)
            {

                //  ACTUALIZAR EL ESTADO

                string estado = panelCategorias.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (estado == "True")
                {
                    Categoria_Controlador.cambiarEstado(id, 0);
                }
                else
                {
                    Categoria_Controlador.cambiarEstado(id, 1);
                }
                mostrarCategorias();

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

                Categoria catEditar = Categoria_Controlador.obtenerCategoria(id);

                FormCategorias formCats = new FormCategorias(catEditar);

                DialogResult dialogResult = formCats.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Trace.WriteLine("OK");
                    mostrarCategorias();
                }

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FormCategorias formCats = new FormCategorias();

            DialogResult dialogResult = formCats.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Trace.WriteLine("OK");
                mostrarCategorias();
            }
        }
    }
}

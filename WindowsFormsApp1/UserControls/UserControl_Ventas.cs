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
    public partial class UserControl_Ventas : UserControl
    {
        Producto prodToAdd;

        Venta venta = new Venta();

        public UserControl_Ventas()
        {
            InitializeComponent();
            MostrarProductos(null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ConfirmarVenta formConfirmarVenta = new ConfirmarVenta(venta);

            DialogResult dialogResult = formConfirmarVenta.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {



            MostrarProductos(txtNombreProd.Text);

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (foundProductsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = foundProductsTable.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["Id"].Value.ToString();
                
                long id = Int64.Parse(celdaId);
                MessageBox.Show(id.ToString() , "");

                AgregarProductoAVenta(id);
                MostrarProductosDeVenta();

                txtNombreProd.Text = "";

            }
            else
            {
                MessageBox.Show("Debes seleccionar almenos un producto", "Error");
            }

        }

        public void MostrarProductos(string nombre)
        {
            List<Producto> productos = new List<Producto>();

            foundProductsTable.Rows.Clear();

            productos = Producto_Controller.obtenerTodos(nombre);

            foreach (Producto prod in productos)
            {
                int rowIndex = foundProductsTable.Rows.Add();


                foundProductsTable.Rows[rowIndex].Cells[0].Value = prod.Nombre;
                foundProductsTable.Rows[rowIndex].Cells[1].Value = prod.Stock.ToString();
                foundProductsTable.Rows[rowIndex].Cells[2].Value = prod.Id;

            }
        }

        public void AgregarProductoAVenta(long id)
        {
            Producto prod = Producto_Controller.findById(id);


            int cantidad = Int32.Parse(txtCantidadProd.Value.ToString());



            foreach (ItemVenta item in venta.Items)
            {
                if (item.Producto.Id == prod.Id)
                {
                    if (item.Cantidad < cantidad && prod.Stock > cantidad)
                    {
                        item.Cantidad += cantidad;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Error" + cantidad, "");

                    }
                }

            }
            if (prod.Stock >= cantidad)
            {                 
                    ItemVenta itemVenta = new ItemVenta();
                    itemVenta.Producto = prod;
                    itemVenta.Cantidad = cantidad;
                    venta.Items.Add(itemVenta);
                
            } else
            {
                MessageBox.Show("No hay suficiente stock", "");
            }

        }

        public void MostrarProductosDeVenta()
        {
            tablaVenta.Rows.Clear();
           if( venta.Items.Count > 0)
            {
                foreach (ItemVenta itemVenta in venta.Items)
                {

                    int rowIndex = tablaVenta.Rows.Add();

                    tablaVenta.Rows[rowIndex].Cells[0].Value = itemVenta.Producto.Id;
                    tablaVenta.Rows[rowIndex].Cells[1].Value = itemVenta.Producto.Nombre;
                    tablaVenta.Rows[rowIndex].Cells[2].Value = itemVenta.Producto.Precio;
                    tablaVenta.Rows[rowIndex].Cells[3].Value = itemVenta.Producto.Descripcion;
                    tablaVenta.Rows[rowIndex].Cells[4].Value = itemVenta.Cantidad;



                }
            }
            
        }

    }
}

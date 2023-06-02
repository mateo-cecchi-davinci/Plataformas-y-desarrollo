﻿using System;
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
        Usuario usuario;

        public UserControl_Ventas(Usuario user)
        {
            InitializeComponent();
            MostrarProductos(null);
            List <Categoria> categorias = Categoria_Controller.obtenerTodas();

            List<Categoria> lista = Categoria_Controller.obtenerTodas();
            label15.Text = DateTime.Now.Date.ToShortDateString();
            label14.Text = user.UserName.ToString();

            usuario = user;
            venta.vendedor = user._id;

            foreach (Categoria c in lista)
            {
                comboboxCategoria.Items.Add(c.Nombre);
                foreach (Categoria subcat in c.subcategorias)
                {
                    comboboxCategoria.Items.Add(subcat.Nombre);
                }
            }
            txtNombreCliente.Text = "Cliente: Consumidor Final";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void UserControl_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            if (venta.Items.Count < 1)
            {
                MessageBox.Show("Debes seleccionar al menos un producto para realizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
/*
            if( string.IsNullOrWhiteSpace(txtBoxNombreClienteVentas.Text) &&
                string.IsNullOrWhiteSpace(txtBoxDNIlVentas.Text) &&
                string.IsNullOrWhiteSpace(txtBoxAddressVentas.Text))
            {
                
                cliente.Nombre = "Consumidor Final";
                cliente.Dni = "XXXXXXXXX";
                cliente.Direccion = "XXXXXXXX";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtBoxNombreClienteVentas.Text))
                {
                    MessageBox.Show("Por favor ingresa tu nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBoxDNIlVentas.Text))
                {
                    MessageBox.Show("Por favor ingresa un email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBoxAddressVentas.Text))
                {
                    MessageBox.Show("Por favor ingresa una direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cliente.Nombre = txtBoxNombreClienteVentas.Text.ToString();
                cliente.Dni = txtBoxDNIlVentas.Text.ToString();
                cliente.Direccion = txtBoxAddressVentas.Text.ToString();
            }
            */
            

            if (radioBtnTarjeta.Checked.Equals(false) && radioBtnEfectivo.Checked.Equals(false))
            {
                radioBtnEfectivo.Checked = true;
            }
            
            ConfirmarVenta formConfirmarVenta = new ConfirmarVenta(venta, cliente, usuario, this);

            DialogResult dialogResult = formConfirmarVenta.ShowDialog(this);

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

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (foundProductsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = foundProductsTable.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["Id"].Value.ToString();
                
                long id = Int64.Parse(celdaId);

                AgregarProductoAVenta(id);
                MostrarProductosDeVenta();

                txtNombreProd.Clear();
                CalcularTotales();

            }
            else
            {
                MessageBox.Show("Debes seleccionar almenos un producto", "Error");
            }

        }

        private void CalcularTotales()
        {
            decimal subTotal = decimal.Zero;
            decimal totalConIVA = decimal.Zero;

            foreach (ItemVenta item in venta.Items)
            {
                subTotal += item.Producto.Precio * item.Cantidad;
                totalConIVA = subTotal + (subTotal * 21)/100;
            }

            venta.total = totalConIVA;
            txtSubTotal1.Text = subTotal.ToString();
            txtTotalConIVA1.Text = totalConIVA.ToString();
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

        public void MostrarProductosPorCategoria(string categoria)
        {
            List<Producto> productos = new List<Producto>();

            foundProductsTable.Rows.Clear();

            productos = Producto_Controller.obtenerTodosPorCategoria(categoria);

            if(productos.Count > 0)
            {
                foreach (Producto prod in productos)
                {
                    int rowIndex = foundProductsTable.Rows.Add();


                    foundProductsTable.Rows[rowIndex].Cells[0].Value = prod.Nombre;
                    foundProductsTable.Rows[rowIndex].Cells[1].Value = prod.Stock.ToString();
                    foundProductsTable.Rows[rowIndex].Cells[2].Value = prod.Id;

                }
            }
            else
            {
                int rowIndex = foundProductsTable.Rows.Add();

                foundProductsTable.Rows[rowIndex].Cells[0].Value = "Sin productos";
                foundProductsTable.Rows[rowIndex].Cells[1].Value = "0";
                foundProductsTable.Rows[rowIndex].Cells[2].Value = 0;
            }

        }

        public void AgregarProductoAVenta(long id)
        {
            Producto prod = Producto_Controller.findById(id);
            int cantidad = Int32.Parse(txtCantidadProd.Value.ToString());
                
            ItemVenta productoExistenteEnVentas = venta.Items.Where(item => item.Producto.Id == prod.Id).FirstOrDefault();

            int nuevaCantidad = productoExistenteEnVentas != null 
                                ? productoExistenteEnVentas.Cantidad + cantidad : 0;

            
            if(prod.Stock >= nuevaCantidad && productoExistenteEnVentas != null)
            {
                productoExistenteEnVentas.Cantidad += cantidad;
            }
            else if(prod.Stock >= cantidad && productoExistenteEnVentas == null)
            {
                ItemVenta itemVenta = new ItemVenta();
                itemVenta.Producto = prod;
                itemVenta.Cantidad = cantidad;
                venta.Items.Add(itemVenta);
            }
            else
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

        private void txtNombreProd_TextChanged(object sender, EventArgs e)
        {
            if(comboboxCategoria.SelectedItem == null)
            {
                label5.Text = "Debes seleccionar una Categoria";
                label5.ForeColor = Color.Red;
                txtNombreProd.Clear();
                comboboxCategoria.Focus();
            }
            else
            {
                label5.Text = "Producto:";
                label5.ForeColor = Color.Black;
                List<Producto> productos = Producto_Controller.obtenerTodosPorCategoria(comboboxCategoria.SelectedItem.ToString());
                List<Producto> productosFiltrados = productos.FindAll(p => p.Nombre.Contains(txtNombreProd.Text));

                foundProductsTable.Rows.Clear();


                foreach (Producto prod in productosFiltrados)
                {
                    int rowIndex = foundProductsTable.Rows.Add();


                    foundProductsTable.Rows[rowIndex].Cells[0].Value = prod.Nombre;
                    foundProductsTable.Rows[rowIndex].Cells[1].Value = prod.Stock.ToString();
                    foundProductsTable.Rows[rowIndex].Cells[2].Value = prod.Id;

                }
            }
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreProd.Clear();
            label5.Text = "Producto:";
            label5.ForeColor = Color.Black;
            Categoria cat = Categoria_Controller.findByName(comboboxCategoria.SelectedItem.ToString());
            
            MostrarProductosPorCategoria(cat.Nombre.ToString());
        }

        private void btnDeleteSalesProduct_Click(object sender, EventArgs e)
        {
            if (tablaVenta.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaVenta.SelectedRows[0];

                long id = Int64.Parse(filaSeleccionada.Cells["Codigo"].Value.ToString());

                Producto prod = Producto_Controller.findById(id);
                ItemVenta item = venta.Items.Where(x => x.Producto.Nombre == prod.Nombre).FirstOrDefault();
                venta.Items.Remove(item);
                CalcularTotales();

                MostrarProductosDeVenta();
            }
        }

        public void CleanTable()
        {
            tablaVenta.Rows.Clear();
            txtSubTotal1.Clear();
            txtTotalConIVA1.Clear();

            for (int i = 0; i < venta.Items.Count(); i ++)
            {
                venta.Items.RemoveAt(i);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBoxDNIlVentas.Text.Length > 0 && txtBoxDNIlVentas.Text.Length < 15)
            {
                Cliente cliente = Clientes_Controller.buscarCliente(txtBoxDNIlVentas.Text);
              

                if (String.IsNullOrEmpty(cliente.Dni))
                {
                    txtNombreCliente.Text = "Cliente: Consumidor Final";
                }
                else
                {
                    txtNombreCliente.Text = "Cliente: " + cliente.Nombre;
                }
            } else
            {
                MessageBox.Show("Debes ingresar un DNI válido.", "Error al buscar cliente");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FormCliente formAgregarCliente = new FormCliente();

            DialogResult dialogResult = formAgregarCliente.ShowDialog();

           
        }

        private void txtBoxDNIlVentas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

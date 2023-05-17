﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1
{
    public partial class FormAgregarProducto : Form
    {
        string situacionState = "ADD";
        long idToEdit = 0;
        Image File;
        public FormAgregarProducto(string situacion,long id)
        {
            InitializeComponent();
            List<Categoria> lista = Categoria_Controller.obtenerTodas();

            foreach (Categoria c in lista)
            {
                txtCategoria.Items.Add(c.Nombre);
                foreach (Categoria subcat in c.subcategorias)
                {
                    txtCategoria.Items.Add(subcat.Nombre);
                }
            }

            if ( id != 0)
            {
                situacionState = situacion;
                idToEdit = id;
                label1.Text = "Editar un producto";
                buttonAgregarProducto.Text = "Actualizar";
                Producto productoToEdit = Producto_Controller.findById(id);
                txtNombre.Text = productoToEdit.Nombre;
                txtDescripcion.Text = productoToEdit.Descripcion;

                foreach (string catName in txtCategoria.Items)
                {
                    if (catName == Categoria_Controller.findById(productoToEdit.Categoria).Nombre)
                    {
                        txtCategoria.SelectedItem = catName;
                        break;
                    }
                }

                txtPrecio.Text = productoToEdit.Precio.ToString();
                txtStock.Value = productoToEdit.Stock;
                
            }
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog  openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
               File = Image.FromFile(openFileDialog.FileName);
               imagenProducto.Image = File;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Stock = Int32.Parse(txtStock.Value.ToString());
            producto.Precio = Decimal.Parse(txtPrecio.Text);
            producto.Image = NombreImagen.Text;
            producto.Categoria = Categoria_Controller.findByName(txtCategoria.SelectedItem.ToString()).Id;
            producto.Activo = true;
            try
            {
                File.Save(@"C:\Users\Usuario\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\imagenes\productos\" + NombreImagen.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            {
                MessageBox.Show("Hay un problema con la imagen.", "");
                return;

            }
            if (situacionState.Equals("EDIT"))
            {
                if (Producto_Controller.actualizarProducto(idToEdit,producto))
                {
                    MessageBox.Show("Producto agregado correctamente", "Exito al agregar");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Debes completar todos los campos", "Error al agregar producto");
                }
            }
            else 
            { 
                if (Producto_Controller.addProducto(producto))
                {
                    MessageBox.Show("Producto agregado correctamente", "Exito al agregar");
                    this.DialogResult = DialogResult.OK;
                } 
                else
                {
                    MessageBox.Show("Debes completar todos los campos", "Error al agregar producto");
                }
            }
        }
            private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
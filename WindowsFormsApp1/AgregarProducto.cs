using System;
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
using WindowsFormsApp1.Models;


namespace WindowsFormsApp1
{
    public partial class AgregarProducto : Form
    {
        Image File;

        Categoria_Controller catController = new Categoria_Controller();
        Producto_Controller producto_Controller = new Producto_Controller();
        public AgregarProducto(string situacion)
        {
            InitializeComponent();
            List<Categoria> lista = catController.obtenerTodas();
            foreach (Categoria c in lista)
            {
                txtCategoria.Items.Add(c.Nombre);
                foreach (Categoria subcat in c.subcategorias)
                {
                    txtCategoria.Items.Add(subcat.Nombre);
                }
            }
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG(*.JPG)|*.jpg|*.jpeg|JPEG(*.JPEG)";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File  = Image.FromFile(ofd.FileName);
                imagen.Image = File;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {




            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Descripcion = txtDescripcion.Text;
            producto.Stock = Int32.Parse(txtStock.Value.ToString());
            producto.Precio = Double.Parse(txtPrecio.Text);
            producto.Imagen = File.ToString();
            producto.Categoria = txtCategoria.SelectedIndex;
            producto.Activo = true;
            producto_Controller.addProducto(producto);
        }
    }
}

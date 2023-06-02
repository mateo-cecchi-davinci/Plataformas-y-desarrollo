using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class FormInicio : Form
    {
        public Usuario user;
        public FormInicio(Usuario usuario)
        {
            InitializeComponent();
            UserControl_Inicio ucInicio = new UserControl_Inicio();
            addUserControl(ucInicio);

            cargarFotoDePerfil(usuario.Imagen);

            label2.Text = usuario.UserName;
            user = usuario;

            if (usuario.Admin == false)
            { 
                buttonProductos.Hide();
                buttonUsuarios.Hide();
                guna2Button1.Hide();
            }
        }

        private void cargarFotoDePerfil(byte[] fotoDePerfil) 
        {
            MemoryStream ms = new MemoryStream(fotoDePerfil);

            Bitmap bitmap = new Bitmap(ms);

            guna2PictureBox1.Image = bitmap;
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void buttonInicioPantalla_Click(object sender, EventArgs e)
        {
            UserControl_Inicio ucInicio = new UserControl_Inicio();
            addUserControl(ucInicio);
        
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            UserControl_Productos ucProductos = new UserControl_Productos();
            addUserControl(ucProductos);
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            UserControl_Usuarios ucUsuarios = new UserControl_Usuarios();
            addUserControl(ucUsuarios);
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            UserControl_Ventas ucVentas = new UserControl_Ventas(this.user);
            addUserControl(ucVentas);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControlCategorias ucCategorias = new UserControlCategorias();
            addUserControl(ucCategorias);
        }
    }
}

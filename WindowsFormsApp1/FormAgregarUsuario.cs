using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Helper;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class FormAgregarUsuario : Form
    {
        string situacionState = "ADD";
        long idToEdit = 0;
        public FormAgregarUsuario()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImgUsuario_Click(object sender, EventArgs e)
        {
            ImageCreator.Crear(imagenUsuario);
        }

        private void confirmarAgregarUsuarioButton_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Name = txtAgregarNombreUsuario.Text;
            usuario.Apellido = txtApellidoUsuario.Text;
            usuario.Dni = txtDniUsuario.Text;
            usuario.UserName = txtUserName.Text;
            usuario.Contraseña = txtContraseñaUsuario.Text;
            usuario.imagen = ConvertirImg();

            
        }

        private byte[] ConvertirImg()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagenUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
    }
}

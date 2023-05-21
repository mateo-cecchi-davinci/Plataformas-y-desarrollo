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
        public FormAgregarUsuario(string situacion, long id)
        {
            InitializeComponent();
            if (id != 0)
            {
                situacionState = situacion;
                idToEdit = id;
                label1.Text = "Editar un Usuario";
                confirmarAgregarUsuarioButton.Text = "Actualizar";
                Usuario usarioToEdit = Usuario_Controller.findById(id);
                txtAgregarNombreUsuario.Text = usarioToEdit.Name;
                txtApellidoUsuario.Text = usarioToEdit.Apellido;
                txtDniUsuario.Text = usarioToEdit.Dni;
                txtUserName.Text = usarioToEdit.UserName;
                txtContraseñaUsuario.Text = usarioToEdit.Contraseña;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarImgUsuario_Click(object sender, EventArgs e)
        {
            ImageCreator.Crear(imagenUsuario);
        }

        private void btnAgregarUsuario(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Dni = txtDniUsuario.Text;
            usuario.UserName = txtUserName.Text;
            usuario.Contraseña = txtContraseñaUsuario.Text;
            usuario.imagen = ConvertirImg();
            usuario.Activo = true;
            usuario.Admin = true;

            //Validaciones

            if(Usuario_Controller.validoNombreCompleto(txtAgregarNombreUsuario.Text, txtApellidoUsuario.Text))
            {
                usuario.Name = txtAgregarNombreUsuario.Text;
                usuario.Apellido = txtApellidoUsuario.Text;
            }
            else
            {
                MessageBox.Show("Este usuario ya ha sido registrado", "Error al agregar un usuario");
            }
                

            if (situacionState.Equals("EDIT"))
            {
                if (Usuario_Controller.actualizarUsuario(idToEdit, usuario))
                {
                    MessageBox.Show("Usuario agregado correctamente", "Exito al agregar");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Debes completar todos los campos", "Error al agregar un usuario");
                }
            }
            else
            {
                if (Usuario_Controller.crearUsuario(usuario))
                {
                    MessageBox.Show("Producto agregado correctamente", "Exito al agregar");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Debes completar todos los campos", "Error al agregar un usuario");
                }
            }
        }

        private byte[] ConvertirImg()
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagenUsuario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }
    }
}

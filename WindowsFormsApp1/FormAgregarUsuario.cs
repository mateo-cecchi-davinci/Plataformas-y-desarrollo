using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
using WindowsFormsApp1.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class FormAgregarUsuario : Form
    {
        string situacionState = "ADD";
        long idToEdit = 0;
        private  Usuario _usarioToEdit;
        Image File;

        public FormAgregarUsuario(string situacion, long id)
        {
            InitializeComponent();
            if (id != 0)
            {
                situacionState = situacion;
                idToEdit = id;
                label1.Text = "Editar un Usuario";
                confirmarAgregarUsuarioButton.Text = "Actualizar";
                _usarioToEdit = Usuario_Controller.findById(id);
                txtAgregarNombreUsuario.Text = _usarioToEdit.Name;
                txtApellidoUsuario.Text = _usarioToEdit.Apellido;
                txtDniUsuario.Text = _usarioToEdit.Dni;
                txtUserName.Text = _usarioToEdit.UserName;
                txtContraseñaUsuario.Text = _usarioToEdit.Contraseña;
                 if( _usarioToEdit.Admin != false )
                {
                    btnAdmin.Checked = false;
                    btnNoAdmin.Checked = true;

                }
                else
                {
                    btnAdmin.Checked = true;
                    btnNoAdmin.Checked = false;
                }
                imagenUser.Image = cargarFotoDePerfil(_usarioToEdit.Imagen);
            } else
            {
                btnAdmin.Checked = true;
            }

        }

        private Bitmap cargarFotoDePerfil(byte[] fotoDePerfil)
        {
            MemoryStream ms = new MemoryStream(fotoDePerfil);

            Bitmap bitmap = new Bitmap(ms);

            return bitmap;
        }



        private bool validarConstraseña(string constraseña, string confirmarConstraseña )
        {
            if(constraseña.Equals(confirmarConstraseña))
            {
                return true;
            }
            return false;
        }

        private void btnAgregarUsuario(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            String[] campos = { txtDniUsuario.Text,
                                txtUserName.Text,
                                txtAgregarNombreUsuario.Text,
                                txtApellidoUsuario.Text,
                                txtContraseñaUsuario.Text,
                                txtConfirmarContraseña.Text };

            //Validaciones
            if (campos.All(campo => campo.Length > 0) && txtDniUsuario.Text.Length < 16)
            {
                usuario.Dni = txtDniUsuario.Text;
                usuario.UserName = txtUserName.Text;
                usuario.Name = txtAgregarNombreUsuario.Text;
                usuario.Apellido = txtApellidoUsuario.Text;
                usuario.Activo = true;
                if (btnAdmin.Checked)
                {
                    
                    usuario.Admin = true;
                }
                else
                {
                    usuario.Admin = false;
                }
            }
            else
            {
                labelAgregarUsuarioError.Visible = true;
                return;
            }

            //valido imagen
            if(imagenUser.Image != null)
            {
                usuario.Imagen = ExtraerBytesFromImage();
            }
            else
            {
                MessageBox.Show("Se necesita una imagen para el usuario", "Error");
                return;
            }

            //valido contraseña
            if (validarConstraseña(txtContraseñaUsuario.Text, txtConfirmarContraseña.Text))
            {
                usuario.Contraseña = txtContraseñaUsuario.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Error Confirmar Password");
                return;
            }


            if (situacionState.Equals("EDIT"))
            {
                if(usuario.Dni == _usarioToEdit.Dni)
                {
                    if (Usuario_Controller.actualizarUsuario(idToEdit, usuario))
                    {
                        MessageBox.Show($"Usuario {usuario.UserName} actualizado correctamente", "Exito al actualizar");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Debes completar todos los campos", "Error al actualizar un usuario");
                    }
                }
                else
                {
                    MessageBox.Show($"Este DNI {usuario.Dni} ya ha sido registrado", "Error al actualizar un usuario");
                }
               
            }
            else
            {
                if (Usuario_Controller.validoNombreCompleto(txtAgregarNombreUsuario.Text, txtApellidoUsuario.Text) 
                    && Usuario_Controller.validarDNI(txtDniUsuario.Text))
                {
                    usuario.Name = txtAgregarNombreUsuario.Text;
                    usuario.Apellido = txtApellidoUsuario.Text;
                    if (Usuario_Controller.crearUsuario(usuario))
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
                    MessageBox.Show($"Este usuario {usuario.Name} {usuario.Apellido} ya ha sido registrado ", "Error al agregar un usuario");
                }
            }
        }
                

            

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!txtContraseñaUsuario.Text.Equals(txtConfirmarContraseña.Text))
            {
                labelConfirmarContreña.Visible = true;
                labelConfirmarContreña.Text = "No coinciden los valores asignados";
                labelConfirmarContreña.ForeColor = Color.Red;
            }
            else
            {
                labelConfirmarContreña.Text = "Coinciden";
                labelConfirmarContreña.ForeColor = Color.Green;
            }
        }

        private byte[] ExtraerBytesFromImage()
        {
            byte[] imagenBytes;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                imagenUser.Image.Save(memoryStream, ImageFormat.Jpeg); // Cambia ImageFormat.Jpeg según el formato de tu imagen
                imagenBytes = memoryStream.ToArray();
            }

            return imagenBytes;
        }

        private void btnCargarImgUsuario_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(openFileDialog.FileName);
                imagenUser.Image = File;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

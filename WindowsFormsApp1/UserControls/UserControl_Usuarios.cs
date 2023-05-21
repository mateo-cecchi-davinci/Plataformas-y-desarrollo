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

namespace WindowsFormsApp1.UserControls
{
    public partial class UserControl_Usuarios : UserControl
    {
        List<Usuario> usuarios = new List<Usuario>();
        public UserControl_Usuarios()
        {
            InitializeComponent();
            mostrarUsuarios();
        }


        private void mostrarUsuarios()
        {

            usuarios = Usuario_Controller.usuarios();

            tablaUsuarios.Rows.Clear();
            foreach (Usuario usuario in usuarios)
            {
                int rowIndex = tablaUsuarios.Rows.Add();

                tablaUsuarios.Rows[rowIndex].Cells[0].Value = usuario._id;
                tablaUsuarios.Rows[rowIndex].Cells[1].Value = usuario.Name;
                tablaUsuarios.Rows[rowIndex].Cells[2].Value = usuario.Apellido;
                tablaUsuarios.Rows[rowIndex].Cells[3].Value = usuario.Dni;
                tablaUsuarios.Rows[rowIndex].Cells[4].Value = usuario.UserName;
                tablaUsuarios.Rows[rowIndex].Cells[5].Value = usuario.Activo;


                /*if (prod.Activo)
                {
                    tablaProductos.Rows[rowIndex].Cells[4].Value = "Desactivar";
                }
                else
                {
                    tablaProductos.Rows[rowIndex].Cells[4].Value = "Activar";
                }

                tablaProductos.Rows[rowIndex].Cells[5].Value = "Editar";
                */
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCambiarEstadoUsuario_Click(object sender, EventArgs e)
        {
            if (tablaUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaUsuarios.SelectedRows[0];
                String celdaId = filaSeleccionada.Cells["ID"].Value.ToString();
                String celdaEstado = filaSeleccionada.Cells["Activo"].Value.ToString();
                long id = Int64.Parse(celdaId);
                bool activo = Boolean.Parse(celdaEstado);
                if (Usuario_Controller.cambiarEstadoUsuario(id, activo))
                {
                    MessageBox.Show("Estado de usuario actualizado correctamente", "Cambio de estado de usuario");

                }
                mostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un usuario en la tabla", "Error al querer borrar");
            }
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario("ADD", 0);

            DialogResult dialogResult = formAgregarUsuario.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mostrarUsuarios();
            }
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            if (tablaUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = tablaUsuarios.SelectedRows[0];

                String celdaId = filaSeleccionada.Cells["ID"].Value.ToString();

                long id = Int64.Parse(celdaId);

                FormAgregarUsuario formAgregar = new FormAgregarUsuario("EDIT", id);

                DialogResult dialogResult = formAgregar.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    mostrarUsuarios();
                }

                mostrarUsuarios();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un usuario en la tabla", "Error");
            }
        }
    }
}

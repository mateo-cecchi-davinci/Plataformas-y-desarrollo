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

            guna2DataGridView1.Rows.Clear();
            foreach (Usuario usuario in usuarios)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = usuario._id;
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = usuario.Name;
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = usuario.Apellido;
                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = usuario.Dni;
                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = usuario.UserName;
                guna2DataGridView1.Rows[rowIndex].Cells[5].Value = usuario.Activo;


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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = guna2DataGridView1.SelectedRows[0];
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
    }
}

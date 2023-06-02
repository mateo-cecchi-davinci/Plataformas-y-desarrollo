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

namespace WindowsFormsApp1
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            btnConsumidorFinal.Select();
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            String[] campos = { txtNombreCliente.Text, txtDireccionCliente.Text, txtDniCliente.Text, txtEmailCliente.Text, btnConsumidorFinal.Checked ? "1" : "2" };

            if (campos.All(campo => campo.Length > 0) && txtDniCliente.Text.Length < 16)
            {
                txtError.Visible = false;
                Cliente clienteToAdd = new Cliente();
                clienteToAdd.Nombre = txtNombreCliente.Text;
                clienteToAdd.Email = txtEmailCliente.Text;
                clienteToAdd.Dni = txtDniCliente.Text;
                clienteToAdd.Direccion = txtDireccionCliente.Text;
                clienteToAdd.Tipo = Int32.Parse(campos[4]);
                if (Clientes_Controller.agregarCliente(clienteToAdd))
                {
                    MessageBox.Show("Cliente agregado exitosamente.", "Agregar Cliente");
                    Close();
                };
            }
            else
            {
                txtError.Visible = true;

            }
        }


        private void clearTextBoxs()
        {
            txtNombreCliente.Text = "";
                 txtDireccionCliente.Text = "";
                 txtDniCliente.Text = "";
                 txtEmailCliente.Text = "";
            btnConsumidorFinal.Checked = true;
        }
    }
}

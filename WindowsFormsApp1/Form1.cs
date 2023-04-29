using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserControl_Inicio ucInicio = new UserControl_Inicio();
            addUserControl(ucInicio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControl_Inicio ucInicio = new UserControl_Inicio();
            addUserControl(ucInicio);
        
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserControl_Productos ucProductos = new UserControl_Productos();
            addUserControl(ucProductos);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserControl_Usuarios ucUsuarios = new UserControl_Usuarios();
            addUserControl(ucUsuarios);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UserControl_Ventas ucVentas = new UserControl_Ventas();
            addUserControl(ucVentas);
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

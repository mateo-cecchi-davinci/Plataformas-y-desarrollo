﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            guna2CirclePictureBox1.Image = Image.FromFile("C:\\Users\\Usuario\\Desktop\\.NET Apps\\prueba\\Plataformas-y-desarrollo\\WindowsFormsApp1\\Resources\\imagenes\\usuarios\\" + usuario.Img + ".jpeg");
            label2.Text = usuario.UserName;
            user = usuario;

            if (usuario.Admin == false)
            {
                buttonInicioPantalla.Hide();
                buttonUsuarios.Hide();
            }
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControlCategorias ucCategorias = new UserControlCategorias();
            addUserControl(ucCategorias);
        }
    }
}

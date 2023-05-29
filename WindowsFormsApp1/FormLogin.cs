using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            
            label7.Visible = false;


            Usuario u = Usuario_Controller.findByUserName(txtUsername.Text.Trim());
            if(u != null )
            {
               if( guna2TextBox1.Text.Equals(u.Contraseña)) {
                    FormInicio form1 = new FormInicio(u);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    label7.Visible = true;

                    label7.Text = "La contraseña no es correcta";

                }
            } 
            else
            {
                label6.Visible = true;

                label6.Text = "El usuario no existe";
            }
        }
    }

}


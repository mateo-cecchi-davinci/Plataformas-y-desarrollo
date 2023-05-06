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
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            
            label7.Visible = false;


            Usuario u = Usuario_Controller.findByUserName(txtUsername.Text.Trim());
            if(u != null )
            {
               if( guna2TextBox1.Text.Equals(u.Contraseña)) {
                    Form1 form1 = new Form1(u.Img, u.UserName);
                    form1.Show();
                } else
                {
                    label7.Visible = true;

                    label7.Text = "La contraseña no es correcta";

                }
            } else
            {
                label6.Visible = true;

                label6.Text = "El usuario no existe";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }


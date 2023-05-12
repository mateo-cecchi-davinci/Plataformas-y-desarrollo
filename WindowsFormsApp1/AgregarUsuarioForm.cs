using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1
{
    public partial class AgregarUsuarioForm : Form
    {
        public AgregarUsuarioForm()
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
    }
}

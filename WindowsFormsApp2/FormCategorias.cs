using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        public FormCategorias(Categoria cat)
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using WindowsFormsApp2.UserControls;

namespace WindowsFormsApp2
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            Productos productos = new Productos();
            addUserControl(productos);
        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            addUserControl(productos);
        }

        private void btn_cats_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            addUserControl(categorias);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

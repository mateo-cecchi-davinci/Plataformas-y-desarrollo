using Guna.UI2.WinForms;
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
    public partial class ConfirmarVenta : Form
    {
        public ConfirmarVenta(Venta venta)
        {
            InitializeComponent();
            llenarTabla(venta);

            comboboxIva.Items.Add("0");
            comboboxIva.Items.Add("10,5");
            comboboxIva.Items.Add("21");
            comboboxIva.Items.Add("27");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenarTabla(Venta venta)
        {

            tablaConfirmarVenta.Rows.Clear();

            foreach (ItemVenta item in venta.Items)
            {
                int rowIndex = tablaConfirmarVenta.Rows.Add();

                tablaConfirmarVenta.Rows[rowIndex].Cells[0].Value = item.Producto.Id;
                tablaConfirmarVenta.Rows[rowIndex].Cells[1].Value = item.Producto.Precio;
                tablaConfirmarVenta.Rows[rowIndex].Cells[2].Value = item.Producto.Descripcion;
                tablaConfirmarVenta.Rows[rowIndex].Cells[3].Value = item.Cantidad;
                tablaConfirmarVenta.Rows[rowIndex].Cells[4].Value =  item.Producto.Precio * item.Cantidad ;

                

            }
            venta.calcularTotal();
            txtSubtotal.Text =  venta.total.ToString();
        }

        private void ConfirmarVenta_Load(object sender, EventArgs e)
        {

        }

        // TO DO 
        /* 
         Traer datos de cliente y poner fecha
         Hacer algo con el medio de pago ( si es tarjeta, al generar venta, le pones un form que tenga para poner datos)
         Generar PDF de Venta
         Cuadrar stock cantidad y que no se pase en la tabla de venta
         Guardar Venta en BDD, implica (descontar stock en producto)
         */

       

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void comboboxIva_SelectedIndexChanged(object sender, EventArgs e)
        {          
                decimal subTotal = Decimal.Parse(txtSubtotal.Text);
                decimal IVA = Decimal.Parse(comboboxIva.SelectedItem.ToString());
                decimal totalConIva = IVA > 0 ? (subTotal * IVA) / 100 + subTotal : subTotal;
                txtTotalConIva.Text = totalConIva.ToString();           
        }
    }
}

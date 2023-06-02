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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using iTextSharp.tool.xml;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class ConfirmarVenta : Form
    {
        private readonly Cliente _cliente;
        private readonly Venta _venta;
        private readonly Usuario _usuario;
        private readonly UserControl_Ventas _userControl_Ventas;
        public ConfirmarVenta(Venta venta, Cliente cliente, Usuario usuario, UserControl_Ventas userControl_Ventas)
        {
            InitializeComponent();
            llenarTabla(venta);
            _cliente = cliente;
            _venta = venta;
            _usuario = usuario;
            _userControl_Ventas = userControl_Ventas;
            //comboboxIva.Items.Add("0");
            //comboboxIva.Items.Add("10,5");
            //comboboxIva.Items.Add("27");
            //comboboxIva.Items.Add("21");
            
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
          * 
          *Mostrar producto por categoria y nombre
         Traer datos de cliente y poner fecha - done
         Hacer algo con el medio de pago ( si es tarjeta, al generar venta, le pones un form que tenga para poner datos)
         Generar PDF de Venta 
         Cuadrar stock cantidad y que no se pase en la tabla de venta
         Guardar Venta en BDD, implica (descontar stock en producto)
         */

       

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        //private void comboboxIva_SelectedIndexChanged(object sender, EventArgs e)
        //{          
        //        decimal subTotal = Decimal.Parse(txtSubtotal.Text);
        //        decimal IVA = Decimal.Parse(comboboxIva.SelectedItem.ToString());
        //        decimal totalConIva = IVA > 0 ? (subTotal * IVA) / 100 + subTotal : subTotal;
        //        txtTotalConIva.Text = totalConIva.ToString();           
        //}

        private void txtFinalizarVenta_Click(object sender, EventArgs e)
        {
            //TODO : Agregar la logica para crear un PDF file sobre la venta generada
            // checquear stock, actualizar tabla producto y tabla venta 

            string fileName = @"C:\HardHouse-Ventas\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginaHtml_texto = Properties.Resources.plantilla.ToString();
            paginaHtml_texto = paginaHtml_texto.Replace("@NOMBRE_CLIENTE", _cliente.Nombre);
            paginaHtml_texto = paginaHtml_texto.Replace("@DNI_CLIENTE", _cliente.Dni);
            paginaHtml_texto = paginaHtml_texto.Replace("@TIPO_CLIENTE", _cliente.Tipo == 1 ? "Consumidor Final" : "Responsable Inscripto");
            paginaHtml_texto = paginaHtml_texto.Replace("@DOCUMENTO", _cliente.Dni);
            paginaHtml_texto = paginaHtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginaHtml_texto = paginaHtml_texto.Replace("@TIPO_FACTURA", _cliente._id == 1 ? "A" : "B" );
            paginaHtml_texto = paginaHtml_texto.Replace("@NUMERO_FACTURA", GenerarNumeroComprobante(Producto_Controller.obtenerTotalDeVentas()));

            string filas = string.Empty;
            decimal total = 0;

            foreach (ItemVenta item in _venta.Items)
            {
                filas += "<tr>";
                filas += "<td>" + item.Cantidad.ToString()  + "</td>";
                filas += "<td>" + item.Producto.Precio.ToString() + "</td>";
                filas += "<td>" + item.Producto.Nombre.ToString() + "</td>";
                filas += "<td>" + item.Producto.Precio.ToString() + "</td>";
                filas += "</tr>";
                total += item.Producto.Precio * Decimal.Parse(item.Cantidad.ToString());
            }

            paginaHtml_texto = paginaHtml_texto.Replace("@FILAS", filas);
            paginaHtml_texto = paginaHtml_texto.Replace("@TOTAL_COMPRA", ((total*21)/100).ToString());


            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();



                using (StringReader sr = new StringReader(paginaHtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
                ValidatePDf(sender, e, pdfDoc);

                this.Close();
            }

        }

        private bool ValidatePDf(object sender, EventArgs e, Document pdfDoc)
        {
            if (pdfDoc.IsOpen() == false)
            {
                if (MessageBox.Show("Venta generada con exito, Desea realizar otra venta ?", "Venta Generada", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    _userControl_Ventas.CleanTable();
                }
                else
                {
                    ((FormInicio)this.Owner).buttonInicioPantalla_Click(sender, e);
                }
                return true;
            }

            MessageBox.Show("Se ha producido un error al generar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnVolverConfirmarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string GenerarNumeroComprobante(int numeroActual)
        {
            String numeroVenta = _venta.Id.ToString();
            
            string formato = "{0:D" + (9 - numeroVenta.Length) + "}";
            string numeroComprobante = string.Format(formato, numeroActual);
            return numeroComprobante;
        }
    }
}

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
using WindowsFormsApp1.DTOs;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class ConfirmarVenta : Form
    {
        private readonly Cliente _cliente;
        private readonly Venta _venta;
        private readonly Usuario _usuario;
        private readonly UserControl_Ventas _userControl_Ventas;
        private readonly EmailService _emailService;
        decimal total;
        public ConfirmarVenta(Venta venta, Cliente cliente, Usuario usuario, UserControl_Ventas userControl_Ventas, string subTotal, string totalIVA)
        {
            _emailService = new EmailService();
            InitializeComponent();
            llenarTabla(venta);
            _cliente = cliente;
            _venta = venta;
            _usuario = usuario;
            _userControl_Ventas = userControl_Ventas;
            subTotalConfirmarVenta.Text += subTotal.ToString();
            totalConfirmarVenta.Text += totalIVA.ToString();



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



        private void txtFinalizarVenta_Click(object sender, EventArgs e)
        {  
            string dateTimeNow = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            string fileName = _cliente.Nombre + "-" + dateTimeNow;
            string filePath = @"C:\HardHouse-Ventas\" + _cliente.Nombre +"-"+ dateTimeNow;

            string paginaHtml_texto = Properties.Resources.plantilla.ToString();
            paginaHtml_texto = paginaHtml_texto.Replace("@NOMBRE_CLIENTE", _cliente.Nombre);
            paginaHtml_texto = paginaHtml_texto.Replace("@DNI_CLIENTE", _cliente.Dni);
            paginaHtml_texto = paginaHtml_texto.Replace("@TIPO_CLIENTE", _cliente.Tipo == 1 ? "Consumidor Final" : "Responsable Inscripto");
            paginaHtml_texto = paginaHtml_texto.Replace("@DIRECCION", _cliente.Direccion);
            paginaHtml_texto = paginaHtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            paginaHtml_texto = paginaHtml_texto.Replace("@TIPO_FACTURA", _cliente.Tipo == 1 ? "B" : "A" );
            paginaHtml_texto = paginaHtml_texto.Replace("@VENDEDOR", _usuario.UserName);
            paginaHtml_texto = paginaHtml_texto.Replace("@NUMERO_FACTURA", GenerarNumeroComprobante(Producto_Controller.obtenerTotalDeVentas()));

            string filas = string.Empty;
             total = 0;

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

            total = (total * 121) / 100;

            paginaHtml_texto = paginaHtml_texto.Replace("@FILAS", filas);
            paginaHtml_texto = paginaHtml_texto.Replace("@TOTAL_COMPRA", total.ToString());


            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                pdfDoc.Open();

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoAppHardware, System.Drawing.Imaging.ImageFormat.Png);

                img.ScaleToFit(80, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);

                pdfDoc.Add(img);

                using (StringReader sr = new StringReader(paginaHtml_texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();

                ValidatePDf(sender, e, pdfDoc);
                EnviarEmailConPDf(filePath, fileName);

                this.Close();
            }

        }

        private void EnviarEmailConPDf(string attachmentFilePath, string attachmentFileName)
        {
            Email email = new Email()
            {
                apiKey = "",
                fromEmail = "",
                toEmail = _cliente.Email,
                subject = "Venta Generada con exito",
                plainTextContent = $"Tu compra de en HardHouse ha sido realizada con exito. Muchas gracias",
                htmlContent = $"<p>La compra  ha sido <strong>Exitosa</strong>.</p>"
            };
            _emailService.SendEmail(email, attachmentFilePath, attachmentFileName);
        }

        private bool ValidatePDf(object sender, EventArgs e, Document pdfDoc)
        {
            if (pdfDoc.IsOpen() == false)
            {
                //Guardar Venta en base de datos
                VentaDTO venta = new VentaDTO()
                {
                    fecha = DateTime.Now,
                    total = total,
                    cliente = _cliente._id,
                    vendedor = _usuario._id
                };

                Venta_Controller.agregarVenta(venta);

                //guardar item ventas en la base de datos
                foreach (ItemVenta item in _venta.Items)
                {
                    ItemVentaDTO itemVenta = new ItemVentaDTO()
                    {
                        cantidad = item.Cantidad,
                        id_producto = item.Producto.Id,
                    };

                    if(itemVenta != null)
                    {
                        Item_Venta_Controller.agregarItemVenta(itemVenta);
                    }
                }
                //

                //actualizar el stock
                foreach (ItemVenta item in _venta.Items)
                {
                    int nuevoStock = item.Producto.Stock - item.Cantidad;
                    
                    Producto_Controller.actualizarStock(nuevoStock, item.Producto.Id);

                }
                //

                if (MessageBox.Show("Venta generada con exito, Desea realizar otra venta ?", "Venta Generada", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                   
                    //if(_emailService.SendEmail(email).Result)
                    //{
                    //    MessageBox.Show("Hemos enviado un mail a tu correo", "Mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

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

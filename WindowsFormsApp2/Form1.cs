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
using WindowsFormsApp2.Controladores;
using WindowsFormsApp2.Modelos;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int DEBUG_MODE = 1;
        
        public string situacion;

        public Form1()
        {
            InitializeComponent();
            error_nombre.Hide();
            lbl_eror_id.Hide();
            lbl_error_desc.Hide();

            situacion = "crear";
        }

        public Form1(Producto prod)
        {
            InitializeComponent();
            error_nombre.Hide();
            lbl_eror_id.Hide();
            lbl_error_desc.Hide();

            txt_Id.Text = prod.Id.ToString();
            txt_Id.Enabled = false;
            txt_Descripcion.Text = prod.Descripcion;
            txt_nombre.Text = prod.Nombre;
            btn_crear.Text = "Actualizar producto";

            situacion = "editar";
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

            if (situacion  == "crear")
            {
                bool inputsValidos = validarInputs(out string errorMsg);

                Trace.WriteLine("inputs validados con resultado: " + inputsValidos);

                if (inputsValidos)
                {

                    if (DEBUG_MODE == 1 || DEBUG_MODE == 2)
                    {
                        Trace.WriteLine("inputs validados");
                    }
                    Producto prod = new Producto(int.Parse(txt_Id.Text), txt_nombre.Text, txt_Descripcion.Text, true);

                    if (Producto_Controlador.crearProducto(prod))
                    {
                        Trace.WriteLine("Producto Creado con exito");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Trace.WriteLine("Fallo la creacion del producto");
                    }

                }
                else
                {
                    if (DEBUG_MODE == 1 || DEBUG_MODE == 2)
                    {
                        Trace.WriteLine(errorMsg);
                    }
                }
            }
            else
            {

                if (Producto_Controlador.editarProducto(new Producto(int.Parse(txt_Id.Text), txt_nombre.Text, txt_Descripcion.Text, true)))
                {
                    Trace.WriteLine("Producto Actualizado con exito");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Trace.WriteLine("Fallo la actualizacion del producto");
                }

            }

        }

        private bool validarInputs(out string errorMsg)
        {
            errorMsg = String.Empty;

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg += "Debe indicar el nombre del producto. " + Environment.NewLine;
                error_nombre.Text = "Debe indicar el nombre del producto.";
                error_nombre.Show();
            }
            if (string.IsNullOrEmpty(txt_Descripcion.Text))
            {
                errorMsg += "Debe indicar la descripcion del producto. " + Environment.NewLine;
                lbl_error_desc.Text = "Debe indicar la descripcion del producto. ";
                lbl_error_desc.Show();
            }
            if (string.IsNullOrEmpty(txt_Id.Text))
            {
                errorMsg += "Debe indicar el id del producto. " + Environment.NewLine;
                lbl_eror_id.Text = "Debe indicar el id del producto. ";
                lbl_eror_id.Show();
            }

            return errorMsg == String.Empty;

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            error_nombre.Hide();
            validarInputs(out string errorMsg);
        }

        private void txt_Descripcion_TextChanged_1(object sender, EventArgs e)
        {
            lbl_error_desc.Hide();
            validarInputs(out string errorMsg);
        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            lbl_eror_id.Hide();
            validarInputs(out string errorMsg);
        }
    }
}

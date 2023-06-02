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
    public partial class FormCategoria : Form
    {
        private int actionGlobal = 1;
        private long idGlboal = 0;
        public FormCategoria(int action, long id)
        {
            InitializeComponent();
            txtCategoriaPadre.Items.Add("---Categoria padre---");
            List<Categoria> lista = Categoria_Controller.obtenerTodas();
            foreach (Categoria c in lista)
            {
                txtCategoriaPadre.Items.Add(c.Nombre);
                foreach (Categoria subcat in c.subcategorias)
                {
                    txtCategoriaPadre.Items.Add(subcat.Nombre);
                }
            }
            if (action == 1)
            {
                actionGlobal = 1;
                label1.Text = "Agregar Categoria";
                txtAgregarCategoria.Text = "Agregar Categoria";
                btnActiva.Checked = true;
                txtCategoriaPadre.SelectedIndex = 0;

            }
            else
            {
                idGlboal = id;
                actionGlobal = 0;

                txtAgregarCategoria.Text = "Editar Categoria";
            label1.Text = "Editar categoria";
                Categoria catToEdit = Categoria_Controller.findById(id);
                txtNombreCategoria.Text = catToEdit.Nombre;
                /*                txtCategoriaPadre.SelectedItem = catToEdit.Padre == -1 ? txtCategoriaPadre.Items[0] : Categoria_Controller.findById(catToEdit.Padre).Nombre;
                */
                if (catToEdit.Padre == -1)
                {
                    txtCategoriaPadre.SelectedItem = txtCategoriaPadre.Items[0];
                }
                else
                {
                    for (int i = 1; i < txtCategoriaPadre.Items.Count; i++)
                    {

                        if (txtCategoriaPadre.Items[i].ToString().Equals(Categoria_Controller.findById(catToEdit.Padre).Nombre))
                        {
                            txtCategoriaPadre.SelectedItem = txtCategoriaPadre.Items[i];
                        }
                    }
                }
                if ( !catToEdit.Activo)
                {
                    btnInactiva.Checked = true;
                    btnActiva.Checked = false;
                } else
                {
                    btnInactiva.Checked = false;
                    btnActiva.Checked = true;
                }
            }
           

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAgregarCategoria_Click(object sender, EventArgs e)
        {
            String[] campos = {txtNombreCategoria.Text, txtCategoriaPadre.SelectedItem.ToString(), btnActiva.Checked ? "1" : "0" };


            if( campos.All(campo => campo.Length > 0))
            {
                Categoria catToAdd =  new Categoria();
                catToAdd.Nombre = campos[0];
                catToAdd.Padre = campos[1].Equals("---Categoria padre---") ?  -1 : Categoria_Controller.findByName(campos[1]).Id;
                catToAdd.Activo = campos[2].Equals("1") ? true : false;            
                if (actionGlobal >  0)
                {
                    if (Categoria_Controller.addCategoria(catToAdd)){
                        MessageBox.Show("Categoria agregada exitosamente.", "Form categoria");
                        txtCategoriaError.Visible = false;
                        this.Close();
                    }

                }
                else
                {
                    if(Categoria_Controller.actualizarCategoria(idGlboal, catToAdd))
                    {
                        MessageBox.Show("Categoria editada exitosamente.", "Form categoria");
                        txtCategoriaError.Visible = false;
                        this.Close();
                    }
                }
                
            }
            else
            {
                txtCategoriaError.Visible = true;
            }
        }
    }
}

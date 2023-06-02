using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Models.Graficos;

namespace WindowsFormsApp1.UserControls
{
    public partial class UserControl_Inicio : UserControl
    {
        public UserControl_Inicio()
        {
            InitializeComponent();
            List<GraficoCategoriaBestSellerModel> lista = Venta_Controller.getListaGraficoBestSeller();

            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("Ventas Por Categoría");
            int count = 0;
            foreach( GraficoCategoriaBestSellerModel item in lista)
            {
                Series serie = chart1.Series.Add(item.NombreCategoria);
                serie.Label = item.CantidadDeVentas.ToString();
                serie.Points.Add(item.CantidadDeVentas);
            }
            List<GraficoProductoBestSellerModel> lista2 = Venta_Controller.getListaGraficoProductoBestSeller();
            chart2.Titles.Add("Productos Mas Vendidos");
            foreach (GraficoProductoBestSellerModel item2 in lista2)
            {
                chart2.Series[0].Points.AddXY(item2.NombreProducto , item2.CantidadDeVentas);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}

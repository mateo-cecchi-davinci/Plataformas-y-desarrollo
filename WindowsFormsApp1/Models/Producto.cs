using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
        public int Categoria { get; set; }
        public string Imagen { get; set; }


    }
}

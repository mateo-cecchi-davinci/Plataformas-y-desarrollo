using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public bool Activo { get; set; }

        public Producto(int id, string nombre, string descripcion, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
        }

        public Producto()
        {

        }


    }
}

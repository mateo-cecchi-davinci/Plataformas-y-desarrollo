using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Cliente
    {
        public long _id { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; } 
        public string Email { get; set; }
        public string Direccion { get; set; }

        public int Tipo { get; set; }

        public Cliente (string nombre, string direccion, string dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
            this.Direccion = direccion;
        }

        public Cliente()
        {

        }
    }
}

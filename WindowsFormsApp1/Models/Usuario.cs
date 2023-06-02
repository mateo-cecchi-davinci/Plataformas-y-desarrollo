using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Usuario
    {

        public long _id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string UserName { get; set; }
        public string Contraseña { get; set; }
        public bool Admin { get; set; }
        public bool Activo { get; set; }

        public byte[] Imagen { get; set; } 

        public Usuario(long id, string name, string apellido, string dni, string userName, string contraseña, bool admin, bool activo, byte[] imagen)
        {
            _id = id;
            Name = name;
            Apellido = apellido;
            Dni = dni;
            UserName = userName;
            Contraseña = contraseña;
            Admin = admin;
            Activo = activo;
            Imagen = imagen;
        }

        public Usuario()
        {
        }

       
    }
    
}

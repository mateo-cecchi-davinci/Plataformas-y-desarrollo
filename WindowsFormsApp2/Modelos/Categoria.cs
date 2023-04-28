using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }

        public String Nombre { get; set; }
        
        public Categoria padre{ get; set; }

        public bool Activo { get; set; }

        public Categoria()
        {

        }
    }
}

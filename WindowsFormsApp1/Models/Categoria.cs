using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Categoria
    {
       public long Id { get; set; }
        public string Nombre { get; set; }
       public long Padre { get; set; }

        public List<Categoria> subcategorias { get; set; }
        public Boolean Activo { get; set; }

        public Categoria()
        {
        }
    }
}

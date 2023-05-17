using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ItemVenta
    {
        public long Id { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
    }
}

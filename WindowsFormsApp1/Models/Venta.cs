using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Venta
    {
        public long Id { get; set; }
        public List<ItemVenta> Items { get; set; }
        public decimal total { get; set; }
        public long cliente { get; set; }
        public long vendedor { get; set; }

        public DateTime fecha { get; set; }


        public Venta() { 
            this.total = 0;
            this.Items = new List<ItemVenta>();
        }

        public void calcularTotal()
        {
            foreach (ItemVenta item in Items) {

                total += item.Producto.Precio * item.Cantidad;

            }
        }
    }
}

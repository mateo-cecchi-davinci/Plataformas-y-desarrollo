using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTOs
{
    public class VentaDTO
    {
        public decimal total { get; set; }
        public long cliente { get; set; }
        public long vendedor { get; set; }
        public DateTime fecha { get; set; }
    }
}

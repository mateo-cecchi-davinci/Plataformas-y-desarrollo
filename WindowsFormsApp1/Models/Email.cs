using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Email
    {
        public string apiKey { get; set; }

        public string fromEmail { get; set; }

        public string toEmail { get; set; }

        public string subject { get; set; }

        public string plainTextContent { get; set; }

        public string htmlContent { get; set; }
    }
}

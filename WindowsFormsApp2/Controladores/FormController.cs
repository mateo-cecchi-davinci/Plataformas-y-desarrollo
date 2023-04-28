using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Controladores
{
    public class FormController
    {
        private static Index _index;

        public static Index Index
        {
            get
            {
                if(_index == null)
                {
                    _index = new Index();
                }
                return _index;
            }
        }



    }
}

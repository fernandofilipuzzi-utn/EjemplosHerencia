using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class C:B
    {
        public string Valor { get; set; }
        public string AtributoC { get; set; }

        override public void CrearValor()
        {
            base.CrearValor();
            Valor = "C";
            AtributoC = "c";
        }
    }
}

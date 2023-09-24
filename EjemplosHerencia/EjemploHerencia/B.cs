using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class B:A
    {
        public string AtributoB { get; set; }

        override public void CrearValor()
        {
            base.CrearValor();
            Valor = "B";
            AtributoB = "b";
        }
    }
}

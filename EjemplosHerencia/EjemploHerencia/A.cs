using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class A
    {
        public string Valor { get; set; }
        public string AtributoA { get; set; }

        virtual public void CrearValor()
        {
            Valor = "A";
            AtributoA = "a";
    }
    }
}

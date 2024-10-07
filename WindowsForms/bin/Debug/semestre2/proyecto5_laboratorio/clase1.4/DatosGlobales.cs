using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1._4
{
    internal class DatosGlobales
    {
        public struct RegistroCliente
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }
        static public RegistroCliente[] Clientes = new RegistroCliente[100];
        static public int i;
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_LAB2
{
    internal class DatosGlobales
    {
        public struct RegVendedores
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Sueldo;
        }
        static public RegVendedores[] Vendedores = new RegVendedores[100];
        static public int IND;
    }
}

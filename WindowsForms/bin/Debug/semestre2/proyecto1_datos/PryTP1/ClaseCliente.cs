using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryTP1
{
    internal class ClaseCliente: ClasePersona
    {
        private decimal cmpCodigo;
        private decimal cmpDeuda;

        public void Comprar(decimal importe)
        {
            cmpDeuda = cmpDeuda + importe;
        }

        public void Pagar(decimal importe)
        {
            cmpDeuda = cmpDeuda - importe;
        }
        public decimal Codigo
        {
            get { return cmpCodigo; }
            set { Codigo = cmpCodigo; }
        }
        public decimal Deuda
        {
            get { return cmpDeuda; }
            set { Deuda = cmpDeuda; }
        }
    }
}

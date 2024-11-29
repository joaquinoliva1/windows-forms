using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDinamicas
{
    class Nodo
    {
        private Int32 cod;
        private string nom;
        private string tra;
        private Nodo sig;
        private Nodo ant;

        public Int32 Codigo { get { return cod; } set { cod = value; } }
        public string Nombre { get { return nom; } set { nom = value; } }
        public string Tramite { get { return tra; } set { tra = value; } }
        public Nodo Siguiente { get { return sig; } set { sig = value; } }
        public Nodo Anterior { get { return ant; } set { ant = value; } }
        public Nodo Derecho { get { return sig; } set { sig = value; } }
        public Nodo Izquierdo { get { return ant; } set { ant = value; } }

    }
}

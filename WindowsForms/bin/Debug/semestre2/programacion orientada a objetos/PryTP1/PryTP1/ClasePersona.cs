using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PryTP1
{
    internal class ClasePersona
    {
        private string cmpNombre;
        private string cmpApellido;
        private string cmpDireccion;
        private string cmpCiudad;

        private string Nombre
        {
            get { return Nombre; }
            set { Nombre = cmpNombre; }
        }
        private string Apellido
        {
            get { return Apellido; }
            set { Apellido = cmpApellido; }
        }
        private string Direccion
        {
            get { return Direccion; }
            set { Direccion = cmpDireccion; }
        }
        private string Ciudad
        {
            get { return Ciudad; }
            set { Ciudad = cmpCiudad; }
        }
    }
}

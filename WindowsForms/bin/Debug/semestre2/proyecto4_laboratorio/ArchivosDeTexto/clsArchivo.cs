using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//IO: Imput, Output (escritura y lectura de datos).
//este espacio de nombre nos permite empezar a programar el método Grabar().
using System.Windows.Forms;
using System.Drawing;
//incorporamos las librerías que nos permiten procesar elementos de los formularios de Windows.
//hacemos esto para poder procesar el elemento lstDatos desde esta clase.

namespace ArchivosDeTexto
{
    internal class clsArchivo
    {
        public string NombreArchivo = "Palabras.txt";
        //este string va a contener el nombre del archivo que va a contener nuestros datos.
        int veces=0;
        public void Grabar(string valor)//este método nos van a permitir escribir y leer en un archivo.
        {
            if (veces==0)
            {
                //utilizando el valor booleano true hacemos referencia a escribir sobre un mismo archivo.
                StreamWriter AD = new StreamWriter(NombreArchivo, false); //ABRIR: instanciar AD con la clase StreamWriter.
                AD.WriteLine("LISTA DE DATOS");
                //GRABAR: instrucción de grabar sobre el archivo, se puede grabar muchas veces.
                AD.Close(); //CERRAR: el agregado de datos.
                AD.Dispose(); //liberar el objeto de la memoria RAM, para que no ocupe espacio.
                veces++;
            }
            else
            {
                StreamWriter AD = new StreamWriter(NombreArchivo, true);
                AD.WriteLine(valor); //GRABAR
                AD.Close(); //CERRAR
                AD.Dispose(); //LIBERAR
            }
        }
        public void Listar(ListBox lista) //este método es para listar en lstDatos, aquellos datos previamente grabados.
        {
            lista.Items.Clear(); //eliminamos los ítems previamente agregados para listar los nuevos.
            //a diferencia de los anteriores métodos, debemos depositar el valor de cada línea adentro de una variable string:
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NombreArchivo, false); //ABRIR agregado de datos
            //para leer todo el archivo debemos repetir la lectura, ya que esta es secuencial.
            //en cada lectura leeremos una línea, posterior a esto lo mostraremos en lstDatos.
            while (DatoLeido != null)
            {
                lista.Items.Add(DatoLeido); //colocamos el dato leído adentro del objeto lista.
                DatoLeido = AD.ReadLine(); //LEER agregado de datos, asignándole el valor de la línea a la variable que creamos.
            }
            AD.Close(); //CERRAR
            AD.Dispose(); //LIBERAR
        }
    }
}

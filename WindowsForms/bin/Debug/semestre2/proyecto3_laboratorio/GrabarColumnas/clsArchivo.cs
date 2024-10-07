using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace GrabarColumnas
{
    internal class clsArchivo
    {
        public string archivo = "clientes.csv";
        public int habilitar = 0;
        public int cantidad = 0;
        public decimal total = 0;
        public struct registro_clientes
        {
            public int codigo;
            public string nombre;
            public decimal deuda;
            public decimal limite;
        }
        private registro_clientes[] vector_clientes = new registro_clientes[1000];
        private int ind = 0;
        private void cargar_vector()
        {
            string datos_leidos = "";
            string[] vector_datos = new string[4];
            ind = 0;
            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                vector_clientes[ind].codigo = Convert.ToInt32(vector_datos[0]);
                vector_clientes[ind].nombre = vector_datos[1];
                vector_clientes[ind].deuda = Convert.ToDecimal(vector_datos[2]);
                vector_clientes[ind].limite = Convert.ToDecimal(vector_datos[3]);
                ind++;
                datos_leidos = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        private void ordenar_vector()
        {
            registro_clientes aux; //declaración de variable auxiliar de tipo registro_clientes
            for (int c = 0; c < ind - 1; c++) //repetitiva que lee cada fila
            {
                for (int i = 0; i < ind - 1; i++) //repetitiva que lee cada columna de la fila
                {
                    if (vector_clientes[i].codigo > vector_clientes[i+1].codigo) //condición que reordena el vector
                    {//la condición es que el código sea mayor al siguiente, para ordenarlo de menor a mayor
                        aux = vector_clientes[i];
                        vector_clientes[i] = vector_clientes[i + 1];
                        vector_clientes[i + 1] = aux;
                    }
                }
            }
        }
        private void reescribir_archivo()
        {
            StreamWriter agregado = new StreamWriter(archivo, false);
            for (int i = 0; i < ind; i++) //cargar datos del vector en el archivo
            {
                agregado.Write(vector_clientes[i].codigo);
                agregado.Write(";");
                agregado.Write(vector_clientes[i].nombre);
                agregado.Write(";");
                agregado.Write(vector_clientes[i].deuda);
                agregado.Write(";");
                agregado.WriteLine(vector_clientes[i].limite);
            }
            agregado.Close();
            agregado.Dispose();
        }
        public void ordenar_datos()
        {
            cargar_vector();//pasar datos al vector
            ordenar_vector();//ordenar el vector
            reescribir_archivo();//pasar datos ordenados al archivo
        }
        public void grabar(string codigo, string nombre, string deuda, string limite)
        {
            StreamWriter agregado = new StreamWriter(archivo, true); //componente booleano: existencia del archivo
            
            //para asignar valores a cada columna del archivo creado:
            agregado.Write(codigo); //primer dato
            agregado.Write(";"); //separador de campos
            agregado.Write(nombre);
            agregado.Write(";");
            agregado.Write(deuda);
            agregado.Write(";");
            agregado.WriteLine(limite); //ultimo dato
            //este proceso se repite en cada click del botón cargar
            //es necesario escribir WriteLine para que el próximo procedimiento escriba los datos en otra línea

            agregado.Close();
            agregado.Dispose();
        }
        public void listar(DataGridView datos)
        {
            habilitar = 0;
            string datos_leidos = ""; //creamos una variable donde almacenar los datos
            string[] vector_datos = new string[4]; //creamos un vector para que visual pueda interpretar los datos
            datos.Rows.Clear(); //limpiamos la grilla
            StreamReader agregado = new StreamReader(archivo); //abrimos el agregado de datos o archivo clientes.csv
            datos_leidos = agregado.ReadLine(); //le asignamos a la variable creada, el valor de la primer línea del agregado
            while (datos_leidos != null) //creamos una repetitiva que cargará cada línea del archivo y la agregará a la grilla
            {
                vector_datos = datos_leidos.Split(';'); //interpreta los separadores de campo
                datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3]);
                datos_leidos = agregado.ReadLine(); //leer el archivo nuevamente hasta que datos_leidos sea nulo
                //la última línea del archivo es nula
                //la repetitiva finaliza cuando se lee todo el agregado.
            }
            agregado.Close();
            agregado.Dispose();
        }
        public void listar_deudas(DataGridView datos)
        {
            habilitar = 1;
            string datos_leidos = "";
            string[] vector_datos = new string[4];
            datos.Rows.Clear();
            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null) 
            {
                vector_datos = datos_leidos.Split(';');
                if (int.Parse(vector_datos[2]) > 0)
                {
                    datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3]);
                }
                datos_leidos = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public int cantidad_clientes() //FUNCIÓN: sirve para realizar un procedimiento que retorne un valor:
        {
            int cantidad = 0;
            int solo_deuda = 0;
            string datos_leidos = "";
            string[] vector_datos = new string[4];
            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while(datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                if (int.Parse(vector_datos[2]) > 0)
                {
                    solo_deuda++;
                }
                cantidad++;
                datos_leidos = agregado.ReadLine();
            }
            agregado.Close(); //recordar cerrar el agregado de datos para evitar cruce de procesos.
            agregado.Dispose();
            if (habilitar==0)
            {
                return cantidad;
            }
            else
            {
                return solo_deuda;
            }
        }
        public float total_deuda()
        {
            float deuda = 0;
            string datos_leidos = "";
            string[] vector_datos = new string[4]; //se declara un vector para acumular determinados datos de la línea.
            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';'); //se utiliza nuevamente el Split.
                deuda = deuda + float.Parse(vector_datos[2]); //acumulamos el dato de la posición 2 del vector.
                datos_leidos = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return deuda;
        }
        public float promedio_deuda()
        {
            float deuda = 0;
            float cantidad = 0;
            float promedio = 0;
            string datos_leidos = "";
            string[] vector_datos = new string[4];
            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                cantidad++;
                deuda = deuda + float.Parse(vector_datos[2]);
                datos_leidos = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            promedio = deuda / cantidad;
            return promedio;
        }
        public void generar_reporte()
        {
            string datos_leidos = "";
            string[] vector_datos = new string[4];

            StreamWriter reporte = new StreamWriter("reporte.csv", false, Encoding.UTF8); 
            //primero generamos un nuevo archivo
            //nótese UTF8: esta instrucción hace que los acentos sea vean como tal
            reporte.WriteLine("Listado de clientes"); //título del reporte
            reporte.WriteLine("");
            reporte.WriteLine("Cóigo;Nombre;Deuda;Límite"); //titulos de columnas

            StreamReader agregado = new StreamReader(archivo);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                reporte.Write(vector_datos[0]);
                reporte.Write(";"); //excel interpreta ";" como separador de campo.
                reporte.Write(vector_datos[1]);
                reporte.Write(";");
                reporte.Write(vector_datos[2]);
                reporte.Write(";");
                reporte.WriteLine(vector_datos[3]);
                cantidad++;
                total = total + Convert.ToDecimal(vector_datos[2]);
                datos_leidos = agregado.ReadLine();
            }
            reporte.WriteLine("");
            reporte.WriteLine("Cantidad de clientes:;;;" + cantidad);
            reporte.WriteLine("Total de deuda:;;;" + total);
            reporte.Write("Promedio de deuda:;;;" + total / cantidad);
            agregado.Close();
            agregado.Dispose();
            reporte.Close();
            reporte.Dispose();
        }
    }
}

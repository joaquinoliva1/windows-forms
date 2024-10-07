using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tp2_lab2
{
    internal class clsMetodos
    {
        public string rubros = "RUBROS.csv";
        public string articulos = "ARTICULOS.csv";
        public void combox(ComboBox lista)
        {
            lista.Items.Clear();
            string DatoLeido;
            StreamReader agregado = new StreamReader(rubros);
            DatoLeido = agregado.ReadLine();
            while (DatoLeido != null)
            {
                lista.Items.Add(DatoLeido);
                DatoLeido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public void listar(DataGridView datos)
        {
            string dato_leido;
            Decimal valor_stock;
            string[] vector_datos = new string[6];
            datos.Rows.Clear();
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3], vector_datos[4], valor_stock);
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public Decimal label_cantidad()
        {
            Decimal cantidad = 0;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                cantidad = cantidad + Convert.ToDecimal(vector_datos[4]);
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return cantidad;
        }
        public Decimal label_total()
        {
            Decimal total = 0;
            string dato_leido;
            Decimal valor_stock;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                total = total + valor_stock;
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return total;
        }
        public void mostrar_repuestos(DataGridView datos)
        {
            string dato_leido;
            Decimal valor_stock;
            string[] vector_datos = new string[6];
            datos.Rows.Clear();
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Repuesto")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3], vector_datos[4], valor_stock);
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public void mostrar_accesorios(DataGridView datos)
        {
            string dato_leido;
            Decimal valor_stock;
            string[] vector_datos = new string[6];
            datos.Rows.Clear();
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Accesorio")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3], vector_datos[4], valor_stock);
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public void mostrar_insumos(DataGridView datos)
        {
            string dato_leido;
            Decimal valor_stock;
            string[] vector_datos = new string[6];
            datos.Rows.Clear();
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Insumo")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    datos.Rows.Add(vector_datos[0], vector_datos[1], vector_datos[2], vector_datos[3], vector_datos[4], valor_stock);
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
        }
        public Decimal repuesto_cantidad()
        {
            Decimal cantidad = 0;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Repuesto")
                {
                    cantidad = cantidad + Convert.ToDecimal(vector_datos[4]);
                    
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return cantidad;
        }
        public Decimal repuesto_total()
        {
            Decimal total = 0;
            Decimal valor_stock;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Repuesto")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    total = total + valor_stock;
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return total;
        }
        public Decimal accesorio_cantidad()
        {
            Decimal cantidad = 0;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Accesorio")
                {
                    cantidad = cantidad + Convert.ToDecimal(vector_datos[4]);
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return cantidad;
        }
        public Decimal accesorio_total()
        {
            Decimal total = 0;
            Decimal valor_stock;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Accesorio")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    total = total + valor_stock;
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return total;
        }
        public Decimal insumo_cantidad()
        {
            Decimal cantidad = 0;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Insumo")
                {
                    cantidad = cantidad + Convert.ToDecimal(vector_datos[4]);
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return cantidad;
        }
        public Decimal insumo_total()
        {
            Decimal total = 0;
            Decimal valor_stock;
            string dato_leido;
            string[] vector_datos = new string[6];
            StreamReader agregado = new StreamReader(articulos);
            dato_leido = agregado.ReadLine();
            while (dato_leido != null)
            {
                vector_datos = dato_leido.Split(';');
                if (vector_datos[3] == "Insumo")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    total = total + valor_stock;
                }
                dato_leido = agregado.ReadLine();
            }
            agregado.Close();
            agregado.Dispose();
            return total;
        }
        public void exportar()
        {
            int cantidad = 0;
            decimal total = 0;
            string datos_leidos = "";
            decimal valor_stock = 0;
            string[] vector_datos = new string[6];
            StreamWriter lista = new StreamWriter("ARCHIVO_EXPORTADO.csv", false, Encoding.UTF8);
            lista.WriteLine("Lista de artículos");
            lista.WriteLine("");
            lista.WriteLine("Código;Descripción;Costo;Rubro;Stock;Valor en stock");
            StreamReader agregado = new StreamReader(articulos);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                lista.Write(vector_datos[0]);
                lista.Write(";");
                lista.Write(vector_datos[1]);
                lista.Write(";");
                lista.Write(vector_datos[2]);
                lista.Write(";");
                lista.Write(vector_datos[3]);
                lista.Write(";");
                lista.Write(vector_datos[4]);
                lista.Write(";");
                lista.WriteLine(valor_stock);
                cantidad = cantidad + Convert.ToInt32(vector_datos[4]);
                total = total + valor_stock;
                datos_leidos = agregado.ReadLine();
            }
            lista.WriteLine("");
            lista.WriteLine("Cantidad de articulos:;;;;;" + cantidad);
            lista.WriteLine("Valor total:;;;;;" + total);
            agregado.Close();
            agregado.Dispose();
            lista.Close();
            lista.Dispose();
            Process abrir = new Process();
            abrir.StartInfo.FileName = "ARCHIVO_EXPORTADO.csv";
            abrir.Start();
        }
        public void exportar_repuesto()
        {
            int cantidad = 0;
            decimal total = 0;
            string datos_leidos = "";
            decimal valor_stock = 0;
            string[] vector_datos = new string[6];
            StreamWriter lista = new StreamWriter("ARCHIVO_EXPORTADO.csv", false, Encoding.UTF8);
            lista.WriteLine("Lista de artículos");
            lista.WriteLine("Categoría: REPUESTOS");
            lista.WriteLine("");
            lista.WriteLine("Código;Descripción;Costo;Rubro;Stock;Valor en stock");
            StreamReader agregado = new StreamReader(articulos);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                if (vector_datos[3]=="Repuesto")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    lista.Write(vector_datos[0]);
                    lista.Write(";");
                    lista.Write(vector_datos[1]);
                    lista.Write(";");
                    lista.Write(vector_datos[2]);
                    lista.Write(";");
                    lista.Write(vector_datos[3]);
                    lista.Write(";");
                    lista.Write(vector_datos[4]);
                    lista.Write(";");
                    lista.WriteLine(valor_stock);
                    cantidad = cantidad + Convert.ToInt32(vector_datos[4]);
                    total = total + valor_stock;
                }
                datos_leidos = agregado.ReadLine();
            }
            lista.WriteLine("");
            lista.WriteLine("Cantidad de articulos:;;;;;" + cantidad);
            lista.WriteLine("Valor total:;;;;;" + total);
            agregado.Close();
            agregado.Dispose();
            lista.Close();
            lista.Dispose();
            Process abrir = new Process();
            abrir.StartInfo.FileName = "ARCHIVO_EXPORTADO.csv";
            abrir.Start();
        }
        public void exportar_accesorio()
        {
            int cantidad = 0;
            decimal total = 0;
            string datos_leidos = "";
            decimal valor_stock = 0;
            string[] vector_datos = new string[6];
            StreamWriter lista = new StreamWriter("ARCHIVO_EXPORTADO.csv", false, Encoding.UTF8);
            lista.WriteLine("Lista de artículos");
            lista.WriteLine("Categoría: ACCESORIOS");
            lista.WriteLine("");
            lista.WriteLine("Código;Descripción;Costo;Rubro;Stock;Valor en stock");
            StreamReader agregado = new StreamReader(articulos);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                if (vector_datos[3] == "Accesorio")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    lista.Write(vector_datos[0]);
                    lista.Write(";");
                    lista.Write(vector_datos[1]);
                    lista.Write(";");
                    lista.Write(vector_datos[2]);
                    lista.Write(";");
                    lista.Write(vector_datos[3]);
                    lista.Write(";");
                    lista.Write(vector_datos[4]);
                    lista.Write(";");
                    lista.WriteLine(valor_stock);
                    cantidad = cantidad + Convert.ToInt32(vector_datos[4]);
                    total = total + valor_stock;
                }
                datos_leidos = agregado.ReadLine();
            }
            lista.WriteLine("");
            lista.WriteLine("Cantidad de articulos:;;;;;" + cantidad);
            lista.WriteLine("Valor total:;;;;;" + total);
            agregado.Close();
            agregado.Dispose();
            lista.Close();
            lista.Dispose();
            Process abrir = new Process();
            abrir.StartInfo.FileName = "ARCHIVO_EXPORTADO.csv";
            abrir.Start();
        }
        public void exportar_insumo()
        {
            int cantidad = 0;
            decimal total = 0;
            string datos_leidos = "";
            decimal valor_stock = 0;
            string[] vector_datos = new string[6];
            StreamWriter lista = new StreamWriter("ARCHIVO_EXPORTADO.csv", false, Encoding.UTF8);
            lista.WriteLine("Lista de artículos");
            lista.WriteLine("Categoría: INSUMOS");
            lista.WriteLine("");
            lista.WriteLine("Código;Descripción;Costo;Rubro;Stock;Valor en stock");
            StreamReader agregado = new StreamReader(articulos);
            datos_leidos = agregado.ReadLine();
            while (datos_leidos != null)
            {
                vector_datos = datos_leidos.Split(';');
                if (vector_datos[3] == "Insumo")
                {
                    valor_stock = Convert.ToDecimal(vector_datos[2]) * Convert.ToDecimal(vector_datos[4]);
                    lista.Write(vector_datos[0]);
                    lista.Write(";");
                    lista.Write(vector_datos[1]);
                    lista.Write(";");
                    lista.Write(vector_datos[2]);
                    lista.Write(";");
                    lista.Write(vector_datos[3]);
                    lista.Write(";");
                    lista.Write(vector_datos[4]);
                    lista.Write(";");
                    lista.WriteLine(valor_stock);
                    cantidad = cantidad + Convert.ToInt32(vector_datos[4]);
                    total = total + valor_stock;
                }
                datos_leidos = agregado.ReadLine();
            }
            lista.WriteLine("");
            lista.WriteLine("Cantidad de articulos:;;;;;" + cantidad);
            lista.WriteLine("Valor total:;;;;;" + total);
            agregado.Close();
            agregado.Dispose();
            lista.Close();
            lista.Dispose();
            Process abrir = new Process();
            abrir.StartInfo.FileName = "ARCHIVO_EXPORTADO.csv";
            abrir.Start();
        }
    }
}

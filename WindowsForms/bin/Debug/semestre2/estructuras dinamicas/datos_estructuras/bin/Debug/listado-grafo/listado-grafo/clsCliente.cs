using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listado_grafo
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private string Tabla = "Cliente";

        private decimal deuda;
        private Int32 cantidad;
        private decimal promedio;

        public void Listar(DataGridView Grilla, int ciudad, int tipo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader dr = comando.ExecuteReader();
                clsCiudad ciu = new clsCiudad();
                string nombre_ciudad = "";
                if (dr.HasRows)
                {
                    if (ciudad == 0)
                    {
                        while (dr.Read())
                        {
                            switch (tipo)
                            {
                                case 0:
                                    nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                    Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                    break;
                                case 1:
                                    if (dr.GetDecimal(2) > 0)
                                    {
                                        nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                    }
                                    break;
                                case 2:
                                    if (dr.GetDecimal(2) == 0)
                                    {
                                        nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        while (dr.Read())
                        {
                            if (dr.GetInt32(4) == ciudad)
                            {
                                switch (tipo)
                                {
                                    case 0:
                                        nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                        break;
                                    case 1:
                                        if (dr.GetDecimal(2) > 0)
                                        {
                                            nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                            Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                        }
                                        break;
                                    case 2:
                                        if (dr.GetDecimal(2) == 0)
                                        {
                                            nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                            Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3), dr.GetDecimal(2));
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Reporte(DataGridView Grilla)
        {
            StreamWriter archivo = new StreamWriter("reporte.csv", false, Encoding.UTF8);
            archivo.WriteLine("Lista de clientes");
            archivo.WriteLine("");
            archivo.WriteLine("Código;Nombre;Ciudad;Limite de crédito;Deuda");
            cantidad = 0;
            deuda = 0;
            promedio = 0;
            int i = 0;
            while (i < Grilla.RowCount - 1)
            {
                archivo.Write(Convert.ToInt32(Grilla.Rows[i].Cells[0].Value));
                archivo.Write(";");
                archivo.Write(Convert.ToString(Grilla.Rows[i].Cells[1].Value));
                archivo.Write(";");
                archivo.Write(Convert.ToString(Grilla.Rows[i].Cells[2].Value));
                archivo.Write(";");
                archivo.Write(Convert.ToDecimal(Grilla.Rows[i].Cells[3].Value));
                archivo.Write(";");
                archivo.WriteLine(Convert.ToDecimal(Grilla.Rows[i].Cells[4].Value));
                cantidad++;
                deuda = deuda + Convert.ToDecimal(Grilla.Rows[i].Cells[4].Value);
                i++;
            }
            promedio = deuda / cantidad;
            archivo.WriteLine("");
            archivo.WriteLine("Total de clientes:;;;;" + cantidad);
            archivo.WriteLine("Total de deuda:;;;;" + deuda);
            archivo.WriteLine("Promedio de deuda:;;;;" + promedio);
            archivo.Close();
            archivo.Dispose();
            Process abrir = new Process();
            abrir.StartInfo.FileName = "reporte.csv";
            abrir.Start();
        }
    }
}

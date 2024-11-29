using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listado_grafo
{
    internal class clsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private string Tabla = "Ciudad";
        public string Buscar(Int32 idCiudad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader dr = comando.ExecuteReader();
                string resultado = "";
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr.GetInt32(0) == idCiudad)
                        {
                            resultado = dr.GetString(1);
                        }
                    }
                }
                conexion.Close();
                return resultado;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_clientes
{
    internal class clsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private string Tabla = "Ciudad";
        public void Listar(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, Tabla);
                foreach (DataRow x in ds.Tables[Tabla].Rows)
                {
                    Combo.Items.Add(x["Nombre"]);
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
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

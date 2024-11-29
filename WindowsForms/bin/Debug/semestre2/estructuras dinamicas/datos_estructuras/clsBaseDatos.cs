using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string varCadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView grilla, string consulta)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, "Tabla");

                grilla.DataSource = null;
                grilla.DataSource = ds.Tables["Tabla"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
}

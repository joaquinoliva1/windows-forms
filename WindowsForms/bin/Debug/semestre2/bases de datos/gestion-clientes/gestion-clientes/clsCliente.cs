using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Drawing.Printing;

namespace gestion_clientes
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

        private Int32 idCli;
        private String nom;
        private Decimal deu;
        private Decimal lim;
        private Int32 idCiu;

        public Int32 idCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        public Decimal limite
        {
            get { return lim; }
            set { lim = value; }
        }
        public Int32 idCiudad
        {
            get { return idCiu; }
            set { idCiu = value; }
        }

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
                                    Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
                                    break;
                                case 1:
                                    if (dr.GetDecimal(2) > 0)
                                    {
                                        nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
                                    }
                                    break;
                                case 2:
                                    if (dr.GetDecimal(2) == 0)
                                    {
                                        nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
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
                                        Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
                                        break;
                                    case 1:
                                        if (dr.GetDecimal(2) > 0)
                                        {
                                            nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                            Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
                                        }
                                        break;
                                    case 2:
                                        if (dr.GetDecimal(2) == 0)
                                        {
                                            nombre_ciudad = ciu.Buscar(dr.GetInt32(4));
                                            Grilla.Rows.Add(dr.GetInt32(0), dr.GetString(1), nombre_ciudad, dr.GetDecimal(3).ToString("F2"), dr.GetDecimal(2).ToString("F2"));
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
            cantidad = 0;
            deuda = 0;
            promedio = 0;
            int i = 0;
            StreamWriter archivo = new StreamWriter("reporte.csv", false, Encoding.UTF8);
            archivo.WriteLine("Lista de clientes");
            archivo.WriteLine("");
            archivo.WriteLine("Código;Nombre;Ciudad;Limite de crédito;Deuda");
            while (i < Grilla.RowCount-1)
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
            DialogResult abrirReporte = MessageBox.Show("¿Deseas abrir el reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (abrirReporte == DialogResult.Yes)
            {
                Process abrir = new Process();
                abrir.StartInfo.FileName = "reporte.csv";
                abrir.Start();
                DialogResult guardarReporte = MessageBox.Show("¿Deseas guardar el reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (guardarReporte == DialogResult.Yes)
                {
                    string reporte = Path.Combine(Application.StartupPath, "reporte.csv");
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
                    saveFileDialog.Title = "Guardar archivo como";
                    saveFileDialog.FileName = "reporte.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.Copy(reporte, saveFileDialog.FileName, true);
                            MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (abrirReporte == DialogResult.No)
            {
                DialogResult guardarReporte = MessageBox.Show("¿Deseas guardar el reporte?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (guardarReporte == DialogResult.Yes)
                {
                    string reporte = Path.Combine(Application.StartupPath, "reporte.csv");
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
                    saveFileDialog.Title = "Guardar archivo como";
                    saveFileDialog.FileName = "reporte.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.Copy(reporte, saveFileDialog.FileName, true);

                            MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        public void Buscar(Int32 idCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idCli = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == idCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            deu = DR.GetDecimal(2);
                            lim = DR.GetDecimal(3);
                            idCiu = DR.GetInt32(4);
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
        public void Agregar()
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
                DataTable tabla = ds.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = nom;
                fila["Deuda"] = 0;
                fila["Limite"] = lim;
                fila["idCiudad"] = idCiu;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(ds, Tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Modificar(Int32 idCliente)
        {
            try
            {
                String sql = "UPDATE Cliente SET Limite = " + lim.ToString() + " WHERE idCodigo = " + idCliente.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Eliminar(Int32 idCliente)
        {
            try
            {
                String sql = "DELETE * FROM Cliente WHERE idCodigo = " + idCliente.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Add()
        {
            String sql = "INSERT INTO Cliente (Nombre,Deuda,Limite,idCiudad) VALUES ('"+nom+"',0,"+lim.ToString()+","+idCiu.ToString()+")";
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

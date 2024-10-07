using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.IO;
using static System.Net.WebRequestMethods;

namespace proyecto1
{
    public partial class frmHorarios : Form
    {
        //llamada a vector y matriz primer formulario
        private string[] vector;
        private string[,] horarios;

        //llamada a primer formulario
        private frmInicio frmInicio;

        public frmHorarios(frmInicio frmInicio, string[] vector, string[,] horarios)
        {
            InitializeComponent();
            this.frmInicio = frmInicio;
            this.vector = vector;
            this.horarios = horarios;

            crear_tool2.Enabled = false;
            data2.Columns.Add("nombres", "Nombre");
            data2.Columns.Add("lunes", "Lunes");
            data2.Columns.Add("martes", "Martes");
            data2.Columns.Add("miercoles", "Miercoles");
            data2.Columns.Add("jueves", "Jueves");
            data2.Columns.Add("viernes", "Viernes");
            data2.Columns.Add("sabado", "Sabado");
            data2.Columns.Add("domingo", "Domingo");
            for (int f = 0; f < vector.Length; f++)
            {
                if (vector[f] != null)
                {
                    data2.Rows.Add(vector[f]);
                    for (int c = 1; c < 8; c++)
                    {
                        data2.Rows[f].Cells[c].Value = horarios[f, c-1];
                    }
                }
            }
            data2.ReadOnly = false;
            data2.BackgroundColor = Color.DimGray;
            btnDeleteSelectedRows.Visible = true;
            data2.AllowUserToDeleteRows = true;
            data2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data2.MultiSelect = true; // permitir selección múltiple
        }
        private void archivo_guardar_Click(object sender, EventArgs e)
        {
            exportar(data2);
        }
        public void exportar(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int c = 0;
            foreach (DataGridViewColumn col in tabla.Columns)
            {
                c++;
                excel.Cells[1, c] = col.Name;
            }
            int f = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                f++;
                c = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    c++;
                    excel.Cells[f + 1, c] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void btnDeleteSelectedRows_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }
        private void DeleteSelectedRows()
        {
            // verificar si hay filas seleccionadas
            if (data2.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data2.SelectedRows)
                {
                    if (!row.IsNewRow) // Asegurarse de no eliminar la fila nueva (de entrada)
                    {
                        data2.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas para eliminar.", "Eliminar filas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (data2.Rows.Count == 0)
            {
                frmInicio.Show();
                this.Close();
            }
            actualizar();
        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizar();
            frmInicio.Show();
            this.Hide();
        }
        private void actualizar()
        {
            int filas = 0;
            while (filas < data2.Rows.Count)
            {
                int columnas = 1;
                while (columnas < 8)
                {
                    horarios[filas, columnas - 1] = data2.Rows[filas].Cells[columnas].Value?.ToString();
                    columnas++;
                }
                filas++;
            }
        }

    }
}

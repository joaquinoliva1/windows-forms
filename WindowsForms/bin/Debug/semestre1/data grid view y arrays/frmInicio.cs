using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto1
{
    public partial class frmInicio : Form
    {
        private string placeholderText = " Nombre completo del empleado";

        //declaración de vectores y matrices a utilizar
        string[] vector = new string[100];
        string[,] horarios = new string[100, 8];

        //llamada a frmHorarios
        private frmHorarios frmHorarios;

        public frmInicio()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);

            // configuración del text box
            txtNombre.Text = placeholderText;
            txtNombre.ForeColor = Color.DimGray;
            // eventos txtNombre
            txtNombre.Enter += TextBox1_Enter;
            txtNombre.Leave += TextBox1_Leave;

            //primer grilla: disponibilidad
            data.Columns.Add("nombre", "Nombre");
            data.Columns[0].ReadOnly = true;
            data.ReadOnly = false;
            data.BackgroundColor = Color.DimGray;
            data.AllowUserToDeleteRows = true;
            data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data.MultiSelect = true; // permitir selección múltiple
            buttonDelete.Visible = true;
        }
        //eventos: enter text box
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == placeholderText)
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black; // color del texto cuando el usuario empieza a escribir
            }
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = placeholderText;
                txtNombre.ForeColor = Color.Gray; // color del texto de sugerencia
            }
        }
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ejecutar el método de click
                btnAdd_Click(sender, e);
            }
        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            // asignar variable string a txtNombre
            string texto = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(texto) )
            {
                MessageBox.Show("Debe ingresar un nombre válido.");
            }
            else if (texto == placeholderText)
                MessageBox.Show("Debe ingresar un nombre válido.");
            else
            {
                // agregar el texto al DataGridView
                data.Rows.Add(texto);

                // borrar contenido de txtNombre
                txtNombre.Clear();

                // hacer visibles botones editar y borrar
                buttonDelete.Visible = true;

                actualizarvector();
            }
        }
        public void btnDelete_Click(object sender, EventArgs e)
        {
            // verificar si hay filas seleccionadas
            if (data.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data.SelectedRows)
                {
                    if (!row.IsNewRow) // Asegurarse de no eliminar la fila nueva (de entrada)
                    {
                        data.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay filas seleccionadas para eliminar.", "Eliminar filas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarvector();
        }
        private void generarTool_Click(object sender, EventArgs e)
        {
            if (vector[0] == null)
            {
                MessageBox.Show("Para acceder a este apartado debes tener al menos un empleado registrado.");
            }
            else
            {
                actualizarvector();
                this.Hide();
                frmHorarios frmHorarios = new frmHorarios(this, vector, horarios);
                frmHorarios.Show();
            }
        }
        private void archivo_guardar_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                MessageBox.Show("Debe tener al menos un empleado en la lista.");
            }
            else
            {
                exportar(data);
            }
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
        private void actualizarvector()
        {
            int i = 0;
            while (i < data.Rows.Count)
            {
                vector[i] = data.Rows[i].Cells[0].Value.ToString();
                i++;
            }
            if (data.Rows.Count == 0)
            {
                vector[0] = null;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    public partial class frmEnlazadaDoble : Form
    {
        public frmEnlazadaDoble()
        {
            InitializeComponent();
        }
        ListaDoble listaDoble = new ListaDoble();
        private void frmEnlazadaDoble_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Tramite", "Tramite");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Datos incompletos, complete la solicitud.");
            }
            else
            {
                Nodo ObjNodo = new Nodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                listaDoble.Agregar(ObjNodo);
                listaDoble.RecorrerDes(dataGridView1);
                listaDoble.RecorrerAsc(listBox1, comboBox1);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaDoble.Primero != null)
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    Int32 x = Convert.ToInt32(comboBox1.Text);
                    listaDoble.Eliminar(x);
                    listaDoble.RecorrerDes(dataGridView1);
                    listaDoble.RecorrerAsc(listBox1, comboBox1);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento.");
                }
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
        }
    }
}

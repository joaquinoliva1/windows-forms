using System;
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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        Cola cola = new Cola();

        private void frmCola_Load(object sender, EventArgs e)
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
                Nodo objeto_nodo = new Nodo();
                objeto_nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objeto_nodo.Nombre = txtNombre.Text;
                objeto_nodo.Tramite = txtTramite.Text;
                cola.Agregar(objeto_nodo);
                cola.Recorrer(dataGridView1);
                cola.Recorrer(listBox1);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cola.Primero != null)
            {
                lblCodigo.Text = cola.Primero.Codigo.ToString();
                lblNombre.Text = cola.Primero.Nombre;
                lblTramite.Text = cola.Primero.Tramite;
                cola.Eliminar();
                cola.Recorrer(dataGridView1);
                cola.Recorrer(listBox1);
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}

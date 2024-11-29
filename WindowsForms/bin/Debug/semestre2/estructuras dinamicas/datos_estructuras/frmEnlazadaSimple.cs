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
    public partial class frmEnlazadaSimple : Form
    {
        public frmEnlazadaSimple()
        {
            InitializeComponent();
        }
        ListaSimple lista = new ListaSimple();

        private void frmEnlazadaSimple_Load(object sender, EventArgs e)
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
                lista.Agregar(objeto_nodo);
                lista.Recorrer(dataGridView1);
                lista.Recorrer(lstSimple);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (lista.Primero != null)
            {
                lblCodigo.Text = lista.Primero.Codigo.ToString();
                lblNombre.Text = lista.Primero.Nombre;
                lblTramite.Text = lista.Primero.Tramite;
                lista.Eliminar(lista.Primero.Codigo);
                lista.Recorrer(dataGridView1);
                lista.Recorrer(lstSimple);
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

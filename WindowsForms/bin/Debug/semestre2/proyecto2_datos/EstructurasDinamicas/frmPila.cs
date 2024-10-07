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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        Pila pila = new Pila();
        
        private void frmPila_Load(object sender, EventArgs e)
        {
            dgvPila.RowHeadersVisible = false;
            dgvPila.Columns.Add("Codigo", "Código");
            dgvPila.Columns.Add("Nombre", "Nombre");
            dgvPila.Columns.Add("Tramite", "Tramite");
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
                pila.Agregar(objeto_nodo);
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                lblCodigo.Text = pila.Primero.Codigo.ToString();
                lblNombre.Text = pila.Primero.Nombre;
                lblTramite.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
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

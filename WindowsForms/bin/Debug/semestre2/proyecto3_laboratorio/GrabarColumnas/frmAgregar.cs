using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabarColumnas
{
    public partial class frmAgregarNuevoCliente : Form
    {
        public frmAgregarNuevoCliente()
        {
            InitializeComponent();
        }

        clsArchivo objeto = new clsArchivo();

        private void frmAgregarNuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //enviar los datos de las textbox a través del objeto creado a partir de la clase y mencionando el método.
            //los datos que enviemos deben estar en el mismo orden con el que los solicitamos desde la clase.
            objeto.grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text, txtLimite.Text);
            //notificar al usuario.
            MessageBox.Show("Datos grabados con éxito.");
            //limpiar las textbox para los siguientes datos a agregar.
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";
        }
    }
}

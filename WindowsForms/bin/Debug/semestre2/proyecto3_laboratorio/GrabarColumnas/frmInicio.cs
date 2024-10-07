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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoCliente agregar = new frmAgregarNuevoCliente();
            agregar.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado();
            listado.Show();
        }
    }
}

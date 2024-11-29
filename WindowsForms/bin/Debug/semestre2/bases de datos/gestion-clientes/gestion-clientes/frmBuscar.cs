using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_clientes
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdCliente = Convert.ToInt32(txtCliente.Text);
            clsCliente x = new clsCliente();
            x.Buscar(IdCliente);
            if (x.idCliente == 0)
            {
                lblNombre.Text = "Nombre:";
                lblDeuda.Text = "Deuda:";
                lblLimite.Text = "Limite:";
                MessageBox.Show("Cliente no encontrado.");
            }
            else
            {
                lblNombre.Text = "Nombre:    " + x.Nombre;
                lblDeuda.Text  = "Deuda:      " + x.Deuda.ToString();
                lblLimite.Text = "Limite:      " + x.limite.ToString();
            }
        }
    }
}

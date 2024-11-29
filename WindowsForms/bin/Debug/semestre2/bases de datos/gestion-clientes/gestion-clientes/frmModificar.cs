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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }
        private void frmModificar_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            txtLimite.Enabled = false;
        }
        private void limpiar()
        {
            txtCliente.Text = " Código de cliente ";
            lblNombre.Text = "Nombre:";
            lblDeuda.Text = "Deuda:";
            txtLimite.Text = "";
            txtLimite.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "" || txtCliente.Text == null)
            {
                MessageBox.Show("Debe colocar un número de cliente válido.");
            }
            else
            {
                Int32 idCliente = Convert.ToInt32(txtCliente.Text);
                clsCliente cliente = new clsCliente();
                cliente.Buscar(idCliente);
                if (cliente.idCliente == 0)
                {
                    lblNombre.Text = "Nombre:";
                    lblDeuda.Text = "Deuda:";
                    lblLimite.Text = "Limite:";
                    MessageBox.Show("Cliente no encontrado.");
                }
                else
                {
                    lblNombre.Text = "Nombre:    " + cliente.Nombre;
                    lblDeuda.Text = "Deuda:      " + cliente.Deuda.ToString();
                    txtLimite.Text = cliente.limite.ToString();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    txtLimite.Enabled = true;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            txtLimite.ReadOnly = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCliente.Text);
            clsCliente cli = new clsCliente();
            cli.limite = Convert.ToDecimal(txtLimite.Text);
            cli.Modificar(id);
            MessageBox.Show("Dato grabado exitosamente.");
            limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(txtCliente.Text);
            clsCliente cli = new clsCliente();
            cli.limite = Convert.ToDecimal(txtLimite.Text);
            cli.Eliminar(id);
            MessageBox.Show("Dato eliminado exitosamente.");
            limpiar();
        }
    }
}

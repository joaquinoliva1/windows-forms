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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            clsCiudad ciu = new clsCiudad();
            ciu.Listar(cboCiudad);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtLimite.Text != "" && cboCiudad.SelectedIndex >= 0)
            {
                clsCliente cli = new clsCliente();
                cli.Nombre = txtNombre.Text;
                cli.limite = Convert.ToDecimal(txtLimite.Text);
                cli.idCiudad = cboCiudad.SelectedIndex+1;
                cli.Agregar();
                MessageBox.Show("Datos grabados.");
                txtNombre.Text = "";
                txtLimite.Text = "";
                cboCiudad.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Faltan datos que agregar.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtLimite.Text != "" && cboCiudad.SelectedIndex >= 0)
            {
                clsCliente cli = new clsCliente();
                cli.Nombre = txtNombre.Text;
                cli.limite = Convert.ToDecimal(txtLimite.Text);
                cli.idCiudad = cboCiudad.SelectedIndex + 1;
                cli.Add();
                MessageBox.Show("Datos grabados.");
                txtNombre.Text = "";
                txtLimite.Text = "";
                cboCiudad.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Faltan datos que agregar.");
            }
        }
    }
}

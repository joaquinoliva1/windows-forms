using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LAB2
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            // Métodos KeyPress
            txtCodigo.KeyPress += new KeyPressEventHandler (txtCodigo_KeyPress);
            txtNombre.KeyPress += new KeyPressEventHandler (txtNombre_KeyPress);
            txtSueldo.KeyPress += new KeyPressEventHandler (txtSueldo_KeyPress);
        }

        // KeyPress: métodos para condicionar la entrada de las TextBox.
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // Evento CLICK (cmdCargar)
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtNombre.Text.Length == 0 || txtSueldo.Text.Length == 0)
            {
                MessageBox.Show("Completar campos vacíos.");
            }
            else
            {
                Int32 f = 0;
                while (DatosGlobales.Vendedores[f].Codigo != Convert.ToInt32 (txtCodigo.Text) && f < DatosGlobales.IND)
                {
                    f++;
                }
                if (f == DatosGlobales.IND)
                {
                    if (DatosGlobales.IND < DatosGlobales.Vendedores.Length)
                    {
                        DatosGlobales.Vendedores[DatosGlobales.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                        DatosGlobales.Vendedores[DatosGlobales.IND].Nombre = txtNombre.Text;
                        DatosGlobales.Vendedores[DatosGlobales.IND].Sueldo = Convert.ToDecimal(txtSueldo.Text);
                        DatosGlobales.IND++;
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtSueldo.Text = "";
                        MessageBox.Show("Vendedor registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No es posible cargar más datos.");
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado ya está en uso.");
                }
            }
        }
    }
}

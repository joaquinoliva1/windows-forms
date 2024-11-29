using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryNewLogistic
{
    public partial class frmAtencion : Form
    {
        public frmAtencion()
        {
            InitializeComponent(); this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No || result == DialogResult.Ignore)
            {
                e.Cancel = true;
            }
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length > 0 & optCorreo.Checked|| optMensaje.Checked & chkMañana.Checked || chkTarde.Checked & cboServicio.Text.Length > 0) {
                MessageBox.Show("El mensaje fue enviado con éxito.");
            }
            else { MessageBox.Show("Faltan datos para completar."); };
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form frmEntregas = new frmEntregas();
            frmEntregas.Show();
            this.Hide();
        }
    }
}

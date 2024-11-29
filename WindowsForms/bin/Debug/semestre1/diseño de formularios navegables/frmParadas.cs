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
    public partial class frmParadas : Form
    {
        int close = 0;
        public frmParadas()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {     
            Form frmPlanificar = new frmPlanificar();
            frmPlanificar.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text.Length > 0 & txtDestino.Text.Length > 0 & txtParada1.Text.Length > 0 || txtParada2.Text.Length > 0 || txtParada3.Text.Length > 0 || txtParada4.Text.Length > 0 || txtParada5.Text.Length > 0 || txtParada6.Text.Length > 0)
            {
                Form frmEntregas = new frmEntregas();
                frmEntregas.Show();
                this.Hide();
            }
            else { MessageBox.Show("Se debe agregar origen, destino y al menos una parada."); };
        }
    }
}

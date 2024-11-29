using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryNewLogistic
{

public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form frmDos = new frmRegistro();
            frmDos.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int pasar = 0;
            if (txtUsuario.Text.Trim().Length > 0 ) { pasar = 1; }
            else { pasar = 0; lblUsuario.ForeColor = Color.Red; };
            if (txtContraseña.Text.Trim().Length > 0 ) { pasar = 1; }
            else { pasar = 0; lblContraseña.ForeColor = Color.Red; };
            if (cboCiudad.Text.Trim().Length > 0 ) { pasar = 1; }
            else { pasar = 0; lblCiudad.ForeColor = Color.Red; };
            if (pasar == 1) { Form frmPlanificar = new frmPlanificar(); frmPlanificar.Show(); this.Hide(); };
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

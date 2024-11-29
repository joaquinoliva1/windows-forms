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
    public partial class frmRegistro : Form
    {
        int pasar = 0;
        int img = 0;
        public frmRegistro()
        {
            InitializeComponent();
        }
        public void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { lblFoto.Text = openFileDialog1.SafeFileName; lblFoto.ForeColor = Color.Green; img=1; }
            else { img=0; };
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (chkMayor.Checked & optParticular.Checked || optEmpresa.Checked & txtCuil.Text.Length > 0 & txtUsuario.Text.Length > 0 & txtCelular.Text.Length > 0 & txtContraseña.Text.Length > 0 & cboCiudad.Text.Length > 0)
            {pasar = 1; }
            else { pasar = 0; };
            if (pasar > 0 & img > 0) { Form frmTres = new frmVehiculo(); frmTres.Show(); this.Hide(); }
            else { MessageBox.Show("Faltan campos que rellenar."); return; }
        }
    }
}

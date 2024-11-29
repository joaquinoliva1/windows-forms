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
    public partial class frmVehiculo : Form
    {
        int pasar = 0;
        int img = 0;
        public frmVehiculo()
        {
            InitializeComponent();
        }
        private void btnImportarLicencia_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { btnImportarLicencia.Text = openFileDialog1.SafeFileName; btnImportarLicencia.ForeColor = Color.Green; img=1;}
            else { MessageBox.Show("Importar imágen."); img =0; };
        }

        private void btnPlanificarViaje_Click(object sender, EventArgs e)
        {
            if (cboTipoVehiculo.Text.Length > 0 & cboCapacidadVehiculo.Text.Length > 0 & txtPatente.Text.Length > 0 & optSeguroOk.Checked || optSeguroNo.Checked) { pasar = 1; }
            else { pasar = 0; };
            if (pasar > 0 & img > 0)
            {
                frmPlanificar fPlanificar = new frmPlanificar();
                fPlanificar.Show();
                this.Hide();
                fPlanificar.cboVehiculo.Text = txtPatente.Text;
            }
            else { MessageBox.Show("Faltan campos que completar."); };

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frmPlanificar : Form
    {
        int paquetes = 0;
        public frmPlanificar()
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
            Form frmInicio = new frmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            Form frmRegistroVariable = new frmVehiculo();
            frmRegistroVariable.Show();
        }

        private void btnPaquete1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete1.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnPaquete2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete2.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnPaquete3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete3.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnPaquete4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete4.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnPaquete5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete5.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnPaquete6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { lblPaquete6.Text = openFileDialog1.SafeFileName; lblPaquete1.ForeColor = Color.Green; paquetes += 1; };
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cboVehiculo.Text.Length > 0 & optLargaDistancia.Checked||optMediaDistancia.Checked & paquetes>0)
            {
                frmParadas fParadas = new frmParadas();
                fParadas.Show();
                this.Hide();
            }
            else { MessageBox.Show("Faltan campos que completar."); };
            if (paquetes <= 0) { MessageBox.Show("Debe ingresar al menos un archivo de lista de paquetes."); }
        }
    }
}

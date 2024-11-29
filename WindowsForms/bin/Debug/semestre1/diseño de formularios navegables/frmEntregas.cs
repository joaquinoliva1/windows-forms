using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryNewLogistic
{   
    public partial class frmEntregas : Form
    {
        private int conteo;

        public frmEntregas()
        {
            InitializeComponent();
            conteo = 0; 
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

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblConteo.Text = conteo.ToString();
        }

        private void frmEntregas_Shown(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = true;
        }

        private void frmEntregas_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrTiempo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = false;
            Form frmParadas = new frmParadas();
            frmParadas.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            tmrTiempo.Enabled = false;
            int promedioHoras = txtKm.Text.Length / 90;
            int contadorParadas = 0;
            int pase = 0;
            if (txtNumeroPaquete1.Text.Length > 0 & txtCuil1.Text.Length > 0) { contadorParadas += 1; };
            if (txtNumeroPaquete2.Text.Length > 0 & txtCuil2.Text.Length > 0) { contadorParadas += 1; };
            if (txtNumeroPaquete3.Text.Length > 0 & txtCuil3.Text.Length > 0) { contadorParadas += 1; };
            if (txtNumeroPaquete4.Text.Length > 0 & txtCuil4.Text.Length > 0) { contadorParadas += 1; };
            if (txtNumeroPaquete5.Text.Length > 0 & txtCuil5.Text.Length > 0) { contadorParadas += 1; };
            if (txtNumeroPaquete6.Text.Length > 0 & txtCuil6.Text.Length > 0) { contadorParadas += 1; };
            if (contadorParadas == 0 || cboUbicacionFinal.Text.Length == 0 || txtKm.Text.Length == 0) { MessageBox.Show("Ingresar al menos una parada y completar los campos requeridos."); tmrTiempo.Enabled = true; pase = 0; }
            else { pase = 1; };
            int contadorParadasMin = 15 * contadorParadas;
            int contadorTotalHoras = contadorParadasMin / 100;
            int total = promedioHoras + contadorTotalHoras;
            int segundos = total * 3600;
            int intervaloSeg = lblConteo.Text.Length;
            if (pase == 1 & intervaloSeg < segundos) { MessageBox.Show("Usted realizó su trabajo con demoras."); };
            if (pase == 1 & intervaloSeg > segundos) { MessageBox.Show("Usted realizó su trabajo en tiempo y forma."); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAtencion = new frmAtencion();
            frmAtencion.Show();
            this.Hide();
        }
    }
    }

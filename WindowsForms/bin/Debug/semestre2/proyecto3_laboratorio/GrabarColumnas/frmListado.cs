using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabarColumnas
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        clsArchivo objeto = new clsArchivo();
        private void frmListado_Load(object sender, EventArgs e)
        {
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Columns.Add("Codigo", "      Codigo");
            dgvDatos.Columns.Add("Nombre", "      Nombre");
            dgvDatos.Columns.Add("Deuda", "      Deuda");
            dgvDatos.Columns.Add("Limite", "      Limite");
            objeto.listar(dgvDatos);
            lblCantidadDeClientes.Text = objeto.cantidad_clientes().ToString() + " clientes";
            lblTotalDeuda.Text = objeto.total_deuda().ToString();
            lblPromedioDeDeuda.Text = objeto.promedio_deuda().ToString();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            if (chkAdeudados.Checked == true)
            {
                objeto.listar_deudas(dgvDatos);
                lblCantidadDeClientes.Text = objeto.cantidad_clientes().ToString() + " clientes";
            }
            else
            {
                objeto.listar(dgvDatos);
                lblCantidadDeClientes.Text = objeto.cantidad_clientes().ToString() + " clientes";
            }
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            objeto.generar_reporte();
            MessageBox.Show("Reporte generado.");
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            objeto.ordenar_datos();
            objeto.listar(dgvDatos);
        }
    }
}

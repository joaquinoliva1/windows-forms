using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listado_grafo
{
    public partial class Form1 : Form
    {
        int tipo;
        int ciudad;
        int orden;
        public Form1()
        {
            InitializeComponent();
            clsCliente cliente = new clsCliente();
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Columns.Add("Cliente", "Cliente");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Ciudad", "Ciudad");
            dgvDatos.Columns.Add("Limite", "Limite");
            dgvDatos.Columns.Add("Deuda", "Deuda");
            cboCiudad.SelectedIndex = 0;
            cboFiltro.SelectedIndex = 0;
            listar();
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            cliente.Reporte(dgvDatos);
        }
        private void listar()
        {
            clsCliente cliente = new clsCliente();
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
            cliente.Listar(dgvDatos, ciudad, tipo);
        }
        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cboCiudad.SelectedIndex;
            tipo = cboFiltro.SelectedIndex;
            listar();
        }
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cboCiudad.SelectedIndex;
            tipo = cboFiltro.SelectedIndex;
            listar();
        }
    }
}

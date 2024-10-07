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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcercaDe = new frmAcercaDe();
            frmAcercaDe.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void agregarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.Show();
        }
        private void listaDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.Show();
        }
        private void consultarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVendedor frmConsultar = new frmConsultarVendedor();
            frmConsultar.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_clientes
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void toolListado_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado();
            listado.Show();
        }

        private void toolBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar buscar = new frmBuscar();
            buscar.Show();
        }
        private void toolAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.Show();
        }
        private void toolModificar_Click(object sender, EventArgs e)
        {
            frmModificar modificar = new frmModificar();
            modificar.Show();
        }
        private void toolDesarrollador_Click(object sender, EventArgs e)
        {
            frmDesarrollador desarrollador = new frmDesarrollador();
            desarrollador.Show();
        }
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

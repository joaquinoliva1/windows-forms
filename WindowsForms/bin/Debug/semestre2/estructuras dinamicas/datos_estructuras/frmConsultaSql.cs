using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    public partial class frmConsultaSql : Form
    {
        public frmConsultaSql()
        {
            InitializeComponent();
            dgvDatos.RowHeadersVisible = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            clsBaseDatos baseDatos = new clsBaseDatos();
            baseDatos.Listar(dgvDatos, txtSQL.Text);
        }
    }
}

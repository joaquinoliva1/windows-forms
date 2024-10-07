using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosDeTexto
{
    public partial class frmGrabarDatos : Form
    {
        public frmGrabarDatos()
        {
            InitializeComponent();
        }

        //para utilizar el método de la clase clsArchivo, debemos instanciarlo con un objeto:
        clsArchivo Objeto = new clsArchivo();
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Objeto.Grabar(txtDatos.Text); //método Grabar() de la clase creada e instanciada.
            //si deseamos grabar el dato del TextBox debemos colocar el objeto dentro del método llamado (txtDatos).
            MessageBox.Show("Datos grabados.");
            Objeto.Listar(lstDatos);
        }
    }
}

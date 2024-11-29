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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }
        Arbol arbol = new Arbol();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Nodo numero = new Nodo();
                numero.Codigo = Convert.ToInt32(txtValor.Text);
                arbol.Agregar(numero);
                arbol.Recorrer(listBox1);
                arbol.Recorrer(treeView1);
            }
            catch 
            { 
                MessageBox.Show("Agregar un valor válido."); 
            }
        }
    }
}

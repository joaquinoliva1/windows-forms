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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void subDesarrollador_Click(object sender, EventArgs e)
        {
            frmDesarrollador frmDesarrollador = new frmDesarrollador();
            frmDesarrollador.Show();
        }

        private void subSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subCola_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.Show();
        }

        private void subPila_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.Show();
        }

        private void subGrafo_Click(object sender, EventArgs e)
        {
            frmGrafo frmGrafo = new frmGrafo();
            frmGrafo.Show();
        }

        private void subEnlazadaSimple_Click(object sender, EventArgs e)
        {
            frmEnlazadaSimple frmEnlazadaSimple = new frmEnlazadaSimple();
            frmEnlazadaSimple.Show();
        }

        private void subEnlazadaDoble_Click(object sender, EventArgs e)
        {
            frmEnlazadaDoble frmEnlazadaDoble = new frmEnlazadaDoble();
            frmEnlazadaDoble.Show();
        }

        private void subArbol_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbol = new frmArbolBinario();
            frmArbol.Show();
        }
    }
}

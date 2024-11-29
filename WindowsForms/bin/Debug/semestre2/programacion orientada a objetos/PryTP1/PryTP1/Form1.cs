using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTP1
{
    public partial class Form1 : Form
    {
        private ClaseCliente objCliente = new ClaseCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Importe = decimal.Parse(txtImporte.Text);
            objCliente.Pagar(importe: Importe);
            lblDeuda.Text = objCliente.Deuda.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            decimal Importe = decimal.Parse(txtImporte.Text);
            objCliente.Comprar(importe: Importe);
            lblDeuda.Text = objCliente.Deuda.ToString();
        }
    }
}

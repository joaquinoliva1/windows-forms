using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPrimero
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            int ValorUno;
            int ValorDos;
            int ValorTotal;
            ValorUno = Convert.ToInt32(TxtValorUno.Text);
            ValorDos = Convert.ToInt32(TxtValorDos.Text);
            ValorTotal = ValorUno + ValorDos;
            LblResultado.Text = ValorTotal.ToString();
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            int ValorUno;
            int ValorDos;
            int ValorTotal;
            ValorUno = Convert.ToInt32(TxtValorUno.Text);
            ValorDos = Convert.ToInt32(TxtValorDos.Text);
            ValorTotal = ValorUno - ValorDos;
            LblResultado.Text = ValorTotal.ToString();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            int ValorUno;
            int ValorDos;
            int ValorTotal;
            ValorUno = Convert.ToInt32(TxtValorUno.Text);
            ValorDos = Convert.ToInt32(TxtValorDos.Text);
            ValorTotal = ValorUno * ValorDos;
            LblResultado.Text = ValorTotal.ToString();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            int ValorUno;
            int ValorDos;
            int ValorTotal;
            ValorUno = Convert.ToInt32(TxtValorUno.Text);
            ValorDos = Convert.ToInt32(TxtValorDos.Text);
            ValorTotal = ValorUno / ValorDos;
            LblResultado.Text = ValorTotal.ToString();
        }
    }
}

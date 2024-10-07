using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace semestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtValor.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número, un punto decimal o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor;
            decimal.TryParse(txtValor.Text, out valor);
            decimal intereses;
            decimal total;
            decimal cuota;
            decimal mantenimiento;
            decimal variabiliad;
            decimal aumento;
            if (valor==0)
            {
                MessageBox.Show("Debe ingresar un valor válido");
            }
            else
            {
                if (optNX.Checked)
                {
                    intereses = valor * 10/100;
                    mantenimiento = 8469*6;
                    variabiliad = mantenimiento * 50 / 100;
                    total = valor + intereses + mantenimiento + variabiliad;
                    cuota = total / 6;
                    lblTotal.Text = "Valor total: $" + total.ToString("F2");
                    lblCuota.Text = "6 pagos de $" + cuota.ToString("F2");
                }
                else if (optBBVA.Checked)
                {
                    intereses = valor * 30/100;
                    total = valor + intereses;
                    cuota = total / 6;
                    lblTotal.Text = "Valor total: $"+total.ToString("F2");
                    lblCuota.Text = "6 pagos de $"+cuota.ToString("F2");
                }
                else
                {
                    lblTotal.Text = "Valor total: $" + valor.ToString("F2");
                    lblCuota.Text = "1 pago de $" + valor.ToString("F2");
                }
                aumento = valor * 100 / 335000 - 100;
                lblAumento.Text = "Un " + aumento.ToString("F2") + "% más que el año pasado.";
            }
        }
    }
}

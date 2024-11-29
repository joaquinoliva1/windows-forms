using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInmobiliaria
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declaración de variables
            double metroCuadradoDpto = 1921;
            double metroCuadradoCochera = 1235;
            double subtotal = 0;
            double adicionalPiso = 0;

            // definición de condiciones: material aberturas
            if (optAluminio.Checked)
            {
                metroCuadradoDpto = metroCuadradoDpto + 25;
            }
            else
            {
                if (optMadera.Checked)
                {
                    metroCuadradoDpto = metroCuadradoDpto + 46;
                }
                else
                {
                    MessageBox.Show("Faltan datos que completar.");
                    return;
                }
            }

            // definición de condiciones: material piso
            if (optPorcelanato.Checked)
            {
                metroCuadradoDpto = metroCuadradoDpto + 32;
            }
            else
            {
                if (optFlotante.Checked)
                {
                    metroCuadradoDpto = metroCuadradoDpto + 26.50;
                }
                else
                {
                    if (optAlisado.Checked)
                    {
                        metroCuadradoDpto = metroCuadradoDpto + 21.21;
                    }
                    else
                    {
                        MessageBox.Show("Faltan datos que completar.");
                        return;
                    }
                }
            }

            // definición de condiciones: departamento (A, B, C)
            switch (cboDepartamento.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Faltan datos que completar.");
                    return;
                case 0: subtotal = metroCuadradoDpto * 85 + metroCuadradoCochera * 21; break;
                case 1: subtotal = metroCuadradoDpto * 52; break;
                case 2: subtotal = metroCuadradoDpto * 35; break;
            }

            // definición de condiciones: piso (1-9)
            if (cboPiso.SelectedIndex == -1)
            {
                MessageBox.Show("Faltan datos que completar.");
                return;
            }
            if (cboPiso.SelectedIndex == 0)
            {
                adicionalPiso = subtotal * 0.18;
            }
            else
            {
                if (cboPiso.SelectedIndex <= 2)
                {
                    adicionalPiso = subtotal * 0.07;
                }
                else
                {
                    adicionalPiso = subtotal * 0.05;
                }
            }

            double total = subtotal + adicionalPiso;
            double plusVenta = total * 0.09;
            double plusIVA = total * 0.105;
            double plusRentas = total * 0.021;
            double sub = total + plusVenta + plusIVA + plusRentas;

            int n = dtgvSubtotales.Rows.Add();
            dtgvSubtotales.Rows[n].Cells[0].Value = cboDepartamento.Text + cboPiso.Text;
            dtgvSubtotales.Rows[n].Cells[1].Value = plusVenta.ToString("N2");
            dtgvSubtotales.Rows[n].Cells[2].Value = plusIVA.ToString("N2");
            dtgvSubtotales.Rows[n].Cells[3].Value = plusRentas.ToString("N2");
            dtgvSubtotales.Rows[n].Cells[4].Value = sub.ToString("N2");

            double suma = 0;
            foreach (DataGridViewRow row in dtgvSubtotales.Rows)
            {
                if (row.Cells[4].Value != null)
                    suma += Convert.ToDouble (row.Cells[4].Value);
            }
            lblTotal.Text = suma.ToString("N2");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (DataGridViewRow row in dtgvSubtotales.Rows)
            {
                if (row.Cells[4].Value != null)
                    suma += Convert.ToDouble(row.Cells[4].Value);
            }
            lblTotal.Text = suma.ToString("N2");
        }
    }
}

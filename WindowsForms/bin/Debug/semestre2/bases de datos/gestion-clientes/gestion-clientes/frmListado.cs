using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace gestion_clientes
{
    public partial class frmListado : Form
    {
        int tipo;
        int ciudad;
        int orden;
        public frmListado()
        {
            InitializeComponent();
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Columns.Add("Cliente", "Cliente");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Ciudad", "Ciudad");
            dgvDatos.Columns.Add("Limite", "Limite");
            dgvDatos.Columns.Add("Deuda", "Deuda");
            cboCiudad.SelectedIndex = 0;
            cboFiltro.SelectedIndex = 0;
            listar();
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            cliente.Reporte(dgvDatos);
        }
        private void listar()
        {
            clsCliente cliente = new clsCliente();
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
            cliente.Listar(dgvDatos, ciudad, tipo);
        }
        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cboCiudad.SelectedIndex;
            tipo = cboFiltro.SelectedIndex;
            listar();
        }
        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cboCiudad.SelectedIndex;
            tipo = cboFiltro.SelectedIndex;
            listar();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso exitosamente.");
        }
        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int i = 0;
                int row = 140;
                Font LetraFilas = new Font("Arial", 10);
                Font LetraTitulo = new Font("Arial", 20);
                e.Graphics.DrawString("Lista de clientes", LetraTitulo, Brushes.Black, 80, 80);
                if (dgvDatos.Rows.Count > 0)
                {
                    e.Graphics.DrawString("Cliente", LetraFilas, Brushes.Blue, 80, 130);
                    e.Graphics.DrawString("Nombre", LetraFilas, Brushes.Blue, 160, 130);
                    e.Graphics.DrawString("Ciudad", LetraFilas, Brushes.Blue, 380, 130);
                    e.Graphics.DrawString("Limite", LetraFilas, Brushes.Blue, 530, 130);
                    e.Graphics.DrawString("Deuda", LetraFilas, Brushes.Blue, 680, 130);
                    while (i < dgvDatos.Rows.Count)
                    {
                        if (dgvDatos.Rows[i].Cells[0].Value != null)
                        {
                            row = row + 15;
                            e.Graphics.DrawString(dgvDatos.Rows[i].Cells[0].Value.ToString(), LetraFilas, Brushes.Black, 80, row);
                            e.Graphics.DrawString(dgvDatos.Rows[i].Cells[1].Value.ToString(), LetraFilas, Brushes.Black, 160, row);
                            e.Graphics.DrawString(dgvDatos.Rows[i].Cells[2].Value.ToString(), LetraFilas, Brushes.Black, 380, row);
                            e.Graphics.DrawString(dgvDatos.Rows[i].Cells[3].Value.ToString(), LetraFilas, Brushes.Black, 530, row);
                            e.Graphics.DrawString(dgvDatos.Rows[i].Cells[4].Value.ToString(), LetraFilas, Brushes.Black, 680, row);
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

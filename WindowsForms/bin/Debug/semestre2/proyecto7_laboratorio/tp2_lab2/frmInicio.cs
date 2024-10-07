using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_lab2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        clsMetodos objeto = new clsMetodos();
        public int cantidad;
        public Decimal total;
        public string seleccion = "";

        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Columns.Add("Codigo", "Codigo");
            dgvDatos.Columns.Add("Descripcion", "Descripcion");
            dgvDatos.Columns.Add("Costo", "Costo");
            dgvDatos.Columns.Add("Rubro", "Rubro");
            dgvDatos.Columns.Add("Stock", "Stock");
            dgvDatos.Columns.Add("Valor en stock", "Valor en stock");
            objeto.combox(cboRubro);
            objeto.listar(dgvDatos);
            lblCantidad.Text = "Cantidad de articulos: " + objeto.label_cantidad().ToString();
            lblTotal.Text = "Valor total: $ " + objeto.label_total().ToString();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboRubro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rubro.");
            }
            else
            {
                if (cboRubro.SelectedIndex == 0)
                {
                    objeto.mostrar_repuestos(dgvDatos);
                    lblCantidad.Text = "Cantidad de articulos: " + objeto.repuesto_cantidad().ToString();
                    lblTotal.Text = "Valor total: $ " + objeto.repuesto_total().ToString();
                }
                if (cboRubro.SelectedIndex == 1)
                {
                    objeto.mostrar_accesorios(dgvDatos);
                    lblCantidad.Text = "Cantidad de articulos: " + objeto.accesorio_cantidad().ToString();
                    lblTotal.Text = "Valor total: $ " + objeto.accesorio_total().ToString();
                }
                if (cboRubro.SelectedIndex == 2)
                {
                    objeto.mostrar_insumos(dgvDatos);
                    lblCantidad.Text = "Cantidad de articulos: " + objeto.insumo_cantidad().ToString();
                    lblTotal.Text = "Valor total: $ " + objeto.insumo_total().ToString();
                }
                btnCancelar.Visible = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            objeto.listar(dgvDatos);
            cboRubro.Text = null;
            lblCantidad.Text = "Cantidad de articulos: " + objeto.label_cantidad().ToString();
            lblTotal.Text = "Valor total: $ " + objeto.label_total().ToString();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (cboRubro.SelectedIndex == -1 || cboRubro.Text==null)
            {
                objeto.exportar();
            }
            if (cboRubro.SelectedIndex == 0)
            {
                objeto.exportar_repuesto();
            }
            if (cboRubro.SelectedIndex == 1)
            {
                objeto.exportar_accesorio();
            }
            if (cboRubro.SelectedIndex == 2)
            {
                objeto.exportar_insumo();
            }
        }
        private void linkAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.Show();
        }
    }
}

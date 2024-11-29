using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LAB2
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }
        decimal total = 0;
        int vendedores = 0;
        private void frmListado_Load(object sender, EventArgs e)
        {
            dgvDatos.Columns.Add("Codigo", "Código");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Sueldo", "Sueldo");
            dgvDatos.RowHeadersVisible = false;

            DatosGlobales.RegVendedores aux;
            int c = 0;
            while (c < DatosGlobales.IND - 1)
            {
                int ind = 0;
                while (ind < DatosGlobales.IND - 1)
                {
                    if (DatosGlobales.Vendedores[ind].Codigo > DatosGlobales.Vendedores[ind + 1].Codigo)
                    {
                        aux = DatosGlobales.Vendedores[ind];
                        DatosGlobales.Vendedores[ind] = DatosGlobales.Vendedores[ind + 1];
                        DatosGlobales.Vendedores[ind + 1] = aux;
                    }
                    ind++;
                }
                c++;
            }

            dgvDatos.Rows.Clear();
            for (Int32 i = 0; i < DatosGlobales.IND; i++)
            {
                dgvDatos.Rows.Add(DatosGlobales.Vendedores[i].Codigo, DatosGlobales.Vendedores[i].Nombre, DatosGlobales.Vendedores[i].Sueldo);
                total = total + DatosGlobales.Vendedores[i].Sueldo;
                vendedores = vendedores + 1;
            }
            lblImporte.Text = lblImporte.Text + " " + total.ToString();
            lblVendedores.Text = lblVendedores.Text + " " + vendedores.ToString();
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOrden.Enabled = true;
        }
        private void cboOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdListar.Enabled = true;
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            switch (cboCampo.SelectedIndex)
            {
                case 0:
                    if (cboOrden.SelectedIndex == 0)
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Codigo > DatosGlobales.Vendedores[ind + 1].Codigo)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] = DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Codigo < DatosGlobales.Vendedores[ind + 1].Codigo)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] = DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
                case 1:
                    if (cboOrden.SelectedIndex == 0)
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Nombre.CompareTo(DatosGlobales.Vendedores[ind + 1].Nombre) > 0)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] =
                                    DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Nombre.CompareTo(DatosGlobales.Vendedores[ind + 1].Nombre) < 0)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] =
                                    DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
                case 2:
                    if (cboOrden.SelectedIndex == 0)
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Sueldo > DatosGlobales.Vendedores[ind + 1].Sueldo)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] = DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegVendedores aux;
                        int c = 0;
                        while (c < DatosGlobales.IND - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.IND - 1)
                            {
                                if (DatosGlobales.Vendedores[ind].Sueldo < DatosGlobales.Vendedores[ind + 1].Sueldo)
                                {
                                    aux = DatosGlobales.Vendedores[ind];
                                    DatosGlobales.Vendedores[ind] = DatosGlobales.Vendedores[ind + 1];
                                    DatosGlobales.Vendedores[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
            }
            dgvDatos.Rows.Clear();
            for (Int32 ind = 0; ind < DatosGlobales.IND; ind++)
            {
                dgvDatos.Rows.Add(DatosGlobales.Vendedores[ind].Codigo, DatosGlobales.Vendedores[ind].Nombre, DatosGlobales.Vendedores[ind].Sueldo);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clase1._4.frmInicio;

namespace clase1._4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtCodigo.KeyPress += new KeyPressEventHandler(txtCodigo_KeyPress);
            txtDeuda.KeyPress += new KeyPressEventHandler(txtDecimal_KeyPress);
            txtLimite.KeyPress += new KeyPressEventHandler(txtDecimal_KeyPress);
            txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);

            dgvDatos.Columns.Add("Codigo", "Código");
            dgvDatos.Columns.Add("Nombre", "Nombre");
            dgvDatos.Columns.Add("Limite", "Limite");
            dgvDatos.Columns.Add("Deuda", "Deuda");
            dgvDatos.RowHeadersVisible = false;

            btnDeudores.Visible = false;
            btnListaCompleta.Visible = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "" || txtLimite.Text == "")
            {
                MessageBox.Show("Faltan campos que completar.");
            }
            else
            {
                Int32 f = 0;
                while (DatosGlobales.Clientes[f].Codigo != Convert.ToInt32(txtCodigo.Text) && f < DatosGlobales.i)
                {
                    f++;
                }
                if (f == DatosGlobales.i)
                {
                    if (DatosGlobales.i < DatosGlobales.Clientes.Length)
                    {
                        DatosGlobales.Clientes[DatosGlobales.i].Codigo = Convert.ToInt32(txtCodigo.Text);
                        DatosGlobales.Clientes[DatosGlobales.i].Nombre = txtNombre.Text;
                        DatosGlobales.Clientes[DatosGlobales.i].Deuda = Convert.ToDecimal(txtDeuda.Text);
                        DatosGlobales.Clientes[DatosGlobales.i].Limite = Convert.ToDecimal(txtLimite.Text);
                        DatosGlobales.i++;
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtDeuda.Text = "";
                        txtLimite.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No es posible cargar más datos en el vector.");
                    }
                }
                else
                {
                    MessageBox.Show("El código de cliente ya está en uso.");
                }
                Listar();
            }
        }
        private void Listar()
        {
            btnDeudores.Visible = true;
            Decimal total = 0;
            dgvDatos.Rows.Clear();
            for (Int32 ind = 0; ind < DatosGlobales.i; ind++)
            {
                dgvDatos.Rows.Add(DatosGlobales.Clientes[ind].Codigo, DatosGlobales.Clientes[ind].Nombre, DatosGlobales.Clientes[ind].Limite, DatosGlobales.Clientes[ind].Deuda);
                total = total + DatosGlobales.Clientes[ind].Deuda;
            }
            lblDeudaTotal.Text = " Deuda total:   $" + total.ToString();
        }

        //KEYPRESS, BLOQUEOS
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {
            btnDeudores.Visible = false;
            btnListaCompleta.Visible = true;
            Decimal total = 0;
            dgvDatos.Rows.Clear();
            for (Int32 ind = 0; ind < DatosGlobales.i; ind++)
            {
                if (DatosGlobales.Clientes[ind].Deuda > 0)
                {
                    dgvDatos.Rows.Add(DatosGlobales.Clientes[ind].Codigo, DatosGlobales.Clientes[ind].Nombre, DatosGlobales.Clientes[ind].Limite, DatosGlobales.Clientes[ind].Deuda);
                    total = total + DatosGlobales.Clientes[ind].Deuda;
                }
            }
            lblDeudaTotal.Text = " Deuda total:   $" + total.ToString();
        }

        private void btnListaCompleta_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            switch (cboCampo.SelectedIndex)
            {
                case 0:
                    if (cboModo.SelectedIndex == 0)
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Codigo > DatosGlobales.Clientes[ind + 1].Codigo)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Codigo < DatosGlobales.Clientes[ind + 1].Codigo)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
                case 1:
                    if (cboModo.SelectedIndex == 0)
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Nombre.CompareTo(DatosGlobales.Clientes[ind + 1].Nombre) > 0)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Nombre.CompareTo(DatosGlobales.Clientes[ind + 1].Nombre) < 0)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
                case 2:
                    if (cboModo.SelectedIndex == 0)
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Limite > DatosGlobales.Clientes[ind + 1].Limite)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Limite < DatosGlobales.Clientes[ind + 1].Limite)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
                case 3:
                    if (cboModo.SelectedIndex == 0)
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Deuda > DatosGlobales.Clientes[ind + 1].Deuda)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    else
                    {
                        DatosGlobales.RegistroCliente aux;
                        int c = 0;
                        while (c < DatosGlobales.i - 1)
                        {
                            int ind = 0;
                            while (ind < DatosGlobales.i - 1)
                            {
                                if (DatosGlobales.Clientes[ind].Deuda < DatosGlobales.Clientes[ind + 1].Deuda)
                                {
                                    aux = DatosGlobales.Clientes[ind];
                                    DatosGlobales.Clientes[ind] = DatosGlobales.Clientes[ind + 1];
                                    DatosGlobales.Clientes[ind + 1] = aux;
                                }
                                ind++;
                            }
                            c++;
                        }
                    }
                    break;
            }
            dgvDatos.Rows.Clear();
            for (Int32 ind = 0; ind < DatosGlobales.i; ind++)
            {
                dgvDatos.Rows.Add(DatosGlobales.Clientes[ind].Codigo, DatosGlobales.Clientes[ind].Nombre, DatosGlobales.Clientes[ind].Limite, DatosGlobales.Clientes[ind].Deuda);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_LAB2
{
    public partial class frmConsultarVendedor : Form
    {
        public frmConsultarVendedor()
        {
            InitializeComponent();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int i = 0;
            lblCodigo.Text = "Codigo: ";
            lblVendedor.Text = "Vendedor: ";
            lblSueldo.Text = "Sueldo: ";
            if (txtIngresar.Text != "")
            {
                while (i < DatosGlobales.Vendedores.Length)
                {
                    if (txtIngresar.Text == DatosGlobales.Vendedores[i].Nombre)
                    {
                        lblCodigo.Text = "Codigo: " + DatosGlobales.Vendedores[i].Codigo;
                        lblVendedor.Text = "Vendedor: " + DatosGlobales.Vendedores[i].Nombre;
                        lblSueldo.Text = "Sueldo: " + DatosGlobales.Vendedores[i].Sueldo;
                        MessageBox.Show("Recuerde que si existe más de un vendedor con el mismo nombre, es preferible buscarlo mediate su código.");
                        break;
                    }
                    else
                    {
                        string aux = Convert.ToString(DatosGlobales.Vendedores[i].Codigo);
                        if (txtIngresar.Text == aux)
                        {
                            lblCodigo.Text = "Codigo: " + DatosGlobales.Vendedores[i].Codigo;
                            lblVendedor.Text = "Vendedor: " + DatosGlobales.Vendedores[i].Nombre;
                            lblSueldo.Text = "Sueldo: " + DatosGlobales.Vendedores[i].Sueldo;
                            break;
                        }
                    }
                    i++;
                }
                if (lblCodigo.Text == "Codigo: ")
                {
                    MessageBox.Show("Datos no encontrados. Intente nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Para buscar un vendedor debe ingresar al menos uno de los datos solicitados.");
            }
        }
    }
}

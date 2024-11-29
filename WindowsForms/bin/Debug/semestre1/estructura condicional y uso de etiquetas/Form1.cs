using System;
using System.Text;

namespace PryTiendaDeRopa
{
    public partial class Form1 : Form
    {
        private string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private string[] Sucursales = { "Sucursal 1", "Sucursal 2", "Sucursal 3", "Sucursal 4", "Sucursal 5", "Sucursal 6" };
        int[,] Ventas = new int[12, 6];

        public Form1()
        {
            InitializeComponent();

            // Llenar los ComboBox con los valores de Meses y Sucursales
            cboMeses.Items.AddRange(Meses);
            cboSucursal.Items.AddRange(Sucursales);

            // Generar ventas aleatorias una sola vez al inicio
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Ventas[i, j] = random.Next(1, 10000);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int f = cboMeses.SelectedIndex;
            int c = cboSucursal.SelectedIndex;

            if (opt1.Checked)
            {
                // Mostrar las ventas del mes y sucursal seleccionados
                lblInforme.Text = $"La sucursal {cboSucursal.Text} tuvo {Ventas[f, c]} ventas este mes.";
            }
            else if (opt2.Checked)
            {
                // Calcular y mostrar el total de ventas anuales de la sucursal seleccionada
                int totalVentasAnuales = 0;
                for (int i = 0; i < 12; i++)
                {
                    totalVentasAnuales += Ventas[i, c];
                }
                lblInforme.Text = $"La sucursal {cboSucursal.Text} tuvo un total de {totalVentasAnuales} ventas en el año.";
            }
            else if (opt3.Checked)
            {
                // Calcular y mostrar el total de ventas del mes en todas las sucursales
                int totalVentasMes = 0;
                for (int i = 0; i < 6; i++)
                {
                    totalVentasMes += Ventas[f, i];
                }
                lblInforme.Text = $"En {Meses[f]} se vendieron {totalVentasMes} unidades en todas las tiendas.";
            }
            else if (opt4.Checked)
            {
                // Mostrar el listado de total de ventas de todas las sucursales por mes
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 12; i++)
                {
                    int totalVentasMes = 0;
                    for (int j = 0; j < 6; j++)
                    {
                        totalVentasMes += Ventas[i, j];
                    }
                    sb.AppendLine($"{Meses[i]}: {totalVentasMes}");
                }
                lblInforme.Text = sb.ToString();
            }
            else if (opt5.Checked)
            {
                // Mostrar el listado de total de ventas anuales de cada sucursal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 6; i++)
                {
                    int totalVentasSucursal = 0;
                    for (int j = 0; j < 12; j++)
                    {
                        totalVentasSucursal += Ventas[j, i];
                    }
                    sb.AppendLine($"{Sucursales[i]}: {totalVentasSucursal}");
                }
                lblInforme.Text = sb.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class frmSemestre1 : Form
    {
        public frmSemestre1()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip(); // Descripción flotante sobre los botones.
            toolTip1.AutoPopDelay = 5000;  // Tiempo que el tooltip permanecerá visible.
            toolTip1.InitialDelay = 400;  // Tiempo que tardará en mostrarse al pasar el cursor.
            toolTip1.ReshowDelay = 0;    // Tiempo entre la ocultación y la nueva aparición.
            toolTip1.SetToolTip(this.btnAbrir, "Abrir proyecto.");
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboProyecto.SelectedIndex)
            {
                case 0:
                    lblDetalle.Text = " Calculadora de operaciones básicas.";
                    break;
                case 1:
                    lblDetalle.Text = " Sistema de gestión inmobiliaria.";
                    break;
                case 2:
                    lblDetalle.Text = " Sistema de informes de ventas.";
                    break;
                case 3:
                    lblDetalle.Text = " Sistema de cálculo de intereses.";
                    break;
                case 4:
                    lblDetalle.Text = " Sistema de gestión logística.";
                    break;
                case 5:
                    lblDetalle.Text = " Gestor de horarios para RRHH.";
                    break;
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (cboProyecto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un proyecto para abrir.");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (cboProyecto.SelectedIndex)
                {
                    case 0:
                        string proyecto1 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe = System.IO.Path.Combine(proyecto1, @"semestre1\proyecto1\calculadora\bin\Debug\PryPrimero.exe");
                        Process.Start(rutaExe);
                        break;
                    case 1:
                        string proyecto2 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto2exe = System.IO.Path.Combine(proyecto2, @"semestre1\proyecto2\inmobiliaria\bin\Debug\pryInmobiliaria.exe");
                        Process.Start(proyecto2exe);
                        break;
                    case 2:
                        string proyecto3 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto3exe = System.IO.Path.Combine(proyecto3, @"semestre1\proyecto3\tienda_de_ropa\bin\Debug\pryTienda.exe");
                        Process.Start(proyecto3exe);
                        break;
                    case 3:
                        string proyecto4 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto4exe = System.IO.Path.Combine(proyecto4, @"semestre1\proyecto4\semestre\bin\Debug\semestre.exe");
                        Process.Start(proyecto4exe);
                        break;
                    case 4:
                        string proyecto5 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto5exe = System.IO.Path.Combine(proyecto5, @"semestre1\parcial1\gestion_logistica\bin\Debug\PryNewLogistic.exe");
                        Process.Start(proyecto5exe);
                        break;
                    case 5:
                        string proyecto6 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto6exe = System.IO.Path.Combine(proyecto6, @"semestre1\parcial2\final\bin\Debug\proyecto1.exe");
                        Process.Start(proyecto6exe);
                        break;
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}

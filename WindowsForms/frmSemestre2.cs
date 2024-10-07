using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class frmSemestre2 : Form
    {
        public frmSemestre2()
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
                    lblDetalle.Text = " Calculadora de deudas y pagos.";
                    break;
                case 1:
                    lblDetalle.Text = " Sistema de listas y estructuras dinámicas.";
                    break;
                case 2:
                    lblDetalle.Text = " Gestor de clientes y generador de reportes.";
                    break;
                case 3:
                    lblDetalle.Text = " Sistema de escritura de archivos de texto.";
                    break;
                case 4:
                    lblDetalle.Text = " Sistema de gestión de datos y filtros condicionados.";
                    break;
                case 5:
                    lblDetalle.Text = " Sistema de agregado, listado y filtrado de datos.";
                    break;
                case 6:
                    lblDetalle.Text = " Sistema de exportación y filtrado de datos.";
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
                        string rutaExe = System.IO.Path.Combine(proyecto1, @"semestre2\proyecto1_datos\PryTP1\bin\Debug\PryTP1.exe");
                        Process.Start(rutaExe);
                        break;
                    case 1:
                        string proyecto2 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto2exe = System.IO.Path.Combine(proyecto2, @"semestre2\proyecto2_datos\EstructurasDinamicas\bin\Debug\EstructurasDinamicas.exe");
                        Process.Start(proyecto2exe);
                        break;
                    case 2:
                        string proyecto3 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto3exe = System.IO.Path.Combine(proyecto3, @"semestre2\proyecto3_laboratorio\GrabarColumnas\bin\Debug\GrabarColumnas.exe");
                        Process.Start(proyecto3exe);
                        break;
                    case 3:
                        string proyecto4 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto4exe = System.IO.Path.Combine(proyecto4, @"semestre2\proyecto4_laboratorio\ArchivosDeTexto\bin\Debug\ArchivosDeTexto.exe");
                        Process.Start(proyecto4exe);
                        break;
                    case 4:
                        string proyecto5 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto5exe = System.IO.Path.Combine(proyecto5, @"semestre2\proyecto5_laboratorio\clase1.4\bin\Debug\clase1.4.exe");
                        Process.Start(proyecto5exe);
                        break;
                    case 5:
                        string proyecto6 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto6exe = System.IO.Path.Combine(proyecto6, @"semestre2\proyecto6_laboratorio\TP1-LAB2\bin\Debug\TP1-LAB2.exe");
                        Process.Start(proyecto6exe);
                        break;
                    case 6:
                        string proyecto7 = AppDomain.CurrentDomain.BaseDirectory;
                        string proyecto7exe = System.IO.Path.Combine(proyecto7, @"semestre2\proyecto7_laboratorio\tp2_lab2\bin\Debug\tp2_lab2.exe");
                        Process.Start(proyecto7exe);
                        break;
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}

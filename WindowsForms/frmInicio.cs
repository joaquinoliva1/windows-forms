using Proyectos;
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
using System.IO;
using System.Diagnostics;

namespace WindowsForms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            cboProyecto.Enabled = false;
            btnAbrir.Enabled = false;
        }
        private void cboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSemestre.SelectedIndex >= 0)
            {
                cboProyecto.Enabled = true;
                cboProyecto.Items.Clear();
                cboProyecto.Text = "Seleccionar proyecto";
                cboProyecto.SelectedIndex = -1;
                if (cboSemestre.SelectedIndex == 0)
                {
                    CargarItemsDesdeArchivo(@"Lista1.txt");
                }
                if (cboSemestre.SelectedIndex == 1)
                {
                    CargarItemsDesdeArchivo(@"Lista2.txt");
                }
            }
            else
            {
                cboProyecto.Enabled = false;
            }
        }

        private void CargarItemsDesdeArchivo(string archivo)
        {
            try
            {
                string[] lines = File.ReadAllLines(archivo);
                cboProyecto.Items.AddRange(lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ítems: " + ex.Message);
            }
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboSemestre.SelectedIndex == 0)
            {
                switch (cboProyecto.SelectedIndex)
                {
                    case 0:
                        string proyecto1 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe = System.IO.Path.Combine(proyecto1, @"semestre1\operaciones matemáticas básicas\bin\Debug\PryPrimero.exe");
                        Process.Start(rutaExe);
                        break;
                    case 1:
                        string proyecto2 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe2 = System.IO.Path.Combine(proyecto2, @"semestre1\listado y operaciones condicionadas\bin\Debug\pryInmobiliaria.exe");
                        Process.Start(rutaExe2);
                        break;
                    case 2:
                        string proyecto3 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe3 = System.IO.Path.Combine(proyecto3, @"semestre1\estructura condicional y uso de etiquetas\bin\Debug\pryTienda.exe");
                        Process.Start(rutaExe3);
                        break;
                    case 3:
                        string proyecto4 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe4 = System.IO.Path.Combine(proyecto4, @"semestre1\data grid view y arrays\bin\Debug\proyecto1.exe");
                        Process.Start(rutaExe4);
                        break;
                    case 4:
                        string proyecto5 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe5 = System.IO.Path.Combine(proyecto5, @"semestre1\diseño de formularios navegables\bin\Debug\PryNewLogistic.exe");
                        Process.Start(rutaExe5);
                        break;
                }
            }
            if (cboSemestre.SelectedIndex == 1)
            {
                switch (cboProyecto.SelectedIndex)
                {
                    case 0:
                        string proyecto1 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe = System.IO.Path.Combine(proyecto1, @"semestre2\programacion orientada a objetos\PryTP1\PryTP1\bin\Debug\PryTP1.exe");
                        Process.Start(rutaExe);
                        break;
                    case 1:
                        string proyecto2 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe2 = System.IO.Path.Combine(proyecto2, @"semestre2\arreglos y tipos de datos\TP1-LAB2\TP1-LAB2\bin\Debug\TP1-LAB2.exe");
                        Process.Start(rutaExe2);
                        break;
                    case 2:
                        string proyecto3 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe3 = System.IO.Path.Combine(proyecto3, @"semestre2\archivos de texto\tp2_lab2\tp2_lab2\bin\Debug\tp2_lab2.exe");
                        Process.Start(rutaExe3);
                        break;
                    case 3:
                        string proyecto4 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe4 = System.IO.Path.Combine(proyecto4, @"semestre2\estructuras dinamicas\datos_estructuras\bin\Debug\EstructurasDinamicas.exe");
                        Process.Start(rutaExe4);
                        break;
                    case 4:
                        string proyecto5 = AppDomain.CurrentDomain.BaseDirectory;
                        string rutaExe5 = System.IO.Path.Combine(proyecto5, @"semestre2\bases de datos\gestion-clientes\gestion-clientes\bin\Debug\gestion-clientes.exe");
                        Process.Start(rutaExe5);
                        break;
                }
            }
            if (cboSemestre.SelectedIndex==-1 || cboProyecto.SelectedIndex==-1)
            {
                btnAbrir.Enabled = false;
                cboProyecto.Enabled = false;
                cboProyecto.SelectedIndex = -1;
                cboSemestre.Text = "Seleccionar periodo";
                cboProyecto.Text = "Selccionar proyecto";
                MessageBox.Show("Debe seleccionar un período y un proyecto.");
            }
        }

        private void lblAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Desarrollador: Joaquin Oliva");
        }

        private void cboProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSemestre.SelectedIndex == -1)
            {
                cboProyecto.Items.Clear();
                cboProyecto.Text = "";
                MessageBox.Show("Seleccione un período válido.");
                btnAbrir.Enabled = false;
            }
            else
            {
                btnAbrir.Enabled = true;
            }
        }
    }
}

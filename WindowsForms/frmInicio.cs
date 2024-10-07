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

namespace WindowsForms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
            ToolTip toolTip1 = new ToolTip(); // Descripción flotante sobre los botones.
            toolTip1.AutoPopDelay = 5000;  // Tiempo que el tooltip permanecerá visible.
            toolTip1.InitialDelay = 400;  // Tiempo que tardará en mostrarse al pasar el cursor.
            toolTip1.ReshowDelay = 0;    // Tiempo entre la ocultación y la nueva aparición.
            toolTip1.SetToolTip(this.btnIngresar, "Ingresar / Enter / Entrer / Entra");
        }
        private void cboSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDetalle.Text = " Presione 'Ver proyectos' y será redireccionado";
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cboSemestre.SelectedIndex == -1)
            {
                lblDetalle.Text = " Seleccione un período.";
                MessageBox.Show("Debe seleccionar un campo.");
            }
            else
            {
                switch (cboSemestre.SelectedIndex)
                {
                    case 0:
                        frmSemestre1 frmSemestre1 = new frmSemestre1();
                        frmSemestre1.FormClosed += (s, args) => this.Show();
                        this.Hide();
                        frmSemestre1.ShowDialog();
                        break;
                    case 1:
                        frmSemestre2 frmSemestre2 = new frmSemestre2();
                        frmSemestre2.FormClosed += (s, args) => this.Show();
                        this.Hide();
                        frmSemestre2.ShowDialog();
                        break;
                }
            }
        }
    }
}

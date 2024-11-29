using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructurasDinamicas
{
    public partial class frmOperacionesSql : Form
    {
        public frmOperacionesSql()
        {
            InitializeComponent();
            dgvDatos.RowHeadersVisible = false;
        }

        clsBaseDatos datos = new clsBaseDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT IdLibro, Titulo FROM Libro";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro, Idioma WHERE Libro.IdIdioma = Idioma.IdIdioma";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE IdAutor > 10";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE IdAutor > 10 AND IdAutor < 20";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE IdAutor > 10 INTERSECT SELECT * FROM Libro WHERE IdIdioma > 5";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string varSql = "SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            lblCommand.Text = varSql;
            datos.Listar(dgvDatos, varSql);
        }
    }
}

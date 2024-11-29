namespace EstructurasDinamicas
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.toolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.subDesarrollador = new System.Windows.Forms.ToolStripMenuItem();
            this.subSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.subCola = new System.Windows.Forms.ToolStripMenuItem();
            this.subPila = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subEnlazadaSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.subEnlazadaDoble = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRamificadas = new System.Windows.Forms.ToolStripMenuItem();
            this.subArbol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subGrafo = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasTool = new System.Windows.Forms.ToolStripMenuItem();
            this.repasoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSistema,
            this.toolLineales,
            this.toolRamificadas,
            this.baseDeDatosToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(800, 25);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
            // 
            // toolSistema
            // 
            this.toolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subDesarrollador,
            this.subSalir});
            this.toolSistema.Name = "toolSistema";
            this.toolSistema.Size = new System.Drawing.Size(65, 21);
            this.toolSistema.Text = "Sistema";
            // 
            // subDesarrollador
            // 
            this.subDesarrollador.Name = "subDesarrollador";
            this.subDesarrollador.Size = new System.Drawing.Size(216, 22);
            this.subDesarrollador.Text = "Datos del desarrollador";
            this.subDesarrollador.Click += new System.EventHandler(this.subDesarrollador_Click);
            // 
            // subSalir
            // 
            this.subSalir.Name = "subSalir";
            this.subSalir.Size = new System.Drawing.Size(216, 22);
            this.subSalir.Text = "Salir";
            this.subSalir.Click += new System.EventHandler(this.subSalir_Click);
            // 
            // toolLineales
            // 
            this.toolLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCola,
            this.subPila,
            this.toolStripSeparator1,
            this.subEnlazadaSimple,
            this.subEnlazadaDoble});
            this.toolLineales.Name = "toolLineales";
            this.toolLineales.Size = new System.Drawing.Size(131, 21);
            this.toolLineales.Text = "Estructuras lineales";
            // 
            // subCola
            // 
            this.subCola.Name = "subCola";
            this.subCola.Size = new System.Drawing.Size(232, 22);
            this.subCola.Text = "Cola";
            this.subCola.Click += new System.EventHandler(this.subCola_Click);
            // 
            // subPila
            // 
            this.subPila.Name = "subPila";
            this.subPila.Size = new System.Drawing.Size(232, 22);
            this.subPila.Text = "Pila";
            this.subPila.Click += new System.EventHandler(this.subPila_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // subEnlazadaSimple
            // 
            this.subEnlazadaSimple.Name = "subEnlazadaSimple";
            this.subEnlazadaSimple.Size = new System.Drawing.Size(232, 22);
            this.subEnlazadaSimple.Text = "Lista enlazada simple";
            this.subEnlazadaSimple.Click += new System.EventHandler(this.subEnlazadaSimple_Click);
            // 
            // subEnlazadaDoble
            // 
            this.subEnlazadaDoble.Name = "subEnlazadaDoble";
            this.subEnlazadaDoble.Size = new System.Drawing.Size(232, 22);
            this.subEnlazadaDoble.Text = "Lista doblemente enlazada";
            this.subEnlazadaDoble.Click += new System.EventHandler(this.subEnlazadaDoble_Click);
            // 
            // toolRamificadas
            // 
            this.toolRamificadas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subArbol,
            this.toolStripSeparator2,
            this.subGrafo});
            this.toolRamificadas.Name = "toolRamificadas";
            this.toolRamificadas.Size = new System.Drawing.Size(155, 21);
            this.toolRamificadas.Text = "Estructuras ramificadas";
            // 
            // subArbol
            // 
            this.subArbol.Name = "subArbol";
            this.subArbol.Size = new System.Drawing.Size(234, 22);
            this.subArbol.Text = "Árbol binario de búsqueda";
            this.subArbol.Click += new System.EventHandler(this.subArbol_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // subGrafo
            // 
            this.subGrafo.Name = "subGrafo";
            this.subGrafo.Size = new System.Drawing.Size(234, 22);
            this.subGrafo.Text = "Grafo";
            this.subGrafo.Click += new System.EventHandler(this.subGrafo_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaSQL,
            this.tablasTool,
            this.repasoTool});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.baseDeDatosToolStripMenuItem.Text = "Base de datos";
            // 
            // consultaSQL
            // 
            this.consultaSQL.Name = "consultaSQL";
            this.consultaSQL.Size = new System.Drawing.Size(252, 22);
            this.consultaSQL.Text = "Consultas en la base de datos";
            this.consultaSQL.Click += new System.EventHandler(this.consultaSQL_Click);
            // 
            // tablasTool
            // 
            this.tablasTool.Name = "tablasTool";
            this.tablasTool.Size = new System.Drawing.Size(252, 22);
            this.tablasTool.Text = "Operaciones con tablas";
            this.tablasTool.Click += new System.EventHandler(this.tablasTool_Click);
            // 
            // repasoTool
            // 
            this.repasoTool.Name = "repasoTool";
            this.repasoTool.Size = new System.Drawing.Size(252, 22);
            this.repasoTool.Text = "Repaso de operaciones";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu1;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Dinámicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem toolSistema;
        private System.Windows.Forms.ToolStripMenuItem subDesarrollador;
        private System.Windows.Forms.ToolStripMenuItem subSalir;
        private System.Windows.Forms.ToolStripMenuItem toolLineales;
        private System.Windows.Forms.ToolStripMenuItem subCola;
        private System.Windows.Forms.ToolStripMenuItem subPila;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem subEnlazadaSimple;
        private System.Windows.Forms.ToolStripMenuItem subEnlazadaDoble;
        private System.Windows.Forms.ToolStripMenuItem toolRamificadas;
        private System.Windows.Forms.ToolStripMenuItem subArbol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem subGrafo;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaSQL;
        private System.Windows.Forms.ToolStripMenuItem tablasTool;
        private System.Windows.Forms.ToolStripMenuItem repasoTool;
    }
}


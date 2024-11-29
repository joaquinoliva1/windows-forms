namespace gestion_clientes
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDesarrollador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolListado = new System.Windows.Forms.ToolStripMenuItem();
            this.toolVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSistema,
            this.toolClientes,
            this.toolVentas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolSistema
            // 
            this.toolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDesarrollador,
            this.toolExit});
            this.toolSistema.Name = "toolSistema";
            this.toolSistema.Size = new System.Drawing.Size(60, 20);
            this.toolSistema.Text = "Sistema";
            // 
            // toolDesarrollador
            // 
            this.toolDesarrollador.Name = "toolDesarrollador";
            this.toolDesarrollador.Size = new System.Drawing.Size(201, 22);
            this.toolDesarrollador.Text = "Acerca del desarrollador";
            this.toolDesarrollador.Click += new System.EventHandler(this.toolDesarrollador_Click);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(201, 22);
            this.toolExit.Text = "Salir";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // toolClientes
            // 
            this.toolClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregar,
            this.toolModificar,
            this.toolBuscar,
            this.toolListado});
            this.toolClientes.Name = "toolClientes";
            this.toolClientes.Size = new System.Drawing.Size(61, 20);
            this.toolClientes.Text = "Clientes";
            // 
            // toolAgregar
            // 
            this.toolAgregar.Name = "toolAgregar";
            this.toolAgregar.Size = new System.Drawing.Size(181, 22);
            this.toolAgregar.Text = "Agregar";
            this.toolAgregar.Click += new System.EventHandler(this.toolAgregar_Click);
            // 
            // toolModificar
            // 
            this.toolModificar.Name = "toolModificar";
            this.toolModificar.Size = new System.Drawing.Size(181, 22);
            this.toolModificar.Text = "Modificar o eliminar";
            this.toolModificar.Click += new System.EventHandler(this.toolModificar_Click);
            // 
            // toolBuscar
            // 
            this.toolBuscar.Name = "toolBuscar";
            this.toolBuscar.Size = new System.Drawing.Size(181, 22);
            this.toolBuscar.Text = "Buscar";
            this.toolBuscar.Click += new System.EventHandler(this.toolBuscar_Click);
            // 
            // toolListado
            // 
            this.toolListado.Name = "toolListado";
            this.toolListado.Size = new System.Drawing.Size(181, 22);
            this.toolListado.Text = "Listado";
            this.toolListado.Click += new System.EventHandler(this.toolListado_Click);
            // 
            // toolVentas
            // 
            this.toolVentas.Name = "toolVentas";
            this.toolVentas.Size = new System.Drawing.Size(53, 20);
            this.toolVentas.Text = "Ventas";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolSistema;
        private System.Windows.Forms.ToolStripMenuItem toolDesarrollador;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
        private System.Windows.Forms.ToolStripMenuItem toolClientes;
        private System.Windows.Forms.ToolStripMenuItem toolVentas;
        private System.Windows.Forms.ToolStripMenuItem toolAgregar;
        private System.Windows.Forms.ToolStripMenuItem toolBuscar;
        private System.Windows.Forms.ToolStripMenuItem toolModificar;
        private System.Windows.Forms.ToolStripMenuItem toolListado;
    }
}


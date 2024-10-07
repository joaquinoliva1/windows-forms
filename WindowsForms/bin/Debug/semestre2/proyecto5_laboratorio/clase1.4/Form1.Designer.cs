namespace clase1._4
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
            this.grpMuestra = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.cboModo = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnDeudores = new System.Windows.Forms.Button();
            this.btnListaCompleta = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblDeudaTotal = new System.Windows.Forms.Label();
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.grpCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMuestra
            // 
            this.grpMuestra.Controls.Add(this.btnOrdenar);
            this.grpMuestra.Controls.Add(this.cboModo);
            this.grpMuestra.Controls.Add(this.cboCampo);
            this.grpMuestra.Controls.Add(this.btnDeudores);
            this.grpMuestra.Controls.Add(this.btnListaCompleta);
            this.grpMuestra.Controls.Add(this.dgvDatos);
            this.grpMuestra.Controls.Add(this.lblDeudaTotal);
            this.grpMuestra.Location = new System.Drawing.Point(11, 168);
            this.grpMuestra.Margin = new System.Windows.Forms.Padding(2);
            this.grpMuestra.Name = "grpMuestra";
            this.grpMuestra.Padding = new System.Windows.Forms.Padding(2);
            this.grpMuestra.Size = new System.Drawing.Size(411, 253);
            this.grpMuestra.TabIndex = 1;
            this.grpMuestra.TabStop = false;
            this.grpMuestra.Text = "Consulta de datos";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenar.Location = new System.Drawing.Point(273, 32);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(117, 21);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // cboModo
            // 
            this.cboModo.FormattingEnabled = true;
            this.cboModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cboModo.Location = new System.Drawing.Point(148, 32);
            this.cboModo.Name = "cboModo";
            this.cboModo.Size = new System.Drawing.Size(121, 21);
            this.cboModo.TabIndex = 6;
            this.cboModo.Text = "Orden";
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Limite",
            "Deuda"});
            this.cboCampo.Location = new System.Drawing.Point(21, 32);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.Text = "Campo";
            // 
            // btnDeudores
            // 
            this.btnDeudores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeudores.Location = new System.Drawing.Point(265, 204);
            this.btnDeudores.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeudores.Name = "btnDeudores";
            this.btnDeudores.Size = new System.Drawing.Size(125, 26);
            this.btnDeudores.TabIndex = 0;
            this.btnDeudores.Text = "Lista de deudores";
            this.btnDeudores.UseVisualStyleBackColor = true;
            this.btnDeudores.Click += new System.EventHandler(this.btnDeudores_Click);
            // 
            // btnListaCompleta
            // 
            this.btnListaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaCompleta.Location = new System.Drawing.Point(265, 204);
            this.btnListaCompleta.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaCompleta.Name = "btnListaCompleta";
            this.btnListaCompleta.Size = new System.Drawing.Size(125, 26);
            this.btnListaCompleta.TabIndex = 0;
            this.btnListaCompleta.Text = "Lista completa";
            this.btnListaCompleta.UseVisualStyleBackColor = true;
            this.btnListaCompleta.Click += new System.EventHandler(this.btnListaCompleta_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(21, 58);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(369, 141);
            this.dgvDatos.TabIndex = 3;
            // 
            // lblDeudaTotal
            // 
            this.lblDeudaTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDeudaTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeudaTotal.Location = new System.Drawing.Point(21, 204);
            this.lblDeudaTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeudaTotal.Name = "lblDeudaTotal";
            this.lblDeudaTotal.Size = new System.Drawing.Size(240, 26);
            this.lblDeudaTotal.TabIndex = 1;
            this.lblDeudaTotal.Text = " Deuda total:   ";
            this.lblDeudaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.txtLimite);
            this.grpCarga.Controls.Add(this.txtNombre);
            this.grpCarga.Controls.Add(this.btnCargar);
            this.grpCarga.Controls.Add(this.txtDeuda);
            this.grpCarga.Controls.Add(this.txtCodigo);
            this.grpCarga.Controls.Add(this.lblLimite);
            this.grpCarga.Controls.Add(this.lblNombre);
            this.grpCarga.Controls.Add(this.lblDeuda);
            this.grpCarga.Controls.Add(this.lblCodigo);
            this.grpCarga.Location = new System.Drawing.Point(11, 11);
            this.grpCarga.Margin = new System.Windows.Forms.Padding(2);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Padding = new System.Windows.Forms.Padding(2);
            this.grpCarga.Size = new System.Drawing.Size(411, 145);
            this.grpCarga.TabIndex = 2;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Carga de datos";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(274, 67);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(104, 20);
            this.txtLimite.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(274, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Location = new System.Drawing.Point(302, 99);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(76, 25);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(74, 67);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(104, 20);
            this.txtDeuda.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 35);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(184, 69);
            this.lblLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(86, 13);
            this.lblLimite.TabIndex = 4;
            this.lblLimite.Text = "Límite de crédito";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(184, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre completo";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(32, 69);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 37);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 441);
            this.Controls.Add(this.grpMuestra);
            this.Controls.Add(this.grpCarga);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.grpMuestra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMuestra;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblDeudaTotal;
        private System.Windows.Forms.GroupBox grpCarga;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnDeudores;
        private System.Windows.Forms.Button btnListaCompleta;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ComboBox cboModo;
        private System.Windows.Forms.ComboBox cboCampo;
    }
}


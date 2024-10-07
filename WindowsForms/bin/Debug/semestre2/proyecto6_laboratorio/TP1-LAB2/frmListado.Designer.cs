namespace TP1_LAB2
{
    partial class frmListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboOrden = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblVendedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCampo
            // 
            this.cboCampo.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Sueldo"});
            this.cboCampo.Location = new System.Drawing.Point(22, 435);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(169, 25);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.Text = " Campo ";
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboOrden
            // 
            this.cboOrden.Enabled = false;
            this.cboOrden.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrden.FormattingEnabled = true;
            this.cboOrden.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cboOrden.Location = new System.Drawing.Point(197, 435);
            this.cboOrden.Name = "cboOrden";
            this.cboOrden.Size = new System.Drawing.Size(169, 25);
            this.cboOrden.TabIndex = 0;
            this.cboOrden.Text = " Orden ";
            this.cboOrden.SelectedIndexChanged += new System.EventHandler(this.cboOrden_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(22, 74);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(428, 355);
            this.dgvDatos.TabIndex = 2;
            // 
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdListar.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(375, 435);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 25);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Aceptar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(30, 20);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(98, 20);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe total:";
            // 
            // lblVendedores
            // 
            this.lblVendedores.AutoSize = true;
            this.lblVendedores.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedores.Location = new System.Drawing.Point(30, 45);
            this.lblVendedores.Name = "lblVendedores";
            this.lblVendedores.Size = new System.Drawing.Size(91, 20);
            this.lblVendedores.TabIndex = 5;
            this.lblVendedores.Text = "Vendedores:";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 489);
            this.Controls.Add(this.lblVendedores);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.cboOrden);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de vendedores";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblVendedores;
        public System.Windows.Forms.ComboBox cboCampo;
        public System.Windows.Forms.ComboBox cboOrden;
    }
}
namespace listado_grafo
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCiudad
            // 
            this.cboCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Items.AddRange(new object[] {
            "Todas las ciudades",
            "Buenos Aires",
            "Córdoba",
            "Rosario",
            "La Plata",
            "Mendoza",
            "Tucumán",
            "Salta",
            "Mar del Plata",
            "Santa Fe",
            "San Juan"});
            this.cboCiudad.Location = new System.Drawing.Point(476, 444);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(177, 28);
            this.cboCiudad.TabIndex = 9;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // cboFiltro
            // 
            this.cboFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.Items.AddRange(new object[] {
            "Todos",
            "Deudores",
            "Solventes"});
            this.cboFiltro.Location = new System.Drawing.Point(659, 444);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(177, 28);
            this.cboFiltro.TabIndex = 10;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 14);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.Size = new System.Drawing.Size(823, 420);
            this.dgvDatos.TabIndex = 7;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReporte.Location = new System.Drawing.Point(13, 444);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(142, 28);
            this.btnReporte.TabIndex = 8;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 489);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnReporte);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Grafo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnReporte;
    }
}


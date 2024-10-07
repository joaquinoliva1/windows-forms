namespace GrabarColumnas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.chkAdeudados = new System.Windows.Forms.CheckBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPromedioDeDeuda = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Location = new System.Drawing.Point(30, 65);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(560, 237);
            this.dgvDatos.TabIndex = 0;
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.btnOrdenar);
            this.grpConsulta.Controls.Add(this.btnReporte);
            this.grpConsulta.Controls.Add(this.chkAdeudados);
            this.grpConsulta.Controls.Add(this.btnListar);
            this.grpConsulta.Controls.Add(this.lblPromedioDeDeuda);
            this.grpConsulta.Controls.Add(this.lblCantidadDeClientes);
            this.grpConsulta.Controls.Add(this.lblPromedio);
            this.grpConsulta.Controls.Add(this.lblTotalDeuda);
            this.grpConsulta.Controls.Add(this.lblTotal);
            this.grpConsulta.Controls.Add(this.dgvDatos);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(27, 25);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(621, 363);
            this.grpConsulta.TabIndex = 1;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta de datos";
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(30, 32);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(130, 25);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // chkAdeudados
            // 
            this.chkAdeudados.AutoSize = true;
            this.chkAdeudados.Location = new System.Drawing.Point(372, 35);
            this.chkAdeudados.Name = "chkAdeudados";
            this.chkAdeudados.Size = new System.Drawing.Size(127, 20);
            this.chkAdeudados.TabIndex = 3;
            this.chkAdeudados.Text = "Solo adeudados";
            this.chkAdeudados.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(505, 32);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 25);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblPromedioDeDeuda
            // 
            this.lblPromedioDeDeuda.AutoSize = true;
            this.lblPromedioDeDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromedioDeDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPromedioDeDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeDeuda.Location = new System.Drawing.Point(414, 317);
            this.lblPromedioDeDeuda.MinimumSize = new System.Drawing.Size(120, 18);
            this.lblPromedioDeDeuda.Name = "lblPromedioDeDeuda";
            this.lblPromedioDeDeuda.Size = new System.Drawing.Size(120, 20);
            this.lblPromedioDeDeuda.TabIndex = 1;
            this.lblPromedioDeDeuda.Text = "                    ";
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCantidadDeClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(40, 274);
            this.lblCantidadDeClientes.MinimumSize = new System.Drawing.Size(120, 18);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(120, 18);
            this.lblCantidadDeClientes.TabIndex = 1;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(299, 319);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(109, 16);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Deuda promedio";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(154, 317);
            this.lblTotalDeuda.MinimumSize = new System.Drawing.Size(120, 18);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(120, 20);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "                    ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(72, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Deuda total";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Location = new System.Drawing.Point(166, 32);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(87, 25);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(675, 418);
            this.Controls.Add(this.grpConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de clientes";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Label lblPromedioDeDeuda;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.CheckBox chkAdeudados;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnOrdenar;
    }
}
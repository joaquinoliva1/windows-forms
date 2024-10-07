namespace proyecto1
{
    partial class frmHorarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.data2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.archivo_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.crear_tool2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarTool = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteSelectedRows = new System.Windows.Forms.Button();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.data2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            // 
            // data2
            // 
            this.data2.AllowUserToAddRows = false;
            this.data2.AllowUserToResizeColumns = false;
            this.data2.AllowUserToResizeRows = false;
            this.data2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data2.BackgroundColor = System.Drawing.Color.Gray;
            this.data2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data2.DefaultCellStyle = dataGridViewCellStyle6;
            this.data2.EnableHeadersVisualStyles = false;
            this.data2.GridColor = System.Drawing.Color.DarkGray;
            this.data2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.data2.Location = new System.Drawing.Point(12, 39);
            this.data2.Name = "data2";
            this.data2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data2.RowHeadersVisible = false;
            this.data2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.data2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.data2.Size = new System.Drawing.Size(622, 294);
            this.data2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo_tool,
            this.crear_tool2,
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo_tool
            // 
            this.archivo_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo_guardar});
            this.archivo_tool.Name = "archivo_tool";
            this.archivo_tool.Size = new System.Drawing.Size(60, 20);
            this.archivo_tool.Text = "Archivo";
            // 
            // archivo_guardar
            // 
            this.archivo_guardar.Image = global::proyecto1.Properties.Resources.checked_checkbox_48_44484;
            this.archivo_guardar.Name = "archivo_guardar";
            this.archivo_guardar.Size = new System.Drawing.Size(118, 22);
            this.archivo_guardar.Text = "Exportar";
            this.archivo_guardar.Click += new System.EventHandler(this.archivo_guardar_Click);
            // 
            // crear_tool2
            // 
            this.crear_tool2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarTool});
            this.crear_tool2.Name = "crear_tool2";
            this.crear_tool2.Size = new System.Drawing.Size(47, 20);
            this.crear_tool2.Text = "Crear";
            // 
            // generarTool
            // 
            this.generarTool.Image = global::proyecto1.Properties.Resources.calendar_48_44940;
            this.generarTool.Name = "generarTool";
            this.generarTool.Size = new System.Drawing.Size(170, 22);
            this.generarTool.Text = "Gestionar horarios";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEmpleadosToolStripMenuItem});
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.volverToolStripMenuItem.Text = "Editar";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // btnDeleteSelectedRows
            // 
            this.btnDeleteSelectedRows.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteSelectedRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedRows.Location = new System.Drawing.Point(12, 310);
            this.btnDeleteSelectedRows.Name = "btnDeleteSelectedRows";
            this.btnDeleteSelectedRows.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteSelectedRows.TabIndex = 4;
            this.btnDeleteSelectedRows.Text = "Borrar selección";
            this.btnDeleteSelectedRows.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedRows.Visible = false;
            this.btnDeleteSelectedRows.Click += new System.EventHandler(this.btnDeleteSelectedRows_Click);
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de empleados";
            this.listaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(646, 345);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeleteSelectedRows);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.data2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            ((System.ComponentModel.ISupportInitialize)(this.data2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.DataGridView data2;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo_tool;
        private System.Windows.Forms.ToolStripMenuItem archivo_guardar;
        private System.Windows.Forms.ToolStripMenuItem crear_tool2;
        private System.Windows.Forms.ToolStripMenuItem generarTool;
        public System.Windows.Forms.Button btnDeleteSelectedRows;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
    }
}


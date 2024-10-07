namespace pryInmobiliaria
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMembrete = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboPiso = new System.Windows.Forms.ComboBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.optAlisado = new System.Windows.Forms.RadioButton();
            this.optFlotante = new System.Windows.Forms.RadioButton();
            this.optPorcelanato = new System.Windows.Forms.RadioButton();
            this.optMadera = new System.Windows.Forms.RadioButton();
            this.optAluminio = new System.Windows.Forms.RadioButton();
            this.grpPiso = new System.Windows.Forms.GroupBox();
            this.grpAberturas = new System.Windows.Forms.GroupBox();
            this.dtgvSubtotales = new System.Windows.Forms.DataGridView();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkCochera = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.grpTipo.SuspendLayout();
            this.grpPiso.SuspendLayout();
            this.grpAberturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubtotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(52, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inmobiliaria CARC";
            // 
            // lblMembrete
            // 
            this.lblMembrete.AutoSize = true;
            this.lblMembrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMembrete.Location = new System.Drawing.Point(54, 64);
            this.lblMembrete.Name = "lblMembrete";
            this.lblMembrete.Size = new System.Drawing.Size(152, 52);
            this.lblMembrete.TabIndex = 1;
            this.lblMembrete.Text = "Inmobiliaria CARC S.A.\r\nRondeau 165, X5000 Córdoba\r\nArgentina\r\nPunto de venta: 00" +
    "01\r\n";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "A. 85 metros cuadrados",
            "B. 52 metros cuadrados",
            "C. 32 metros cuadrados"});
            this.cboDepartamento.Location = new System.Drawing.Point(28, 39);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(226, 23);
            this.cboDepartamento.TabIndex = 12;
            this.cboDepartamento.Text = "Seleccionar departamento";
            // 
            // cboPiso
            // 
            this.cboPiso.FormattingEnabled = true;
            this.cboPiso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboPiso.Location = new System.Drawing.Point(274, 39);
            this.cboPiso.Name = "cboPiso";
            this.cboPiso.Size = new System.Drawing.Size(226, 23);
            this.cboPiso.TabIndex = 15;
            this.cboPiso.Text = "Seleccionar piso";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.cboPiso);
            this.grpTipo.Controls.Add(this.cboDepartamento);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(46, 134);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(546, 95);
            this.grpTipo.TabIndex = 17;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de departamento";
            // 
            // optAlisado
            // 
            this.optAlisado.AutoSize = true;
            this.optAlisado.Location = new System.Drawing.Point(188, 33);
            this.optAlisado.Name = "optAlisado";
            this.optAlisado.Size = new System.Drawing.Size(65, 19);
            this.optAlisado.TabIndex = 17;
            this.optAlisado.TabStop = true;
            this.optAlisado.Text = "Alisado";
            this.optAlisado.UseVisualStyleBackColor = true;
            // 
            // optFlotante
            // 
            this.optFlotante.AutoSize = true;
            this.optFlotante.Location = new System.Drawing.Point(113, 33);
            this.optFlotante.Name = "optFlotante";
            this.optFlotante.Size = new System.Drawing.Size(69, 19);
            this.optFlotante.TabIndex = 17;
            this.optFlotante.TabStop = true;
            this.optFlotante.Text = "Flotante";
            this.optFlotante.UseVisualStyleBackColor = true;
            // 
            // optPorcelanato
            // 
            this.optPorcelanato.AutoSize = true;
            this.optPorcelanato.Location = new System.Drawing.Point(16, 33);
            this.optPorcelanato.Name = "optPorcelanato";
            this.optPorcelanato.Size = new System.Drawing.Size(91, 19);
            this.optPorcelanato.TabIndex = 17;
            this.optPorcelanato.TabStop = true;
            this.optPorcelanato.Text = "Porcelanato";
            this.optPorcelanato.UseVisualStyleBackColor = true;
            // 
            // optMadera
            // 
            this.optMadera.AutoSize = true;
            this.optMadera.Location = new System.Drawing.Point(108, 33);
            this.optMadera.Name = "optMadera";
            this.optMadera.Size = new System.Drawing.Size(68, 19);
            this.optMadera.TabIndex = 17;
            this.optMadera.TabStop = true;
            this.optMadera.Text = "Madera";
            this.optMadera.UseVisualStyleBackColor = true;
            // 
            // optAluminio
            // 
            this.optAluminio.AutoSize = true;
            this.optAluminio.Location = new System.Drawing.Point(28, 33);
            this.optAluminio.Name = "optAluminio";
            this.optAluminio.Size = new System.Drawing.Size(73, 19);
            this.optAluminio.TabIndex = 17;
            this.optAluminio.TabStop = true;
            this.optAluminio.Text = "Aluminio";
            this.optAluminio.UseVisualStyleBackColor = true;
            // 
            // grpPiso
            // 
            this.grpPiso.Controls.Add(this.optPorcelanato);
            this.grpPiso.Controls.Add(this.optFlotante);
            this.grpPiso.Controls.Add(this.optAlisado);
            this.grpPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPiso.Location = new System.Drawing.Point(322, 235);
            this.grpPiso.Name = "grpPiso";
            this.grpPiso.Size = new System.Drawing.Size(270, 78);
            this.grpPiso.TabIndex = 19;
            this.grpPiso.TabStop = false;
            this.grpPiso.Text = "Material del piso";
            // 
            // grpAberturas
            // 
            this.grpAberturas.Controls.Add(this.optAluminio);
            this.grpAberturas.Controls.Add(this.optMadera);
            this.grpAberturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAberturas.Location = new System.Drawing.Point(46, 235);
            this.grpAberturas.Name = "grpAberturas";
            this.grpAberturas.Size = new System.Drawing.Size(270, 78);
            this.grpAberturas.TabIndex = 19;
            this.grpAberturas.TabStop = false;
            this.grpAberturas.Text = "Material de aberturas";
            // 
            // dtgvSubtotales
            // 
            this.dtgvSubtotales.AllowUserToAddRows = false;
            this.dtgvSubtotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubtotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departamento,
            this.Venta,
            this.IVA,
            this.Rentas,
            this.Subtotal});
            this.dtgvSubtotales.Location = new System.Drawing.Point(46, 359);
            this.dtgvSubtotales.Name = "dtgvSubtotales";
            this.dtgvSubtotales.Size = new System.Drawing.Size(544, 105);
            this.dtgvSubtotales.TabIndex = 3;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Venta";
            this.Venta.Name = "Venta";
            this.Venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Rentas
            // 
            this.Rentas.HeaderText = "Rentas";
            this.Rentas.Name = "Rentas";
            this.Rentas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkCochera
            // 
            this.chkCochera.AutoSize = true;
            this.chkCochera.Location = new System.Drawing.Point(46, 479);
            this.chkCochera.Name = "chkCochera";
            this.chkCochera.Size = new System.Drawing.Size(198, 17);
            this.chkCochera.TabIndex = 23;
            this.chkCochera.Text = "Enviar factura por correo electrónico";
            this.chkCochera.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(479, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 25;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIndicacion.Location = new System.Drawing.Point(213, 335);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(377, 13);
            this.lblIndicacion.TabIndex = 26;
            this.lblIndicacion.Text = "*si quiere eliminar un elemento de la lista, seleccionelo y haga click en suprimi" +
    "r.";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(421, 480);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(31, 13);
            this.lblResultado.TabIndex = 27;
            this.lblResultado.Text = "Total";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(320, 475);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imgIcono
            // 
            this.imgIcono.Image = global::pryInmobiliaria.Properties.Resources.carc;
            this.imgIcono.Location = new System.Drawing.Point(499, 35);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(91, 93);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcono.TabIndex = 4;
            this.imgIcono.TabStop = false;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 546);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkCochera);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpPiso);
            this.Controls.Add(this.dtgvSubtotales);
            this.Controls.Add(this.grpAberturas);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.lblMembrete);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria CARC";
            this.grpTipo.ResumeLayout(false);
            this.grpPiso.ResumeLayout(false);
            this.grpPiso.PerformLayout();
            this.grpAberturas.ResumeLayout(false);
            this.grpAberturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubtotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMembrete;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboPiso;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.GroupBox grpPiso;
        private System.Windows.Forms.RadioButton optPorcelanato;
        private System.Windows.Forms.RadioButton optFlotante;
        private System.Windows.Forms.RadioButton optAlisado;
        private System.Windows.Forms.GroupBox grpAberturas;
        private System.Windows.Forms.RadioButton optAluminio;
        private System.Windows.Forms.RadioButton optMadera;
        private System.Windows.Forms.DataGridView dtgvSubtotales;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkCochera;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox imgIcono;
    }
}


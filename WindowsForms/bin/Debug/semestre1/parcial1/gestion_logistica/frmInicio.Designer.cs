namespace PryNewLogistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.chkRecordar = new System.Windows.Forms.CheckBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.cmbIniciar = new System.Windows.Forms.GroupBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.cmbIniciar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIcono
            // 
            this.imgIcono.Image = global::PryNewLogistic.Properties.Resources.Newlogistic;
            this.imgIcono.Location = new System.Drawing.Point(311, 25);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(96, 94);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcono.TabIndex = 0;
            this.imgIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = " NewLogistic";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(50, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(255, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Logística para distancias medias y largas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(33, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(184, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = " Nombre de usuario o entidad";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(36, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(33, 97);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 16);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = " Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(36, 116);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(284, 22);
            this.txtContraseña.TabIndex = 8;
            // 
            // chkRecordar
            // 
            this.chkRecordar.AutoSize = true;
            this.chkRecordar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecordar.Location = new System.Drawing.Point(45, 142);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Size = new System.Drawing.Size(141, 19);
            this.chkRecordar.TabIndex = 9;
            this.chkRecordar.Text = "Recordar contraseña";
            this.chkRecordar.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(36, 250);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(139, 25);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(181, 250);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 25);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "No tengo cuenta";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.BackColor = System.Drawing.Color.Transparent;
            this.optSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSi.Location = new System.Drawing.Point(285, 457);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(34, 17);
            this.optSi.TabIndex = 11;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = false;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.BackColor = System.Drawing.Color.Transparent;
            this.optNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNo.Location = new System.Drawing.Point(325, 457);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(39, 17);
            this.optNo.TabIndex = 11;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(77, 457);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(202, 15);
            this.lblPregunta.TabIndex = 12;
            this.lblPregunta.Text = " ¿Recomendarías nuestro sistema?";
            // 
            // cmbIniciar
            // 
            this.cmbIniciar.Controls.Add(this.lblCiudad);
            this.cmbIniciar.Controls.Add(this.cboCiudad);
            this.cmbIniciar.Controls.Add(this.lblUsuario);
            this.cmbIniciar.Controls.Add(this.txtUsuario);
            this.cmbIniciar.Controls.Add(this.lblContraseña);
            this.cmbIniciar.Controls.Add(this.txtContraseña);
            this.cmbIniciar.Controls.Add(this.btnRegistrar);
            this.cmbIniciar.Controls.Add(this.chkRecordar);
            this.cmbIniciar.Controls.Add(this.btnIniciar);
            this.cmbIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIniciar.Location = new System.Drawing.Point(44, 125);
            this.cmbIniciar.Name = "cmbIniciar";
            this.cmbIniciar.Size = new System.Drawing.Size(363, 305);
            this.cmbIniciar.TabIndex = 13;
            this.cmbIniciar.TabStop = false;
            this.cmbIniciar.Text = "Iniciar sesión";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(33, 180);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(92, 16);
            this.lblCiudad.TabIndex = 12;
            this.lblCiudad.Text = " Ciudad actual";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Items.AddRange(new object[] {
            "Ciudad de Córdoba",
            "Ciudad Autónoma de Buenos Aires",
            "Ciudad de Rosario",
            "Ciudad de Mendoza"});
            this.cboCiudad.Location = new System.Drawing.Point(36, 199);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(284, 24);
            this.cboCiudad.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryNewLogistic.Properties.Resources.Newlogisticfondo21;
            this.pictureBox1.Location = new System.Drawing.Point(-23, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 426);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(170, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(445, 559);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbIniciar);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.optNo);
            this.Controls.Add(this.optSi);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLogistic";
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.cmbIniciar.ResumeLayout(false);
            this.cmbIniciar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.CheckBox chkRecordar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.GroupBox cmbIniciar;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}


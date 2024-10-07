namespace PryNewLogistic
{
    partial class frmAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtencion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cboServicio = new System.Windows.Forms.ComboBox();
            this.lblFranja = new System.Windows.Forms.Label();
            this.chkTarde = new System.Windows.Forms.CheckBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.optMensaje = new System.Windows.Forms.RadioButton();
            this.optCorreo = new System.Windows.Forms.RadioButton();
            this.chkMañana = new System.Windows.Forms.CheckBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(469, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 37);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Atención al cliente";
            // 
            // grpError
            // 
            this.grpError.Controls.Add(this.btnVolver);
            this.grpError.Controls.Add(this.btnEnviar);
            this.grpError.Controls.Add(this.lblNivel);
            this.grpError.Controls.Add(this.cboServicio);
            this.grpError.Controls.Add(this.lblFranja);
            this.grpError.Controls.Add(this.chkTarde);
            this.grpError.Controls.Add(this.lblMetodo);
            this.grpError.Controls.Add(this.optMensaje);
            this.grpError.Controls.Add(this.optCorreo);
            this.grpError.Controls.Add(this.chkMañana);
            this.grpError.Controls.Add(this.lblDescripcion);
            this.grpError.Controls.Add(this.txtDescripcion);
            this.grpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpError.Location = new System.Drawing.Point(50, 131);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(523, 407);
            this.grpError.TabIndex = 15;
            this.grpError.TabStop = false;
            this.grpError.Text = "Informenos su error";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(41, 353);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(407, 353);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(38, 290);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(362, 16);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = " Indique el nivel su nivel de satisfacción con nuestro servicio";
            // 
            // cboServicio
            // 
            this.cboServicio.FormattingEnabled = true;
            this.cboServicio.Items.AddRange(new object[] {
            "Estoy satisfecho",
            "Estoy medianamente satisfecho",
            "No estoy satisfecho"});
            this.cboServicio.Location = new System.Drawing.Point(41, 309);
            this.cboServicio.Name = "cboServicio";
            this.cboServicio.Size = new System.Drawing.Size(441, 24);
            this.cboServicio.TabIndex = 7;
            // 
            // lblFranja
            // 
            this.lblFranja.AutoSize = true;
            this.lblFranja.Location = new System.Drawing.Point(306, 187);
            this.lblFranja.Name = "lblFranja";
            this.lblFranja.Size = new System.Drawing.Size(163, 16);
            this.lblFranja.TabIndex = 6;
            this.lblFranja.Text = "Franja horaria de contacto";
            // 
            // chkTarde
            // 
            this.chkTarde.AutoSize = true;
            this.chkTarde.Location = new System.Drawing.Point(407, 215);
            this.chkTarde.Name = "chkTarde";
            this.chkTarde.Size = new System.Drawing.Size(63, 20);
            this.chkTarde.TabIndex = 5;
            this.chkTarde.Text = "Tarde";
            this.chkTarde.UseVisualStyleBackColor = true;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(38, 187);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(227, 16);
            this.lblMetodo.TabIndex = 4;
            this.lblMetodo.Text = " Deseo recibir la respuesta mediante";
            // 
            // optMensaje
            // 
            this.optMensaje.AutoSize = true;
            this.optMensaje.Location = new System.Drawing.Point(41, 242);
            this.optMensaje.Name = "optMensaje";
            this.optMensaje.Size = new System.Drawing.Size(140, 20);
            this.optMensaje.TabIndex = 3;
            this.optMensaje.TabStop = true;
            this.optMensaje.Text = "Mensaje o llamada";
            this.optMensaje.UseVisualStyleBackColor = true;
            // 
            // optCorreo
            // 
            this.optCorreo.AutoSize = true;
            this.optCorreo.Location = new System.Drawing.Point(41, 216);
            this.optCorreo.Name = "optCorreo";
            this.optCorreo.Size = new System.Drawing.Size(135, 20);
            this.optCorreo.TabIndex = 3;
            this.optCorreo.TabStop = true;
            this.optCorreo.Text = "Correo electrónico";
            this.optCorreo.UseVisualStyleBackColor = true;
            // 
            // chkMañana
            // 
            this.chkMañana.AutoSize = true;
            this.chkMañana.Location = new System.Drawing.Point(309, 215);
            this.chkMañana.Name = "chkMañana";
            this.chkMañana.Size = new System.Drawing.Size(75, 20);
            this.chkMañana.TabIndex = 2;
            this.chkMañana.Text = "Mañana";
            this.chkMañana.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(38, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = " Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(41, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(441, 108);
            this.txtDescripcion.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(283, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(554, 426);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // frmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(626, 593);
            this.Controls.Add(this.grpError);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLogistic - Atención al cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpError.ResumeLayout(false);
            this.grpError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFranja;
        private System.Windows.Forms.CheckBox chkTarde;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.RadioButton optMensaje;
        private System.Windows.Forms.RadioButton optCorreo;
        private System.Windows.Forms.CheckBox chkMañana;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cboServicio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
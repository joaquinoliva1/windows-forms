namespace PryNewLogistic
{
    partial class frmPlanificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanificar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpTransporte = new System.Windows.Forms.GroupBox();
            this.btnRegistrarNuevo = new System.Windows.Forms.Button();
            this.optLargaDistancia = new System.Windows.Forms.RadioButton();
            this.optMediaDistancia = new System.Windows.Forms.RadioButton();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.btnPaquete1 = new System.Windows.Forms.Button();
            this.btnPaquete2 = new System.Windows.Forms.Button();
            this.btnPaquete3 = new System.Windows.Forms.Button();
            this.lblPaquete1 = new System.Windows.Forms.Label();
            this.lblPaquete2 = new System.Windows.Forms.Label();
            this.lblPaquete3 = new System.Windows.Forms.Label();
            this.btnPaquete4 = new System.Windows.Forms.Button();
            this.btnPaquete5 = new System.Windows.Forms.Button();
            this.btnPaquete6 = new System.Windows.Forms.Button();
            this.lblPaquete4 = new System.Windows.Forms.Label();
            this.lblPaquete5 = new System.Windows.Forms.Label();
            this.lblPaquete6 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.grpPaquetes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpTransporte.SuspendLayout();
            this.grpPaquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 37);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Planificación de viaje";
            // 
            // grpTransporte
            // 
            this.grpTransporte.Controls.Add(this.btnRegistrarNuevo);
            this.grpTransporte.Controls.Add(this.optLargaDistancia);
            this.grpTransporte.Controls.Add(this.optMediaDistancia);
            this.grpTransporte.Controls.Add(this.lblVehiculo);
            this.grpTransporte.Controls.Add(this.cboVehiculo);
            this.grpTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTransporte.Location = new System.Drawing.Point(33, 110);
            this.grpTransporte.Name = "grpTransporte";
            this.grpTransporte.Size = new System.Drawing.Size(285, 235);
            this.grpTransporte.TabIndex = 8;
            this.grpTransporte.TabStop = false;
            this.grpTransporte.Text = "Selección de transporte";
            // 
            // btnRegistrarNuevo
            // 
            this.btnRegistrarNuevo.Location = new System.Drawing.Point(28, 81);
            this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            this.btnRegistrarNuevo.Size = new System.Drawing.Size(221, 26);
            this.btnRegistrarNuevo.TabIndex = 5;
            this.btnRegistrarNuevo.Text = "Registrar nuevo vehículo";
            this.btnRegistrarNuevo.UseVisualStyleBackColor = true;
            this.btnRegistrarNuevo.Click += new System.EventHandler(this.btnRegistrarNuevo_Click);
            // 
            // optLargaDistancia
            // 
            this.optLargaDistancia.AutoSize = true;
            this.optLargaDistancia.Location = new System.Drawing.Point(28, 163);
            this.optLargaDistancia.Name = "optLargaDistancia";
            this.optLargaDistancia.Size = new System.Drawing.Size(215, 20);
            this.optLargaDistancia.TabIndex = 4;
            this.optLargaDistancia.TabStop = true;
            this.optLargaDistancia.Text = "Larga distancia (más de 500km)";
            this.optLargaDistancia.UseVisualStyleBackColor = true;
            // 
            // optMediaDistancia
            // 
            this.optMediaDistancia.AutoSize = true;
            this.optMediaDistancia.Location = new System.Drawing.Point(28, 137);
            this.optMediaDistancia.Name = "optMediaDistancia";
            this.optMediaDistancia.Size = new System.Drawing.Size(219, 20);
            this.optMediaDistancia.TabIndex = 4;
            this.optMediaDistancia.TabStop = true;
            this.optMediaDistancia.Text = "Media distancia (100km - 500km)";
            this.optMediaDistancia.UseVisualStyleBackColor = true;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(25, 32);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(62, 16);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = " Vehículo";
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboVehiculo.Items.AddRange(new object[] {
            "AB123CD"});
            this.cboVehiculo.Location = new System.Drawing.Point(28, 51);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(221, 24);
            this.cboVehiculo.TabIndex = 0;
            // 
            // btnPaquete1
            // 
            this.btnPaquete1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete1.Location = new System.Drawing.Point(143, 28);
            this.btnPaquete1.Name = "btnPaquete1";
            this.btnPaquete1.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete1.TabIndex = 2;
            this.btnPaquete1.Text = "Importar lista";
            this.btnPaquete1.UseVisualStyleBackColor = true;
            this.btnPaquete1.Click += new System.EventHandler(this.btnPaquete1_Click);
            // 
            // btnPaquete2
            // 
            this.btnPaquete2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete2.Location = new System.Drawing.Point(143, 59);
            this.btnPaquete2.Name = "btnPaquete2";
            this.btnPaquete2.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete2.TabIndex = 2;
            this.btnPaquete2.Text = "Importar lista";
            this.btnPaquete2.UseVisualStyleBackColor = true;
            this.btnPaquete2.Click += new System.EventHandler(this.btnPaquete2_Click);
            // 
            // btnPaquete3
            // 
            this.btnPaquete3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete3.Location = new System.Drawing.Point(143, 90);
            this.btnPaquete3.Name = "btnPaquete3";
            this.btnPaquete3.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete3.TabIndex = 2;
            this.btnPaquete3.Text = "Importar lista";
            this.btnPaquete3.UseVisualStyleBackColor = true;
            this.btnPaquete3.Click += new System.EventHandler(this.btnPaquete3_Click);
            // 
            // lblPaquete1
            // 
            this.lblPaquete1.AutoSize = true;
            this.lblPaquete1.Location = new System.Drawing.Point(28, 32);
            this.lblPaquete1.Name = "lblPaquete1";
            this.lblPaquete1.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete1.TabIndex = 3;
            this.lblPaquete1.Text = " Paquete 1";
            // 
            // lblPaquete2
            // 
            this.lblPaquete2.AutoSize = true;
            this.lblPaquete2.Location = new System.Drawing.Point(28, 63);
            this.lblPaquete2.Name = "lblPaquete2";
            this.lblPaquete2.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete2.TabIndex = 3;
            this.lblPaquete2.Text = " Paquete 2";
            // 
            // lblPaquete3
            // 
            this.lblPaquete3.AutoSize = true;
            this.lblPaquete3.Location = new System.Drawing.Point(28, 94);
            this.lblPaquete3.Name = "lblPaquete3";
            this.lblPaquete3.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete3.TabIndex = 3;
            this.lblPaquete3.Text = " Paquete 3";
            // 
            // btnPaquete4
            // 
            this.btnPaquete4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete4.Location = new System.Drawing.Point(143, 121);
            this.btnPaquete4.Name = "btnPaquete4";
            this.btnPaquete4.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete4.TabIndex = 2;
            this.btnPaquete4.Text = "Importar lista";
            this.btnPaquete4.UseVisualStyleBackColor = true;
            this.btnPaquete4.Click += new System.EventHandler(this.btnPaquete4_Click);
            // 
            // btnPaquete5
            // 
            this.btnPaquete5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete5.Location = new System.Drawing.Point(143, 152);
            this.btnPaquete5.Name = "btnPaquete5";
            this.btnPaquete5.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete5.TabIndex = 2;
            this.btnPaquete5.Text = "Importar lista";
            this.btnPaquete5.UseVisualStyleBackColor = true;
            this.btnPaquete5.Click += new System.EventHandler(this.btnPaquete5_Click);
            // 
            // btnPaquete6
            // 
            this.btnPaquete6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaquete6.Location = new System.Drawing.Point(143, 183);
            this.btnPaquete6.Name = "btnPaquete6";
            this.btnPaquete6.Size = new System.Drawing.Size(108, 25);
            this.btnPaquete6.TabIndex = 2;
            this.btnPaquete6.Text = "Importar lista";
            this.btnPaquete6.UseVisualStyleBackColor = true;
            this.btnPaquete6.Click += new System.EventHandler(this.btnPaquete6_Click);
            // 
            // lblPaquete4
            // 
            this.lblPaquete4.AutoSize = true;
            this.lblPaquete4.Location = new System.Drawing.Point(28, 125);
            this.lblPaquete4.Name = "lblPaquete4";
            this.lblPaquete4.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete4.TabIndex = 3;
            this.lblPaquete4.Text = " Paquete 4";
            // 
            // lblPaquete5
            // 
            this.lblPaquete5.AutoSize = true;
            this.lblPaquete5.Location = new System.Drawing.Point(28, 156);
            this.lblPaquete5.Name = "lblPaquete5";
            this.lblPaquete5.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete5.TabIndex = 3;
            this.lblPaquete5.Text = " Paquete 5";
            // 
            // lblPaquete6
            // 
            this.lblPaquete6.AutoSize = true;
            this.lblPaquete6.Location = new System.Drawing.Point(28, 187);
            this.lblPaquete6.Name = "lblPaquete6";
            this.lblPaquete6.Size = new System.Drawing.Size(71, 16);
            this.lblPaquete6.TabIndex = 3;
            this.lblPaquete6.Text = " Paquete 6";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(464, 369);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(157, 25);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // grpPaquetes
            // 
            this.grpPaquetes.Controls.Add(this.lblPaquete1);
            this.grpPaquetes.Controls.Add(this.btnPaquete3);
            this.grpPaquetes.Controls.Add(this.btnPaquete4);
            this.grpPaquetes.Controls.Add(this.lblPaquete6);
            this.grpPaquetes.Controls.Add(this.btnPaquete6);
            this.grpPaquetes.Controls.Add(this.btnPaquete2);
            this.grpPaquetes.Controls.Add(this.lblPaquete3);
            this.grpPaquetes.Controls.Add(this.lblPaquete4);
            this.grpPaquetes.Controls.Add(this.btnPaquete1);
            this.grpPaquetes.Controls.Add(this.lblPaquete5);
            this.grpPaquetes.Controls.Add(this.btnPaquete5);
            this.grpPaquetes.Controls.Add(this.lblPaquete2);
            this.grpPaquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaquetes.Location = new System.Drawing.Point(336, 110);
            this.grpPaquetes.Name = "grpPaquetes";
            this.grpPaquetes.Size = new System.Drawing.Size(285, 235);
            this.grpPaquetes.TabIndex = 11;
            this.grpPaquetes.TabStop = false;
            this.grpPaquetes.Text = "Paquetes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(33, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 25);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cerrar sesión";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imgIcon
            // 
            this.imgIcon.Image = global::PryNewLogistic.Properties.Resources.Newlogistic__7_;
            this.imgIcon.Location = new System.Drawing.Point(536, 24);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(85, 80);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 7;
            this.imgIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryNewLogistic.Properties.Resources.Newlogisticfondo2;
            this.pictureBox1.Location = new System.Drawing.Point(259, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 426);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmPlanificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(658, 428);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpPaquetes);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.grpTransporte);
            this.Controls.Add(this.imgIcon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLogistic - Planificar viaje";
            this.grpTransporte.ResumeLayout(false);
            this.grpTransporte.PerformLayout();
            this.grpPaquetes.ResumeLayout(false);
            this.grpPaquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.GroupBox grpTransporte;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnPaquete1;
        private System.Windows.Forms.Label lblPaquete6;
        private System.Windows.Forms.Label lblPaquete3;
        private System.Windows.Forms.Label lblPaquete5;
        private System.Windows.Forms.Label lblPaquete2;
        private System.Windows.Forms.Label lblPaquete4;
        private System.Windows.Forms.Button btnPaquete6;
        private System.Windows.Forms.Label lblPaquete1;
        private System.Windows.Forms.Button btnPaquete5;
        private System.Windows.Forms.Button btnPaquete3;
        private System.Windows.Forms.Button btnPaquete4;
        private System.Windows.Forms.Button btnPaquete2;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.RadioButton optLargaDistancia;
        private System.Windows.Forms.RadioButton optMediaDistancia;
        private System.Windows.Forms.GroupBox grpPaquetes;
        private System.Windows.Forms.Button btnRegistrarNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
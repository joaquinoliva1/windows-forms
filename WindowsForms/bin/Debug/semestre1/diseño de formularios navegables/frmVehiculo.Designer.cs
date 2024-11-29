namespace PryNewLogistic
{
    partial class frmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRegistroVehicular = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkGuardarDatos = new System.Windows.Forms.CheckBox();
            this.optSeguroNo = new System.Windows.Forms.RadioButton();
            this.optSeguroOk = new System.Windows.Forms.RadioButton();
            this.btnImportarLicencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCapacidadVehiculo = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlanificarViaje = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPlanificar = new System.Windows.Forms.PictureBox();
            this.grpRegistroVehicular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanificar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(34, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 37);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Registro de vehículo";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Items.AddRange(new object[] {
            "Moto",
            "Auto",
            "Camioneta",
            "Camión"});
            this.cboTipoVehiculo.Location = new System.Drawing.Point(60, 55);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(157, 24);
            this.cboTipoVehiculo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = " Tipo de vehículo";
            // 
            // txtPatente
            // 
            this.txtPatente.AcceptsReturn = true;
            this.txtPatente.AcceptsTab = true;
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(60, 111);
            this.txtPatente.Multiline = true;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(157, 20);
            this.txtPatente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = " Patente";
            // 
            // grpRegistroVehicular
            // 
            this.grpRegistroVehicular.BackColor = System.Drawing.Color.Transparent;
            this.grpRegistroVehicular.Controls.Add(this.label4);
            this.grpRegistroVehicular.Controls.Add(this.chkGuardarDatos);
            this.grpRegistroVehicular.Controls.Add(this.optSeguroNo);
            this.grpRegistroVehicular.Controls.Add(this.optSeguroOk);
            this.grpRegistroVehicular.Controls.Add(this.btnImportarLicencia);
            this.grpRegistroVehicular.Controls.Add(this.label3);
            this.grpRegistroVehicular.Controls.Add(this.cboCapacidadVehiculo);
            this.grpRegistroVehicular.Controls.Add(this.label2);
            this.grpRegistroVehicular.Controls.Add(this.txtPatente);
            this.grpRegistroVehicular.Controls.Add(this.label1);
            this.grpRegistroVehicular.Controls.Add(this.cboTipoVehiculo);
            this.grpRegistroVehicular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistroVehicular.Location = new System.Drawing.Point(41, 103);
            this.grpRegistroVehicular.Name = "grpRegistroVehicular";
            this.grpRegistroVehicular.Size = new System.Drawing.Size(503, 250);
            this.grpRegistroVehicular.TabIndex = 12;
            this.grpRegistroVehicular.TabStop = false;
            this.grpRegistroVehicular.Text = "Registro vehicular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "¿Cuenta con seguro?";
            // 
            // chkGuardarDatos
            // 
            this.chkGuardarDatos.AutoSize = true;
            this.chkGuardarDatos.BackColor = System.Drawing.Color.Transparent;
            this.chkGuardarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGuardarDatos.Location = new System.Drawing.Point(60, 210);
            this.chkGuardarDatos.Name = "chkGuardarDatos";
            this.chkGuardarDatos.Size = new System.Drawing.Size(267, 20);
            this.chkGuardarDatos.TabIndex = 14;
            this.chkGuardarDatos.Text = "Deseo guardar los datos de mi vehículo.";
            this.chkGuardarDatos.UseVisualStyleBackColor = false;
            // 
            // optSeguroNo
            // 
            this.optSeguroNo.AutoSize = true;
            this.optSeguroNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSeguroNo.Location = new System.Drawing.Point(282, 113);
            this.optSeguroNo.Name = "optSeguroNo";
            this.optSeguroNo.Size = new System.Drawing.Size(43, 20);
            this.optSeguroNo.TabIndex = 17;
            this.optSeguroNo.TabStop = true;
            this.optSeguroNo.Text = "No";
            this.optSeguroNo.UseVisualStyleBackColor = true;
            // 
            // optSeguroOk
            // 
            this.optSeguroOk.AutoSize = true;
            this.optSeguroOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSeguroOk.Location = new System.Drawing.Point(236, 113);
            this.optSeguroOk.Name = "optSeguroOk";
            this.optSeguroOk.Size = new System.Drawing.Size(37, 20);
            this.optSeguroOk.TabIndex = 16;
            this.optSeguroOk.TabStop = true;
            this.optSeguroOk.Text = "Si";
            this.optSeguroOk.UseVisualStyleBackColor = true;
            // 
            // btnImportarLicencia
            // 
            this.btnImportarLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarLicencia.ForeColor = System.Drawing.Color.DarkGray;
            this.btnImportarLicencia.Location = new System.Drawing.Point(60, 150);
            this.btnImportarLicencia.Name = "btnImportarLicencia";
            this.btnImportarLicencia.Size = new System.Drawing.Size(370, 46);
            this.btnImportarLicencia.TabIndex = 15;
            this.btnImportarLicencia.Text = "Importar licencia \r\nde conducir digital";
            this.btnImportarLicencia.UseVisualStyleBackColor = true;
            this.btnImportarLicencia.Click += new System.EventHandler(this.btnImportarLicencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = " Capacidad de carga";
            // 
            // cboCapacidadVehiculo
            // 
            this.cboCapacidadVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCapacidadVehiculo.FormattingEnabled = true;
            this.cboCapacidadVehiculo.Items.AddRange(new object[] {
            "Carga mínima (1kg -100kg)",
            "Carga media (100kg -500kg)",
            "Carga máxima (500kg -1000kg)"});
            this.cboCapacidadVehiculo.Location = new System.Drawing.Point(236, 55);
            this.cboCapacidadVehiculo.Name = "cboCapacidadVehiculo";
            this.cboCapacidadVehiculo.Size = new System.Drawing.Size(194, 24);
            this.cboCapacidadVehiculo.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPlanificarViaje
            // 
            this.btnPlanificarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanificarViaje.Location = new System.Drawing.Point(403, 373);
            this.btnPlanificarViaje.Name = "btnPlanificarViaje";
            this.btnPlanificarViaje.Size = new System.Drawing.Size(141, 25);
            this.btnPlanificarViaje.TabIndex = 13;
            this.btnPlanificarViaje.Text = "Planificar viaje";
            this.btnPlanificarViaje.UseVisualStyleBackColor = true;
            this.btnPlanificarViaje.Click += new System.EventHandler(this.btnPlanificarViaje_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryNewLogistic.Properties.Resources.Newlogisticfondo2;
            this.pictureBox1.Location = new System.Drawing.Point(204, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 426);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // imgPlanificar
            // 
            this.imgPlanificar.Image = global::PryNewLogistic.Properties.Resources.Newlogistic__6_;
            this.imgPlanificar.InitialImage = null;
            this.imgPlanificar.Location = new System.Drawing.Point(442, 12);
            this.imgPlanificar.Name = "imgPlanificar";
            this.imgPlanificar.Size = new System.Drawing.Size(102, 85);
            this.imgPlanificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPlanificar.TabIndex = 6;
            this.imgPlanificar.TabStop = false;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(590, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlanificarViaje);
            this.Controls.Add(this.grpRegistroVehicular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgPlanificar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLogistic - Registro vehicular";
            this.grpRegistroVehicular.ResumeLayout(false);
            this.grpRegistroVehicular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgPlanificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpRegistroVehicular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPatente;
        public System.Windows.Forms.ComboBox cboTipoVehiculo;
        public System.Windows.Forms.ComboBox cboCapacidadVehiculo;
        public System.Windows.Forms.Button btnImportarLicencia;
        public System.Windows.Forms.CheckBox chkGuardarDatos;
        public System.Windows.Forms.Button btnPlanificarViaje;
        public System.Windows.Forms.RadioButton optSeguroNo;
        public System.Windows.Forms.RadioButton optSeguroOk;
        private System.Windows.Forms.Button button1;
    }
}
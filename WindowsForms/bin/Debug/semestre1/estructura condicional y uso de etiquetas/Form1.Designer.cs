namespace PryTiendaDeRopa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpSeleccionar = new GroupBox();
            cboMeses = new ComboBox();
            label2 = new Label();
            cboSucursal = new ComboBox();
            label1 = new Label();
            grpReportes = new GroupBox();
            opt5 = new RadioButton();
            opt4 = new RadioButton();
            opt3 = new RadioButton();
            opt2 = new RadioButton();
            opt1 = new RadioButton();
            grpInforme = new GroupBox();
            lblInforme = new Label();
            btnConsultar = new Button();
            grpSeleccionar.SuspendLayout();
            grpReportes.SuspendLayout();
            grpInforme.SuspendLayout();
            SuspendLayout();
            // 
            // grpSeleccionar
            // 
            grpSeleccionar.Controls.Add(cboMeses);
            grpSeleccionar.Controls.Add(label2);
            grpSeleccionar.Controls.Add(cboSucursal);
            grpSeleccionar.Controls.Add(label1);
            grpSeleccionar.Location = new Point(24, 24);
            grpSeleccionar.Name = "grpSeleccionar";
            grpSeleccionar.Size = new Size(302, 122);
            grpSeleccionar.TabIndex = 0;
            grpSeleccionar.TabStop = false;
            grpSeleccionar.Text = "Seleccionar";
            // 
            // cboMeses
            // 
            cboMeses.FormattingEnabled = true;
            cboMeses.Location = new Point(95, 65);
            cboMeses.Name = "cboMeses";
            cboMeses.Size = new Size(121, 23);
            cboMeses.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 68);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(95, 36);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(121, 23);
            cboSucursal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Sucursal";
            // 
            // grpReportes
            // 
            grpReportes.Controls.Add(opt5);
            grpReportes.Controls.Add(opt4);
            grpReportes.Controls.Add(opt3);
            grpReportes.Controls.Add(opt2);
            grpReportes.Controls.Add(opt1);
            grpReportes.Location = new Point(24, 152);
            grpReportes.Name = "grpReportes";
            grpReportes.Size = new Size(302, 178);
            grpReportes.TabIndex = 1;
            grpReportes.TabStop = false;
            grpReportes.Text = "Reportes";
            // 
            // opt5
            // 
            opt5.AutoSize = true;
            opt5.Location = new Point(28, 131);
            opt5.Name = "opt5";
            opt5.Size = new Size(200, 19);
            opt5.TabIndex = 0;
            opt5.TabStop = true;
            opt5.Text = "Venta anual (todas las sucursales)";
            opt5.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            opt4.AutoSize = true;
            opt4.Location = new Point(28, 106);
            opt4.Name = "opt4";
            opt4.Size = new Size(232, 19);
            opt4.TabIndex = 0;
            opt4.TabStop = true;
            opt4.Text = "Ventas mensuales (todas las sucursales)\r\n";
            opt4.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            opt3.AutoSize = true;
            opt3.Location = new Point(28, 81);
            opt3.Name = "opt3";
            opt3.Size = new Size(216, 19);
            opt3.TabIndex = 0;
            opt3.TabStop = true;
            opt3.Text = "Venta mensual (todas las sucursales)";
            opt3.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            opt2.AutoSize = true;
            opt2.Location = new Point(28, 56);
            opt2.Name = "opt2";
            opt2.Size = new Size(160, 19);
            opt2.TabIndex = 0;
            opt2.TabStop = true;
            opt2.Text = "Venta anual de la sucursal";
            opt2.UseVisualStyleBackColor = true;
            // 
            // opt1
            // 
            opt1.AutoSize = true;
            opt1.Location = new Point(28, 31);
            opt1.Name = "opt1";
            opt1.Size = new Size(176, 19);
            opt1.TabIndex = 0;
            opt1.TabStop = true;
            opt1.Text = "Venta mensual de la sucursal";
            opt1.UseVisualStyleBackColor = true;
            // 
            // grpInforme
            // 
            grpInforme.Controls.Add(lblInforme);
            grpInforme.Location = new Point(332, 24);
            grpInforme.Name = "grpInforme";
            grpInforme.Size = new Size(200, 306);
            grpInforme.TabIndex = 2;
            grpInforme.TabStop = false;
            grpInforme.Text = "Informe";
            // 
            // lblInforme
            // 
            lblInforme.AutoSize = true;
            lblInforme.Location = new Point(23, 36);
            lblInforme.MaximumSize = new Size(143, 0);
            lblInforme.Name = "lblInforme";
            lblInforme.Size = new Size(143, 30);
            lblInforme.TabIndex = 0;
            lblInforme.Text = "Aquí aparecerá el informe\r\nsegún la selección.";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(457, 346);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 397);
            Controls.Add(btnConsultar);
            Controls.Add(grpInforme);
            Controls.Add(grpReportes);
            Controls.Add(grpSeleccionar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tienda de ropa";
            grpSeleccionar.ResumeLayout(false);
            grpSeleccionar.PerformLayout();
            grpReportes.ResumeLayout(false);
            grpReportes.PerformLayout();
            grpInforme.ResumeLayout(false);
            grpInforme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSeleccionar;
        private ComboBox cboMeses;
        private Label label2;
        private ComboBox cboSucursal;
        private Label label1;
        private GroupBox grpReportes;
        private RadioButton opt5;
        private RadioButton opt4;
        private RadioButton opt3;
        private RadioButton opt2;
        private RadioButton opt1;
        private GroupBox grpInforme;
        private Label lblInforme;
        private Button btnConsultar;
    }
}

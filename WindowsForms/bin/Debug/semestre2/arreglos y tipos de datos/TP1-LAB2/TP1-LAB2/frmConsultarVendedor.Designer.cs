namespace TP1_LAB2
{
    partial class frmConsultarVendedor
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
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.grpDatosVendedor = new System.Windows.Forms.GroupBox();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatosVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(35, 40);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(76, 20);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(35, 78);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(35, 116);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(57, 20);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBuscar.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(266, 43);
            this.cmdBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(126, 25);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // grpDatosVendedor
            // 
            this.grpDatosVendedor.Controls.Add(this.lblSueldo);
            this.grpDatosVendedor.Controls.Add(this.lblCodigo);
            this.grpDatosVendedor.Controls.Add(this.lblVendedor);
            this.grpDatosVendedor.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosVendedor.Location = new System.Drawing.Point(24, 82);
            this.grpDatosVendedor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDatosVendedor.Name = "grpDatosVendedor";
            this.grpDatosVendedor.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpDatosVendedor.Size = new System.Drawing.Size(368, 174);
            this.grpDatosVendedor.TabIndex = 6;
            this.grpDatosVendedor.TabStop = false;
            this.grpDatosVendedor.Text = "Datos encontrados";
            // 
            // txtIngresar
            // 
            this.txtIngresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngresar.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIngresar.Location = new System.Drawing.Point(24, 43);
            this.txtIngresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(236, 25);
            this.txtIngresar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre o código del vendedor";
            // 
            // frmConsultarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.grpDatosVendedor);
            this.Controls.Add(this.cmdBuscar);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmConsultarVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar vendedor";
            this.grpDatosVendedor.ResumeLayout(false);
            this.grpDatosVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox grpDatosVendedor;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Label label1;
    }
}
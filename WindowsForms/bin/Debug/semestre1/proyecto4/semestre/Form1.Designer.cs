namespace semestre
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.optNX = new System.Windows.Forms.RadioButton();
            this.optBBVA = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(33, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(266, 24);
            this.txtValor.TabIndex = 0;
            // 
            // optNX
            // 
            this.optNX.AutoSize = true;
            this.optNX.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNX.Location = new System.Drawing.Point(33, 76);
            this.optNX.Name = "optNX";
            this.optNX.Size = new System.Drawing.Size(266, 23);
            this.optNX.TabIndex = 0;
            this.optNX.Text = "Naranja X - 6 pagos / 10% adicional";
            this.optNX.UseVisualStyleBackColor = true;
            // 
            // optBBVA
            // 
            this.optBBVA.AutoSize = true;
            this.optBBVA.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBBVA.Location = new System.Drawing.Point(33, 106);
            this.optBBVA.Name = "optBBVA";
            this.optBBVA.Size = new System.Drawing.Size(238, 23);
            this.optBBVA.TabIndex = 0;
            this.optBBVA.Text = "BBVA - 6 pagos / 30% adicional";
            this.optBBVA.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Checked = true;
            this.optEfectivo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEfectivo.Location = new System.Drawing.Point(33, 135);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(238, 23);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo - 1 pago / sin adicional";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(30, 241);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(0, 16);
            this.lblCuota.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(29, 222);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 19);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Valor total:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(33, 178);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(266, 24);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAumento
            // 
            this.lblAumento.AutoSize = true;
            this.lblAumento.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAumento.ForeColor = System.Drawing.Color.Red;
            this.lblAumento.Location = new System.Drawing.Point(30, 18);
            this.lblAumento.Name = "lblAumento";
            this.lblAumento.Size = new System.Drawing.Size(0, 14);
            this.lblAumento.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 283);
            this.Controls.Add(this.lblAumento);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.optEfectivo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.optBBVA);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.optNX);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semestre IES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.RadioButton optBBVA;
        private System.Windows.Forms.RadioButton optNX;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblAumento;
    }
}


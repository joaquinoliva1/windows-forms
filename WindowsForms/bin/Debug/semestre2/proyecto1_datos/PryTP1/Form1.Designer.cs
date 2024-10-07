namespace PryTP1
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
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblDeudas = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(36, 34);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(56, 13);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "IMPORTE";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(98, 31);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(132, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(39, 84);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(88, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(142, 84);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(88, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDeudas
            // 
            this.lblDeudas.AutoSize = true;
            this.lblDeudas.Location = new System.Drawing.Point(36, 140);
            this.lblDeudas.Name = "lblDeudas";
            this.lblDeudas.Size = new System.Drawing.Size(45, 13);
            this.lblDeudas.TabIndex = 4;
            this.lblDeudas.Text = "DEUDA";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(98, 140);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(130, 13);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "                                         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 201);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblDeudas);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblImporte);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular deuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblDeudas;
        private System.Windows.Forms.Label lblDeuda;
    }
}


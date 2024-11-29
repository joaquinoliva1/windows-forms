namespace PryPrimero
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            this.TxtValorUno = new System.Windows.Forms.TextBox();
            this.TxtValorDos = new System.Windows.Forms.TextBox();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtValorUno
            // 
            this.TxtValorUno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtValorUno.Location = new System.Drawing.Point(28, 41);
            this.TxtValorUno.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtValorUno.Name = "TxtValorUno";
            this.TxtValorUno.Size = new System.Drawing.Size(130, 27);
            this.TxtValorUno.TabIndex = 0;
            this.TxtValorUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtValorDos
            // 
            this.TxtValorDos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtValorDos.Location = new System.Drawing.Point(186, 41);
            this.TxtValorDos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtValorDos.Name = "TxtValorDos";
            this.TxtValorDos.Size = new System.Drawing.Size(130, 27);
            this.TxtValorDos.TabIndex = 1;
            this.TxtValorDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSumar
            // 
            this.BtnSumar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSumar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSumar.Location = new System.Drawing.Point(141, 152);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(54, 54);
            this.BtnSumar.TabIndex = 3;
            this.BtnSumar.Text = "➕";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // BtnRestar
            // 
            this.BtnRestar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRestar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnRestar.Location = new System.Drawing.Point(223, 152);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(54, 54);
            this.BtnRestar.TabIndex = 4;
            this.BtnRestar.Text = "➖";
            this.BtnRestar.UseVisualStyleBackColor = true;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnMultiplicar.Location = new System.Drawing.Point(141, 224);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(54, 54);
            this.BtnMultiplicar.TabIndex = 5;
            this.BtnMultiplicar.Text = "✖️";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDividir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnDividir.Location = new System.Drawing.Point(223, 224);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(54, 54);
            this.BtnDividir.TabIndex = 6;
            this.BtnDividir.Text = "➗";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResultado.BackColor = System.Drawing.SystemColors.Control;
            this.LblResultado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblResultado.Location = new System.Drawing.Point(161, 311);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblResultado.Size = new System.Drawing.Size(94, 24);
            this.LblResultado.TabIndex = 7;
            this.LblResultado.Text = "Resultado";
            this.LblResultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtValorDos);
            this.groupBox1.Controls.Add(this.TxtValorUno);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox1.Location = new System.Drawing.Point(37, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 103);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operación";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.BtnSumar);
            this.Font = new System.Drawing.Font("Calibri", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValorUno;
        private System.Windows.Forms.TextBox TxtValorDos;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


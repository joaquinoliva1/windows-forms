namespace WindowsForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAcercaDe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cboSemestre
            // 
            this.cboSemestre.BackColor = System.Drawing.Color.GhostWhite;
            this.cboSemestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSemestre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Items.AddRange(new object[] {
            " Semestre 1 ",
            " Semestre 2 "});
            this.cboSemestre.Location = new System.Drawing.Point(84, 104);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(316, 29);
            this.cboSemestre.TabIndex = 1;
            this.cboSemestre.Text = "Seleccionar periodo";
            this.cboSemestre.SelectedIndexChanged += new System.EventHandler(this.cboSemestre_SelectedIndexChanged);
            // 
            // cboProyecto
            // 
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProyecto.Location = new System.Drawing.Point(84, 147);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(316, 29);
            this.cboProyecto.TabIndex = 8;
            this.cboProyecto.Text = "Seleccionar proyecto";
            this.cboProyecto.SelectedIndexChanged += new System.EventHandler(this.cboProyecto_SelectedIndexChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.AccessibleDescription = "";
            this.btnAbrir.AccessibleName = "";
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAbrir.Location = new System.Drawing.Point(220, 209);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(180, 28);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Tag = "";
            this.btnAbrir.Text = "Abrir proyecto";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(79, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mis proyectos en C#";
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.LinkColor = System.Drawing.Color.MediumAquamarine;
            this.lblAcercaDe.Location = new System.Drawing.Point(324, 63);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(75, 20);
            this.lblAcercaDe.TabIndex = 10;
            this.lblAcercaDe.TabStop = true;
            this.lblAcercaDe.Text = "Acerca de";
            this.lblAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAcercaDe_LinkClicked);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(494, 307);
            this.Controls.Add(this.lblAcercaDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSemestre);
            this.Controls.Add(this.cboProyecto);
            this.Controls.Add(this.btnAbrir);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblAcercaDe;
    }
}


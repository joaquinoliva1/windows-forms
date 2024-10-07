namespace Proyectos
{
    partial class frmSemestre2
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetalle.Location = new System.Drawing.Point(62, 40);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(170, 20);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = " Seleccione un proyecto.";
            // 
            // cboProyecto
            // 
            this.cboProyecto.BackColor = System.Drawing.Color.GhostWhite;
            this.cboProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboProyecto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Items.AddRange(new object[] {
            " Proyecto 1 ",
            " Proyecto 2 ",
            " Proyecto 3 ",
            " Proyecto 4 ",
            " Proyecto 5 ",
            " Proyecto 6 ",
            " Proyecto 7 "});
            this.cboProyecto.Location = new System.Drawing.Point(66, 74);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(191, 28);
            this.cboProyecto.TabIndex = 5;
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
            this.btnAbrir.Location = new System.Drawing.Point(277, 74);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(148, 28);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Tag = "";
            this.btnAbrir.Text = "Abrir proyecto";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmSemestre2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(494, 164);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.cboProyecto);
            this.Controls.Add(this.btnAbrir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSemestre2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir un proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Button btnAbrir;
    }
}
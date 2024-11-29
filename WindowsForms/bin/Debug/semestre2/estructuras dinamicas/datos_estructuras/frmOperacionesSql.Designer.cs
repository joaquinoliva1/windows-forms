namespace EstructurasDinamicas
{
    partial class frmOperacionesSql
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.lblCommand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(26, 28);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(742, 285);
            this.dgvDatos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyeccionMultiatributo);
            this.groupBox1.Controls.Add(this.btnProyeccionSimple);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuntar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(15, 100);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(207, 29);
            this.btnJuntar.TabIndex = 0;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyeccionMultiatributo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(15, 65);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(207, 29);
            this.btnProyeccionMultiatributo.TabIndex = 0;
            this.btnProyeccionMultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributo.Click += new System.EventHandler(this.btnProyeccionMultiatributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyeccionSimple.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccionSimple.Location = new System.Drawing.Point(15, 30);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(207, 29);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccionConvolucion);
            this.groupBox2.Controls.Add(this.btnSeleccionSimple);
            this.groupBox2.Controls.Add(this.btnSeleccionMultiatributo);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(279, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones de selección - WHERE";
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionConvolucion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(15, 100);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(207, 29);
            this.btnSeleccionConvolucion.TabIndex = 0;
            this.btnSeleccionConvolucion.Text = "Selección por convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionSimple.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionSimple.Location = new System.Drawing.Point(15, 30);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(207, 29);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionMultiatributo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(15, 65);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(207, 29);
            this.btnSeleccionMultiatributo.TabIndex = 0;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(531, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones algebráicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiferencia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiferencia.Location = new System.Drawing.Point(15, 100);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(207, 29);
            this.btnDiferencia.TabIndex = 0;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnion.Location = new System.Drawing.Point(15, 30);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(207, 29);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterseccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterseccion.Location = new System.Drawing.Point(15, 65);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(207, 29);
            this.btnInterseccion.TabIndex = 0;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoEllipsis = true;
            this.lblCommand.BackColor = System.Drawing.Color.Silver;
            this.lblCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCommand.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.ForeColor = System.Drawing.Color.Green;
            this.lblCommand.Location = new System.Drawing.Point(26, 316);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(742, 46);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "SQL command";
            this.lblCommand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOperacionesSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 546);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmOperacionesSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Label lblCommand;
    }
}
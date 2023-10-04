namespace matricesfinal
{
    partial class Form4
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
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.btnPromedioAlumnos = new System.Windows.Forms.Button();
            this.btnPromedioMasAlto = new System.Windows.Forms.Button();
            this.btnPromedioMasBajo = new System.Windows.Forms.Button();
            this.btnParcialesReprobados = new System.Windows.Forms.Button();
            this.btnDistribucionCalificaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(129, 5);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.Size = new System.Drawing.Size(514, 282);
            this.dgvCalificaciones.TabIndex = 0;
            this.dgvCalificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificaciones_CellContentClick);
            this.dgvCalificaciones.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvCalificaciones_ColumnAdded);
            this.dgvCalificaciones.Click += new System.EventHandler(this.dgvCalificaciones_Click);
            // 
            // btnPromedioAlumnos
            // 
            this.btnPromedioAlumnos.Location = new System.Drawing.Point(56, 303);
            this.btnPromedioAlumnos.Name = "btnPromedioAlumnos";
            this.btnPromedioAlumnos.Size = new System.Drawing.Size(119, 23);
            this.btnPromedioAlumnos.TabIndex = 1;
            this.btnPromedioAlumnos.Text = "Promedio Alumnos";
            this.btnPromedioAlumnos.UseVisualStyleBackColor = true;
            this.btnPromedioAlumnos.Click += new System.EventHandler(this.btnPromedioAlumnos_Click);
            // 
            // btnPromedioMasAlto
            // 
            this.btnPromedioMasAlto.Location = new System.Drawing.Point(217, 303);
            this.btnPromedioMasAlto.Name = "btnPromedioMasAlto";
            this.btnPromedioMasAlto.Size = new System.Drawing.Size(125, 23);
            this.btnPromedioMasAlto.TabIndex = 2;
            this.btnPromedioMasAlto.Text = "Promedio mas alto";
            this.btnPromedioMasAlto.UseVisualStyleBackColor = true;
            this.btnPromedioMasAlto.Click += new System.EventHandler(this.btnPromedioMasAlto_Click);
            // 
            // btnPromedioMasBajo
            // 
            this.btnPromedioMasBajo.Location = new System.Drawing.Point(404, 303);
            this.btnPromedioMasBajo.Name = "btnPromedioMasBajo";
            this.btnPromedioMasBajo.Size = new System.Drawing.Size(133, 23);
            this.btnPromedioMasBajo.TabIndex = 3;
            this.btnPromedioMasBajo.Text = "Promedio mas bajo";
            this.btnPromedioMasBajo.UseVisualStyleBackColor = true;
            this.btnPromedioMasBajo.Click += new System.EventHandler(this.btnPromedioMasBajo_Click);
            // 
            // btnParcialesReprobados
            // 
            this.btnParcialesReprobados.Location = new System.Drawing.Point(588, 302);
            this.btnParcialesReprobados.Name = "btnParcialesReprobados";
            this.btnParcialesReprobados.Size = new System.Drawing.Size(143, 23);
            this.btnParcialesReprobados.TabIndex = 4;
            this.btnParcialesReprobados.Text = "Parciales Reprobados";
            this.btnParcialesReprobados.UseVisualStyleBackColor = true;
            this.btnParcialesReprobados.Click += new System.EventHandler(this.btnParcialesReprobados_Click);
            // 
            // btnDistribucionCalificaciones
            // 
            this.btnDistribucionCalificaciones.Location = new System.Drawing.Point(366, 354);
            this.btnDistribucionCalificaciones.Name = "btnDistribucionCalificaciones";
            this.btnDistribucionCalificaciones.Size = new System.Drawing.Size(75, 23);
            this.btnDistribucionCalificaciones.TabIndex = 5;
            this.btnDistribucionCalificaciones.Text = "Distribución";
            this.btnDistribucionCalificaciones.UseVisualStyleBackColor = true;
            this.btnDistribucionCalificaciones.Click += new System.EventHandler(this.btnDistribucionCalificaciones_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDistribucionCalificaciones);
            this.Controls.Add(this.btnParcialesReprobados);
            this.Controls.Add(this.btnPromedioMasBajo);
            this.Controls.Add(this.btnPromedioMasAlto);
            this.Controls.Add(this.btnPromedioAlumnos);
            this.Controls.Add(this.dgvCalificaciones);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.Button btnPromedioAlumnos;
        private System.Windows.Forms.Button btnPromedioMasAlto;
        private System.Windows.Forms.Button btnPromedioMasBajo;
        private System.Windows.Forms.Button btnParcialesReprobados;
        private System.Windows.Forms.Button btnDistribucionCalificaciones;
    }
}
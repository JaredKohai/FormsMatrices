namespace matricesfinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnVerificarInicio = new System.Windows.Forms.Button();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnVerificarResultado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dgvSumas = new System.Windows.Forms.DataGridView();
            this.btnIrAEjercicio1 = new System.Windows.Forms.Button();
            this.btnIrAEjercicio2 = new System.Windows.Forms.Button();
            this.btnIrAEjercicio3 = new System.Windows.Forms.Button();
            this.btnIrAEjercicio4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acortar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(294, 350);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 1;
            this.txtTamaño.TextChanged += new System.EventHandler(this.txtTamaño_TextChanged);
            // 
            // btnVerificarInicio
            // 
            this.btnVerificarInicio.Location = new System.Drawing.Point(262, 84);
            this.btnVerificarInicio.Name = "btnVerificarInicio";
            this.btnVerificarInicio.Size = new System.Drawing.Size(214, 23);
            this.btnVerificarInicio.TabIndex = 2;
            this.btnVerificarInicio.Text = "Generar Matriz Aleatoria";
            this.btnVerificarInicio.UseVisualStyleBackColor = true;
            this.btnVerificarInicio.Click += new System.EventHandler(this.btnVerificarInicio_Click);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(47, 113);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(300, 204);
            this.dgvMatriz.TabIndex = 3;
            this.dgvMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellContentClick);
            // 
            // btnVerificarResultado
            // 
            this.btnVerificarResultado.Location = new System.Drawing.Point(401, 350);
            this.btnVerificarResultado.Name = "btnVerificarResultado";
            this.btnVerificarResultado.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarResultado.TabIndex = 4;
            this.btnVerificarResultado.Text = "Calcular";
            this.btnVerificarResultado.UseVisualStyleBackColor = true;
            this.btnVerificarResultado.Click += new System.EventHandler(this.btnVerificarResultado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(515, 357);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(31, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "____";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // dgvSumas
            // 
            this.dgvSumas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumas.Location = new System.Drawing.Point(395, 116);
            this.dgvSumas.Name = "dgvSumas";
            this.dgvSumas.Size = new System.Drawing.Size(297, 204);
            this.dgvSumas.TabIndex = 6;
            this.dgvSumas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSumas_CellContentClick);
            // 
            // btnIrAEjercicio1
            // 
            this.btnIrAEjercicio1.Location = new System.Drawing.Point(51, 13);
            this.btnIrAEjercicio1.Name = "btnIrAEjercicio1";
            this.btnIrAEjercicio1.Size = new System.Drawing.Size(75, 23);
            this.btnIrAEjercicio1.TabIndex = 8;
            this.btnIrAEjercicio1.Text = "Ejercicio 1";
            this.btnIrAEjercicio1.UseVisualStyleBackColor = true;
            this.btnIrAEjercicio1.Click += new System.EventHandler(this.btnIrAEjercicio1_Click);
            // 
            // btnIrAEjercicio2
            // 
            this.btnIrAEjercicio2.Location = new System.Drawing.Point(162, 12);
            this.btnIrAEjercicio2.Name = "btnIrAEjercicio2";
            this.btnIrAEjercicio2.Size = new System.Drawing.Size(75, 23);
            this.btnIrAEjercicio2.TabIndex = 9;
            this.btnIrAEjercicio2.Text = "Ejercicio 2";
            this.btnIrAEjercicio2.UseVisualStyleBackColor = true;
            this.btnIrAEjercicio2.Click += new System.EventHandler(this.btnIrAEjercicio2_Click);
            // 
            // btnIrAEjercicio3
            // 
            this.btnIrAEjercicio3.Location = new System.Drawing.Point(272, 11);
            this.btnIrAEjercicio3.Name = "btnIrAEjercicio3";
            this.btnIrAEjercicio3.Size = new System.Drawing.Size(75, 23);
            this.btnIrAEjercicio3.TabIndex = 10;
            this.btnIrAEjercicio3.Text = "Ejercicio 3";
            this.btnIrAEjercicio3.UseVisualStyleBackColor = true;
            this.btnIrAEjercicio3.Click += new System.EventHandler(this.btnIrAEjercicio3_Click);
            // 
            // btnIrAEjercicio4
            // 
            this.btnIrAEjercicio4.Location = new System.Drawing.Point(384, 10);
            this.btnIrAEjercicio4.Name = "btnIrAEjercicio4";
            this.btnIrAEjercicio4.Size = new System.Drawing.Size(75, 23);
            this.btnIrAEjercicio4.TabIndex = 11;
            this.btnIrAEjercicio4.Text = "Ejercicio 4";
            this.btnIrAEjercicio4.UseVisualStyleBackColor = true;
            this.btnIrAEjercicio4.Click += new System.EventHandler(this.btnIrAEjercicio4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(338, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ejercicio 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalcularSumas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIrAEjercicio4);
            this.Controls.Add(this.btnIrAEjercicio3);
            this.Controls.Add(this.btnIrAEjercicio2);
            this.Controls.Add(this.btnIrAEjercicio1);
            this.Controls.Add(this.dgvSumas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificarResultado);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.btnVerificarInicio);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnVerificarInicio;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnVerificarResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DataGridView dgvSumas;
        private System.Windows.Forms.Button btnIrAEjercicio1;
        private System.Windows.Forms.Button btnIrAEjercicio2;
        private System.Windows.Forms.Button btnIrAEjercicio3;
        private System.Windows.Forms.Button btnIrAEjercicio4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}


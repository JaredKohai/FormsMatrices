namespace matricesfinal
{
    partial class Form2
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
            this.dgvMatrizPrincipal = new System.Windows.Forms.DataGridView();
            this.dgvSumaFilas = new System.Windows.Forms.DataGridView();
            this.dgvSumaColumnas = new System.Windows.Forms.DataGridView();
            this.btnGenerarMatriz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarFilas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrizPrincipal
            // 
            this.dgvMatrizPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizPrincipal.Location = new System.Drawing.Point(80, 62);
            this.dgvMatrizPrincipal.Name = "dgvMatrizPrincipal";
            this.dgvMatrizPrincipal.Size = new System.Drawing.Size(429, 150);
            this.dgvMatrizPrincipal.TabIndex = 0;
            this.dgvMatrizPrincipal.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvMatrizPrincipal_ColumnAdded);
            // 
            // dgvSumaFilas
            // 
            this.dgvSumaFilas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaFilas.Location = new System.Drawing.Point(548, 62);
            this.dgvSumaFilas.Name = "dgvSumaFilas";
            this.dgvSumaFilas.Size = new System.Drawing.Size(202, 150);
            this.dgvSumaFilas.TabIndex = 1;
            // 
            // dgvSumaColumnas
            // 
            this.dgvSumaColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaColumnas.Location = new System.Drawing.Point(80, 228);
            this.dgvSumaColumnas.Name = "dgvSumaColumnas";
            this.dgvSumaColumnas.Size = new System.Drawing.Size(429, 113);
            this.dgvSumaColumnas.TabIndex = 2;
            // 
            // btnGenerarMatriz
            // 
            this.btnGenerarMatriz.Location = new System.Drawing.Point(240, 33);
            this.btnGenerarMatriz.Name = "btnGenerarMatriz";
            this.btnGenerarMatriz.Size = new System.Drawing.Size(117, 23);
            this.btnGenerarMatriz.TabIndex = 3;
            this.btnGenerarMatriz.Text = "Generar Matriz";
            this.btnGenerarMatriz.UseVisualStyleBackColor = true;
            this.btnGenerarMatriz.Click += new System.EventHandler(this.btnGenerarMatriz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(362, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ejercicio 2";
            // 
            // btnActualizarFilas
            // 
            this.btnActualizarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarFilas.Location = new System.Drawing.Point(592, 228);
            this.btnActualizarFilas.Name = "btnActualizarFilas";
            this.btnActualizarFilas.Size = new System.Drawing.Size(107, 76);
            this.btnActualizarFilas.TabIndex = 5;
            this.btnActualizarFilas.Text = "Suma y Promedio\r\nActualizar";
            this.btnActualizarFilas.UseVisualStyleBackColor = true;
            this.btnActualizarFilas.Click += new System.EventHandler(this.btnActualizarColumnasYFilas_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarFilas);
            this.Controls.Add(this.btnGenerarMatriz);
            this.Controls.Add(this.dgvSumaColumnas);
            this.Controls.Add(this.dgvSumaFilas);
            this.Controls.Add(this.dgvMatrizPrincipal);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrizPrincipal;
        private System.Windows.Forms.DataGridView dgvSumaFilas;
        private System.Windows.Forms.DataGridView dgvSumaColumnas;
        private System.Windows.Forms.Button btnGenerarMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarFilas;
    }
}
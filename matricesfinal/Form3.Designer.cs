namespace matricesfinal
{
    partial class Form3
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnMenorVenta = new System.Windows.Forms.Button();
            this.btnMayorVenta = new System.Windows.Forms.Button();
            this.btnVentaTotal = new System.Windows.Forms.Button();
            this.btnVentaPorDia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(96, 29);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(620, 366);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            this.dgvVentas.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.NoGrid);
            // 
            // btnMenorVenta
            // 
            this.btnMenorVenta.Location = new System.Drawing.Point(135, 401);
            this.btnMenorVenta.Name = "btnMenorVenta";
            this.btnMenorVenta.Size = new System.Drawing.Size(94, 23);
            this.btnMenorVenta.TabIndex = 1;
            this.btnMenorVenta.Text = "Menor Venta";
            this.btnMenorVenta.UseVisualStyleBackColor = true;
            this.btnMenorVenta.Click += new System.EventHandler(this.btnMenorVenta_Click);
            // 
            // btnMayorVenta
            // 
            this.btnMayorVenta.Location = new System.Drawing.Point(259, 401);
            this.btnMayorVenta.Name = "btnMayorVenta";
            this.btnMayorVenta.Size = new System.Drawing.Size(100, 23);
            this.btnMayorVenta.TabIndex = 2;
            this.btnMayorVenta.Text = "Mayor Venta";
            this.btnMayorVenta.UseVisualStyleBackColor = true;
            this.btnMayorVenta.Click += new System.EventHandler(this.btnMayorVenta_Click);
            // 
            // btnVentaTotal
            // 
            this.btnVentaTotal.Location = new System.Drawing.Point(429, 401);
            this.btnVentaTotal.Name = "btnVentaTotal";
            this.btnVentaTotal.Size = new System.Drawing.Size(110, 23);
            this.btnVentaTotal.TabIndex = 3;
            this.btnVentaTotal.Text = "Venta total";
            this.btnVentaTotal.UseVisualStyleBackColor = true;
            this.btnVentaTotal.Click += new System.EventHandler(this.btnVentaTotal_Click);
            // 
            // btnVentaPorDia
            // 
            this.btnVentaPorDia.Location = new System.Drawing.Point(575, 401);
            this.btnVentaPorDia.Name = "btnVentaPorDia";
            this.btnVentaPorDia.Size = new System.Drawing.Size(116, 23);
            this.btnVentaPorDia.TabIndex = 4;
            this.btnVentaPorDia.Text = "Venta por dia";
            this.btnVentaPorDia.UseVisualStyleBackColor = true;
            this.btnVentaPorDia.Click += new System.EventHandler(this.btnVentaPorDia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ventas - Ejercicio 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para guardar\r\ncambios\r\npresiones aquí:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(722, 142);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCambios.TabIndex = 7;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVentaPorDia);
            this.Controls.Add(this.btnVentaTotal);
            this.Controls.Add(this.btnMayorVenta);
            this.Controls.Add(this.btnMenorVenta);
            this.Controls.Add(this.dgvVentas);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnMenorVenta;
        private System.Windows.Forms.Button btnMayorVenta;
        private System.Windows.Forms.Button btnVentaTotal;
        private System.Windows.Forms.Button btnVentaPorDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}
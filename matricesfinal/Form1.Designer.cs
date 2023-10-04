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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTamañoCuadrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSumaFilas = new System.Windows.Forms.DataGridView();
            this.dgvSumaColumnas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acortar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(75, 160);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 1;
            this.txtTamaño.TextChanged += new System.EventHandler(this.txtTamaño_TextChanged);
            // 
            // btnVerificarInicio
            // 
            this.btnVerificarInicio.Location = new System.Drawing.Point(121, 68);
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
            this.dgvMatriz.Location = new System.Drawing.Point(196, 97);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(323, 204);
            this.dgvMatriz.TabIndex = 3;
            this.dgvMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellContentClick);
            this.dgvMatriz.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.False);
            // 
            // btnVerificarResultado
            // 
            this.btnVerificarResultado.Location = new System.Drawing.Point(40, 186);
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
            this.lblResultado.Location = new System.Drawing.Point(7, 224);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(327, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ejercicio 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar sumas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalcularSumas_Click);
            // 
            // txtTamañoCuadrado
            // 
            this.txtTamañoCuadrado.Location = new System.Drawing.Point(15, 71);
            this.txtTamañoCuadrado.Name = "txtTamañoCuadrado";
            this.txtTamañoCuadrado.Size = new System.Drawing.Size(100, 20);
            this.txtTamañoCuadrado.TabIndex = 14;
            this.txtTamañoCuadrado.TextChanged += new System.EventHandler(this.txtTamañoCuadrado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingresa las dimensiones";
            // 
            // dgvSumaFilas
            // 
            this.dgvSumaFilas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaFilas.Location = new System.Drawing.Point(535, 97);
            this.dgvSumaFilas.Name = "dgvSumaFilas";
            this.dgvSumaFilas.Size = new System.Drawing.Size(116, 204);
            this.dgvSumaFilas.TabIndex = 16;
            // 
            // dgvSumaColumnas
            // 
            this.dgvSumaColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaColumnas.Location = new System.Drawing.Point(196, 307);
            this.dgvSumaColumnas.Name = "dgvSumaColumnas";
            this.dgvSumaColumnas.Size = new System.Drawing.Size(323, 74);
            this.dgvSumaColumnas.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(532, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "En caso de modificar datos de la tabla\r\ndebe sumar nuevamente. Presione el\r\nsigui" +
    "ente boton";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 39);
            this.label5.TabIndex = 19;
            this.label5.Text = "Seleccionar al tamaño que\r\nquieras, si quiere volver a calcular\r\nel que tiene, in" +
    "gresa el tamaño actual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSumaColumnas);
            this.Controls.Add(this.dgvSumaFilas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTamañoCuadrado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificarResultado);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.btnVerificarInicio);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaColumnas)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTamañoCuadrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSumaFilas;
        private System.Windows.Forms.DataGridView dgvSumaColumnas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


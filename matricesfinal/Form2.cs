using System;
using System.Windows.Forms;

namespace matricesfinal
{
    public partial class Form2 : Form
    {
        private int[,] matrizPrincipal; // Almacena la matriz principal.

        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            // Genera una matriz aleatoria de 5x10.
            Random random = new Random();
            matrizPrincipal = new int[5, 10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrizPrincipal[i, j] = random.Next(1, 10); // Números aleatorios entre 1 y 10.
                }
            }

            // Llena el DataGridView dgvMatrizPrincipal con la matriz generada.
            LlenarDataGridViewConMatriz(matrizPrincipal, dgvMatrizPrincipal);
        }

        private void btnActualizarColumnasYFilas_Click(object sender, EventArgs e)
        {
            if (matrizPrincipal == null)
            {
                MessageBox.Show("Genera primero la matriz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Sale de la acción si la matriz no se ha generado.
            }

            // Calcula y muestra las sumas y promedios de las columnas.
            CalcularSumasYPromediosColumnas(matrizPrincipal, dgvSumaColumnas);

            // Calcula y muestra las sumas y promedios de las filas.
            CalcularSumasYPromediosFilas(matrizPrincipal, dgvSumaFilas);
        }



        private void btnActualizarColumnas_Click(object sender, EventArgs e)
        {
            // Calcula y muestra las sumas y promedios de las columnas.
            CalcularSumasYPromediosColumnas(matrizPrincipal, dgvSumaColumnas);
        }

        private void btnActualizarFilas_Click(object sender, EventArgs e)
        {
            // Calcula y muestra las sumas y promedios de las filas.
            CalcularSumasYPromediosFilas(matrizPrincipal, dgvSumaFilas);
        }


        private void LlenarDataGridViewConMatriz(int[,] matriz, DataGridView dataGridView)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Agrega las columnas al DataGridView.
            for (int j = 0; j < columnas; j++)
            {
                dataGridView.Columns.Add($"Col{j + 1}", $"Col{j + 1}");
            }

            // Llena el DataGridView con los valores de la matriz.
            for (int i = 0; i < filas; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < columnas; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell
                    {
                        Value = matriz[i, j].ToString()
                    });
                }
                dataGridView.Rows.Add(row);
            }
        }

        private void CalcularSumasYPromediosColumnas(int[,] matriz, DataGridView dataGridView)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Calcula las sumas y promedios de columnas.
            for (int j = 0; j < columnas; j++)
            {
                int suma = 0;
                double promedio = 0;

                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }

                promedio = (double)suma / filas;

                // Agrega la suma y el promedio en la misma celda separados por una barra diagonal.
                dataGridView.Columns.Add($"Col{j + 1}", $"Suma: {suma} / Promedio: {promedio.ToString("F2")}");
            }
        }


        private void CalcularSumasYPromediosFilas(int[,] matriz, DataGridView dataGridView)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Agrega las columnas al DataGridView.
            for (int j = 0; j < filas; j++)
            {
                dataGridView.Columns.Add($"Fila{j + 1}", "");
            }

            // Calcula las sumas y promedios de filas.
            for (int i = 0; i < filas; i++)
            {
                int suma = 0;
                double promedio = 0;

                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }

                promedio = (double)suma / columnas;

                dataGridView.Rows.Add(suma.ToString(), promedio.ToString("F2"));
            }
        }

    }
}

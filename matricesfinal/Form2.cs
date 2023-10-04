using System;
using System.Linq;
using System.Windows.Forms;

namespace matricesfinal
{
    public partial class Form2 : Form
    {
        private int[,] matrizPrincipal; 

        public Form2()
        {
            InitializeComponent();
        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            matrizPrincipal = new int[5, 10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrizPrincipal[i, j] = random.Next(1, 10); 
                }
            }
            LlenarDataGridViewConMatriz(matrizPrincipal, dgvMatrizPrincipal);
        }

        private void btnActualizarColumnasYFilas_Click(object sender, EventArgs e)
        {
            if (matrizPrincipal == null)
            {
                MessageBox.Show("Genera primero la matriz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            CalcularSumasYPromediosColumnas(matrizPrincipal, dgvSumaColumnas);

            CalcularSumasYPromediosFilas(matrizPrincipal, dgvSumaFilas);
        }



        private void btnActualizarColumnas_Click(object sender, EventArgs e)
        {
            CalcularSumasYPromediosColumnas(matrizPrincipal, dgvSumaColumnas);
        }

        private void btnActualizarFilas_Click(object sender, EventArgs e)
        {
            CalcularSumasYPromediosFilas(matrizPrincipal, dgvSumaFilas);
        }


        private void LlenarDataGridViewConMatriz(int[,] matriz, DataGridView dataGridView)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int j = 0; j < columnas; j++)
            {
                dataGridView.Columns.Add($"Col{j + 1}", $"Col{j + 1}");
            }

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

            int[] C = new int[columnas];
            double[] D = new double[columnas];

            for (int j = 0; j < columnas; j++)
            {
                int suma = 0;

                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }

                double promedio = (double)suma / filas;

                C[j] = suma;

                D[j] = promedio;
            }

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int j = 0; j < columnas; j++)
            {
                dataGridView.Columns.Add($"Col{j + 1}", $"Col{j + 1}");
            }

            dataGridView.Rows.Add(C.Select(value => value.ToString()).ToArray());

            dataGridView.Rows.Add(D.Select(value => value.ToString("F2")).ToArray());

        }




        private void CalcularSumasYPromediosFilas(int[,] matriz, DataGridView dataGridView)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            for (int j = 0; j < filas; j++)
            {
                dataGridView.Columns.Add($"Fila{j + 1}", "");
            }

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

        private void dgvMatrizPrincipal_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dgvMatrizPrincipal.ReadOnly = true; 
            dgvMatrizPrincipal.AllowUserToAddRows = false; 

            dgvMatrizPrincipal.AllowUserToOrderColumns = false;
            dgvMatrizPrincipal.AllowUserToResizeColumns = false;
            dgvMatrizPrincipal.AllowUserToResizeRows = false;
        }
    }
}

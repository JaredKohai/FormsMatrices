using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matricesfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIrAEjercicio1_Click(object sender, EventArgs e)
        {

            Form1 ejercicio1Form = new Form1();
            ejercicio1Form.Show();
        }
        private void btnIrAEjercicio2_Click(object sender, EventArgs e)
        {

            Form2 ejercicio2Formjb = new Form2();
            ejercicio2Formjb.Show();
        }
        private void btnIrAEjercicio3_Click(object sender, EventArgs e)
        {

            Form3 ejercicio3Form = new Form3();
            ejercicio3Form.Show();
        }
        private void btnIrAEjercicio4_Click(object sender, EventArgs e)
        {

            Form1 ejercicio1Form = new Form1();
            ejercicio1Form.Show();
        }
        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarResultado_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtTamaño.Text, out int tamaño) && tamaño > 0)
            {
                int[,] matriz = new int[tamaño, tamaño];

                // Aqui coloco los datos que ingrese en DataGridView.
                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (int.TryParse(dgvMatriz.Rows[i].Cells[j].Value.ToString(), out int valor))
                        {
                            matriz[i, j] = valor;
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese valores numéricos en todas las celdas.");
                            return;
                        }
                    }
                }

                // Checar si el cuadro es magico
                if (EsCuadroMagico(matriz))
                {
                    int constanteMagica = CalcularConstanteMagica(matriz);
                    lblResultado.Text = $"Es un cuadro mágico. Constante mágica: {constanteMagica}";
                }
                else
                {
                    lblResultado.Text = "No es un cuadro mágico.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tamaño válido.");
            }
        }



        private void dgvMatriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
        private bool EsCuadroMagico(int[,] matriz)
        {
            int tamaño = matriz.GetLength(0);
            int constanteMagica = CalcularConstanteMagica(matriz);

            // Verificar las sumas de filas y columnas.
            for (int i = 0; i < tamaño; i++)
            {
                int sumaFila = 0;
                int sumaColumna = 0;
                for (int j = 0; j < tamaño; j++)
                {
                    sumaFila += matriz[i, j];
                    sumaColumna += matriz[j, i];
                }
                if (sumaFila != constanteMagica || sumaColumna != constanteMagica)
                {
                    return false;
                }
            }

            // Verificar la suma de la diagonal principal.
            int sumaDiagonalPrincipal = 0;
            for (int i = 0; i < tamaño; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
            }
            if (sumaDiagonalPrincipal != constanteMagica)
            {
                return false;
            }

            // Verificar la suma de la diagonal secundaria paa el caso de que sea mayor a 1x1
            if (tamaño > 1)
            {
                int sumaDiagonalSecundaria = 0;
                for (int i = 0; i < tamaño; i++)
                {
                    sumaDiagonalSecundaria += matriz[i, tamaño - 1 - i];
                }
                if (sumaDiagonalSecundaria != constanteMagica)
                {
                    return false;
                }
            }

            return true;
        }


        private int CalcularConstanteMagica(int[,] matriz)
        {
            int tamaño = matriz.GetLength(0);
            int sumaFila = 0;

            // Sumar los valores de la primera fila
            for (int j = 0; j < tamaño; j++)
            {
                sumaFila += matriz[0, j];
            }

            return sumaFila;
        }
        private void LlenarDataGridViewConMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Configura el DataGridView para que coincida con el tamaño de la matriz
            dgvMatriz.RowCount = filas;
            dgvMatriz.ColumnCount = columnas;

            // Llena el DataGridView con los valores de la matriz.
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvMatriz.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                }
            }
        }

        private void btnLlenarMatriz_Click(object sender, EventArgs e)
        {
            // Definir el tamaño de la matriz aquí
            int filas = 5; 
            int columnas = 5; 

            
            Random random = new Random();

            int[,] matriz = new int[filas, columnas];

            // Entre que numeros los aleatorios
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1, 9); 
                }
            }

            // Llama a la función para llenar el DataGridView con la matriz generada aleatoriamente.
            LlenarDataGridViewConMatriz(matriz);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularSumas()
        {
            int filas = dgvMatriz.RowCount;
            int columnas = dgvMatriz.ColumnCount;

            int[,] matriz = new int[filas, columnas];

            // Obtén los valores de las celdas del DataGridView y llénalos en la matriz
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (int.TryParse(dgvMatriz.Rows[i].Cells[j].Value?.ToString(), out int valor))
                    {
                        matriz[i, j] = valor;
                    }
                    else
                    {
                        matriz[i, j] = 0; // Si no es un número válido, se pone 0 en vez de null
                    }
                }
            }

            // Calcula las sumas de filas y columnas
            int[] sumasFilas = new int[filas];
            int[] sumasColumnas = new int[columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    sumasFilas[i] += matriz[i, j];
                    sumasColumnas[j] += matriz[i, j];
                }
            }

            // Crea una nueva tabla de datos para mostrar las sumas.
            DataTable tablaSumas = new DataTable();
            tablaSumas.Columns.Add("Suma de Filas");
            tablaSumas.Columns.Add("Suma de Columnas");

            // Llena la tabla con las sumas.
            for (int i = 0; i < filas; i++)
            {
                tablaSumas.Rows.Add(sumasFilas[i], "");
            }

            for (int j = 0; j < columnas; j++)
            {
                tablaSumas.Rows.Add("", sumasColumnas[j]);
            }

            // Enlaza la tabla de datos al DataGridView.
            dgvSumas.DataSource = tablaSumas;
        }

        private void btnCalcularSumas_Click(object sender, EventArgs e)
        {
            CalcularSumas();
        }

        private void dgvSumas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnVerificarInicio_Click(object sender, EventArgs e)
        {
            btnLlenarMatriz_Click(sender, e);
            btnCalcularSumas_Click(sender, e);
        }
    }
}

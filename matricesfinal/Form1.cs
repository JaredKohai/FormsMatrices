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

        private void dgvMatriz_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!int.TryParse(e.FormattedValue.ToString(), out int valor))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico.");
                e.Cancel = true; 
            }
            else
            {
                int tamaño = dgvMatriz.RowCount;
                if (e.RowIndex >= tamaño || e.ColumnIndex >= tamaño)
                {
                    MessageBox.Show("No puede ingresar datos fuera de los límites de la tabla.");
                    e.Cancel = true; 
                }
            }
        }

        private int ObtenerTamañoDesdeTextBox(string valorTextBox)
        {
            if (int.TryParse(valorTextBox, out int tamaño) && tamaño > 0)
            {
                return tamaño;
            }
            else
            {
                return 3; 
            }
        }



        private void txtTamaño_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarResultado_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamaño.Text, out int tamaño) && tamaño > 0)
            {
                int[,] matriz = new int[tamaño, tamaño];

                if (dgvMatriz.RowCount < tamaño || dgvMatriz.ColumnCount < tamaño)
                {
                    MessageBox.Show("La tabla es de menor tamaño.");
                    return;
                }

                for (int i = 0; i < tamaño; i++)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (int.TryParse(dgvMatriz.Rows[i].Cells[j].Value?.ToString(), out int valor))
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

            int sumaDiagonalPrincipal = 0;
            for (int i = 0; i < tamaño; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
            }
            if (sumaDiagonalPrincipal != constanteMagica)
            {
                return false;
            }

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

            dgvMatriz.RowCount = filas;
            dgvMatriz.ColumnCount = columnas;

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
            if (int.TryParse(txtTamañoCuadrado.Text, out int tamaño) && tamaño > 0)
            {
                int filas = tamaño;
                int columnas = tamaño;

                Random random = new Random();

                int[,] matriz = new int[filas, columnas];

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matriz[i, j] = random.Next(1, 10);
                    }
                }

                LlenarDataGridViewConMatriz(matriz);

                if (EsCuadroMagico(matriz))
                {
                    int constanteMagica = CalcularConstanteMagica(matriz);
                    MessageBox.Show($"Es un cuadro mágico. Constante mágica: {constanteMagica}");
                }
                else
                {
                    MessageBox.Show("No es un cuadro mágico.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un tamaño válido (entero mayor que 0).");
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

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

        private void txtTamañoCuadrado_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalcularSumas()
        {
            int filas = dgvMatriz.RowCount;
            int columnas = dgvMatriz.ColumnCount;

            int[,] matriz = new int[filas, columnas];

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
                        matriz[i, j] = 0;
                    }
                }
            }

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

            DataTable tablaSumasFilas = new DataTable();
            tablaSumasFilas.Columns.Add("Suma de Filas");

            for (int i = 0; i < filas; i++)
            {
                tablaSumasFilas.Rows.Add(sumasFilas[i]);
            }

            dgvSumaFilas.DataSource = tablaSumasFilas;

            DataTable tablaSumasColumnas = new DataTable();

            for (int j = 0; j < columnas; j++)
            {
                tablaSumasColumnas.Columns.Add($"Columna {j + 1}");
            }

            DataRow fila = tablaSumasColumnas.NewRow();
            for (int j = 0; j < columnas; j++)
            {
                fila[j] = sumasColumnas[j];
            }
            tablaSumasColumnas.Rows.Add(fila);

            dgvSumaColumnas.DataSource = tablaSumasColumnas;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void False(object sender, DataGridViewColumnEventArgs e)
        {
            dgvMatriz.ReadOnly = false; 
            dgvMatriz.AllowUserToAddRows = false;

            int tamaño = ObtenerTamañoDesdeTextBox(txtTamañoCuadrado.Text); 
            dgvMatriz.ColumnCount = tamaño;

            dgvMatriz.AllowUserToOrderColumns = false;
            dgvMatriz.AllowUserToResizeColumns = false;
            dgvMatriz.AllowUserToResizeRows = false;
        }
    }
}

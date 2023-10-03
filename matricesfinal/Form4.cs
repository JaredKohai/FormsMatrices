using System;
using System.Linq;
using System.Windows.Forms;

namespace matricesfinal
{
    public partial class Form4 : Form
    {
        private double[,] calificaciones = new double[,]
        {
            { 5.5, 8.6, 10 },
            { 8.0, 5.5, 10 },
            { 9.0, 4.1, 7.8 },
            { 10, 2.2, 8.1 },
            { 7.0, 9.2, 7.1 },
            { 9.0, 4.0, 6.0 },
            { 6.5, 5.0, 5.0 },
            { 4.0, 7.0, 4.0 },
            { 8.0, 8.0, 9.0 },
            { 10, 9.0, 9.2 },
            { 5.0, 10, 8.4 },
            { 9.0, 4.6, 7.5 }
        };

        public Form4()
        {
            InitializeComponent();
            LlenarDataGridViewConMatriz();
        }

        private void LlenarDataGridViewConMatriz()
        {
            int filas = calificaciones.GetLength(0);
            int columnas = calificaciones.GetLength(1);

            dgvCalificaciones.RowCount = filas + 1;
            dgvCalificaciones.ColumnCount = columnas + 1;

            // Agrega el encabezado de las columnas (Parciales)
            for (int j = 0; j < columnas; j++)
            {
                dgvCalificaciones.Columns[j + 1].HeaderText = $"Parcial {j + 1}";
            }

            // Agrega el encabezado de las filas (Alumnos)
            for (int i = 0; i < filas; i++)
            {
                dgvCalificaciones.Rows[i + 1].HeaderCell.Value = $"Alumno {i + 1}";
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvCalificaciones.Rows[i + 1].Cells[j + 1].Value = calificaciones[i, j];
                }
            }
        }

        private void btnParcialesReprobados_Click(object sender, EventArgs e)
        {
            int reprobados = 0;

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                for (int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    if (calificaciones[i, j] < 7.0)
                    {
                        reprobados++;
                    }
                }
            }

            MessageBox.Show($"Parciales reprobados: {reprobados}");
        }

        private void btnPromedioMasBajo_Click(object sender, EventArgs e)
        {
            double promedioMasBajo = CalcularPromedioMasBajo();
            MessageBox.Show($"El promedio más bajo es: {promedioMasBajo}");
        }

        private void btnPromedioMasAlto_Click(object sender, EventArgs e)
        {
            double promedioMasAlto = CalcularPromedioMasAlto();
            MessageBox.Show($"El promedio más alto es: {promedioMasAlto}");
        }

        private void btnPromedioAlumnos_Click(object sender, EventArgs e)
        {
            CalcularPromedioAlumnos();
        }

        private void btnDistribucionCalificaciones_Click(object sender, EventArgs e)
        {
            CalcularDistribucionCalificaciones();
        }

        private double CalcularPromedioMasBajo()
        {
            double promedioMasBajo = calificaciones[0, 0];

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double promedioAlumno = calificaciones.Cast<double>()
                    .Skip(i * calificaciones.GetLength(1))
                    .Take(calificaciones.GetLength(1))
                    .Average();

                if (promedioAlumno < promedioMasBajo)
                {
                    promedioMasBajo = promedioAlumno;
                }
            }

            return promedioMasBajo;
        }

        private double CalcularPromedioMasAlto()
        {
            double promedioMasAlto = calificaciones[0, 0];

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double promedioAlumno = calificaciones.Cast<double>()
                    .Skip(i * calificaciones.GetLength(1))
                    .Take(calificaciones.GetLength(1))
                    .Average();

                if (promedioAlumno > promedioMasAlto)
                {
                    promedioMasAlto = promedioAlumno;
                }
            }

            return promedioMasAlto;
        }

        private void CalcularPromedioAlumnos()
        {
            string resultado = "Promedio de cada alumno:\n";

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double promedioAlumno = calificaciones.Cast<double>()
                    .Skip(i * calificaciones.GetLength(1))
                    .Take(calificaciones.GetLength(1))
                    .Average();

                resultado += $"Alumno {i + 1}: {promedioAlumno:F2}\n"; 
            }

            MessageBox.Show(resultado);
        }

        private void dgvCalificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CalcularDistribucionCalificaciones()
        {
            int[] distribucion = new int[6]; // Categorías de calificaciones

            foreach (double calificacion in calificaciones)
            {
                if (calificacion >= 0 && calificacion < 5)
                {
                    distribucion[0]++;
                }
                else if (calificacion >= 5 && calificacion < 6)
                {
                    distribucion[1]++;
                }
                else if (calificacion >= 6 && calificacion < 7)
                {
                    distribucion[2]++;
                }
                else if (calificacion >= 7 && calificacion < 8)
                {
                    distribucion[3]++;
                }
                else if (calificacion >= 8 && calificacion < 9)
                {
                    distribucion[4]++;
                }
                else if (calificacion >= 9 && calificacion <= 10)
                {
                    distribucion[5]++;
                }
            }

            string resultado = "Distribución de calificaciones:\n";
            string[] categorias = { "0 - 4.9", "5.0 - 5.9", "6.0 - 6.9", "7.0 - 7.9", "8.0 - 8.9", "9.0 - 10" };

            for (int i = 0; i < distribucion.Length; i++)
            {
                resultado += $"{categorias[i]}: {distribucion[i]} Alumnos\n";
            }

            MessageBox.Show(resultado);
        }
    }
}




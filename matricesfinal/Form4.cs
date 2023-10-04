using System;
using System.Collections.Generic;
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
    { 9.0, 4.6, 7.5 },
     };

        public Form4()
        {
            InitializeComponent();
            LlenarDataGridViewConMatriz();
            dgvCalificaciones.AllowUserToAddRows = true;

            dgvCalificaciones.CellValueChanged += dgvCalificaciones_CellValueChanged;
        }

        private void LlenarDataGridViewConMatriz()
        {
            int filas = calificaciones.GetLength(0);
            int columnas = calificaciones.GetLength(1);

            dgvCalificaciones.RowCount = filas;
            dgvCalificaciones.ColumnCount = columnas;

            for (int j = 0; j < columnas; j++)
            {
                dgvCalificaciones.Columns[j].HeaderText = $"Parcial {j + 1}";
            }

            for (int i = 0; i < filas; i++)
            {
                dgvCalificaciones.Rows[i].HeaderCell.Value = $"Alumno {i + 1}";
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvCalificaciones.Rows[i].Cells[j].Value = calificaciones[i, j];
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
            double promedioMasAlto = 0.0;

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double promedioAlumno = 0.0;

                for (int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    promedioAlumno += calificaciones[i, j];
                }

                promedioAlumno /= calificaciones.GetLength(1);

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
            int[] distribucion = new int[6];
            HashSet<int> alumnosReprobados = new HashSet<int>();

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double promedioAlumno = calificaciones.Cast<double>()
                    .Skip(i * calificaciones.GetLength(1))
                    .Take(calificaciones.GetLength(1))
                    .Average();

                if (promedioAlumno < 5.0)
                {
                    distribucion[0]++; 
                    alumnosReprobados.Add(i);
                }
                else if (promedioAlumno >= 5.0 && promedioAlumno < 6.0)
                {
                    distribucion[1]++; 
                }
                else if (promedioAlumno >= 6.0 && promedioAlumno < 7.0)
                {
                    distribucion[2]++; 
                }
                else if (promedioAlumno >= 7.0 && promedioAlumno < 8.0)
                {
                    distribucion[3]++; 
                }
                else if (promedioAlumno >= 8.0 && promedioAlumno < 9.0)
                {
                    distribucion[4]++; 
                }
                else if (promedioAlumno >= 9.0 && promedioAlumno <= 10.0)
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

            resultado = resultado.Replace($"{categorias[0]}: {distribucion[0]} Alumnos", $"{categorias[0]}: {distribucion[0] - alumnosReprobados.Count} Alumnos");

            MessageBox.Show(resultado);
        }



        private void dgvCalificaciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                double nuevoValor;
                if (double.TryParse(dgvCalificaciones.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out nuevoValor))
                {
                    calificaciones[e.RowIndex, e.ColumnIndex] = nuevoValor;
                }
                else
                {
                }
            }
        }

        private void dgvCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void dgvCalificaciones_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dgvCalificaciones.ReadOnly = false; 
            dgvCalificaciones.AllowUserToAddRows = false; 

            dgvCalificaciones.AllowUserToOrderColumns = false;
            dgvCalificaciones.AllowUserToResizeColumns = false;
            dgvCalificaciones.AllowUserToResizeRows = false;
        }
    }
}




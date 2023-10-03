using System;
using System.Linq;
using System.Windows.Forms;

namespace matricesfinal
{
    public partial class Form3 : Form
    {
        private int[,] ventas = new int[,]
        {
            { 5, 16, 10, 12, 24 },
            { 40, 55, 10, 11, 18 },
            { 15, 41, 78, 14, 51 },
            { 35, 22, 81, 15, 12 },
            { 50, 12, 71, 10, 20 },
            { 70, 40, 60, 28, 22 },
            { 50, 50, 50, 36, 25 },
            { 40, 70, 40, 11, 20 },
            { 20, 20, 30, 12, 18 },
            { 10, 40, 32, 13, 16 },
            { 50, 3, 24, 15, 82 },
            { 40, 46, 15, 46, 22 }
        };

        private string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private string[] diasDeLaSemana = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

        public Form3()
        {
            InitializeComponent();
            LlenarDataGridViewConMatriz();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LlenarDataGridViewConMatriz()
        {
            int filas = ventas.GetLength(0);
            int columnas = ventas.GetLength(1);

            dgvVentas.RowCount = filas + 1;
            dgvVentas.ColumnCount = columnas + 1;
            for (int j = 0; j < columnas; j++)
            {
                dgvVentas.Rows[0].Cells[j + 1].Value = $"Día {j + 1}";
            }
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            for (int i = 0; i < filas; i++)
            {
                dgvVentas.Rows[i + 1].Cells[0].Value = meses[i];
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgvVentas.Rows[i + 1].Cells[j + 1].Value = ventas[i, j];
                }
            }
        }

        private int EncontrarMenorVenta(out string mes, out string dia)
        {
            int menorVenta = ventas[0, 0];
            mes = meses[0];
            dia = diasDeLaSemana[0];

            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    if (ventas[i, j] < menorVenta)
                    {
                        menorVenta = ventas[i, j];
                        mes = meses[i];
                        dia = diasDeLaSemana[j];
                    }
                }
            }

            return menorVenta;
        }

        private int EncontrarMayorVenta(out string mes, out string dia)
        {
            int mayorVenta = ventas[0, 0];
            mes = meses[0];
            dia = diasDeLaSemana[0];

            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    if (ventas[i, j] > mayorVenta)
                    {
                        mayorVenta = ventas[i, j];
                        mes = meses[i];
                        dia = diasDeLaSemana[j];
                    }
                }
            }

            return mayorVenta;
        }

        private int CalcularVentaTotal()
        {
            return ventas.Cast<int>().Sum();
        }

        private int[] CalcularVentaPorDia()
        {
            int[] ventasPorDia = new int[ventas.GetLength(1)];

            for (int j = 0; j < ventas.GetLength(1); j++)
            {
                ventasPorDia[j] = Enumerable.Range(0, ventas.GetLength(0))
                    .Sum(i => ventas[i, j]);
            }

            return ventasPorDia;
        }

        private void btnMenorVenta_Click(object sender, EventArgs e)
        {
            int menorVenta = EncontrarMenorVenta(out string mes, out string dia);
            MessageBox.Show($"La menor venta es {menorVenta} en el mes de {mes} y el día {dia}");
        }

        private void btnMayorVenta_Click(object sender, EventArgs e)
        {
            int mayorVenta = EncontrarMayorVenta(out string mes, out string dia);
            MessageBox.Show($"La mayor venta es {mayorVenta} en el mes de {mes} y el día {dia}");
        }

        private void btnVentaTotal_Click(object sender, EventArgs e)
        {
            int ventaTotal = CalcularVentaTotal();
            MessageBox.Show($"Venta Total: {ventaTotal}");
        }

        private void btnVentaPorDia_Click(object sender, EventArgs e)
        {
            int[] ventasPorDia = CalcularVentaPorDia();
            string mensaje = "Ventas por día:\n";

            for (int i = 0; i < ventasPorDia.Length; i++)
            {
                mensaje += $"{diasDeLaSemana[i]}: ${ventasPorDia[i]}\n";
            }

            MessageBox.Show(mensaje);
        }
    }
}

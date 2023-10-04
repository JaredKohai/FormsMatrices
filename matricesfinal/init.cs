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
    public partial class init : Form
    {
        public init()
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
            Form2 ejercicio2Form = new Form2();
            ejercicio2Form.Show();
        }
        private void btnIrAEjercicio3_Click(object sender, EventArgs e)
        {
            Form3 ejercicio3Form = new Form3();
            ejercicio3Form.Show();
        }

        private void btnIrAEjercicio4_Click(object sender, EventArgs e)
        {
            Form4 ejercicio4Form = new Form4();
            ejercicio4Form.Show();
        }
    }
}

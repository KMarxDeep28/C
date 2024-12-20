using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            Form3 Inicio = new Form3();
            Inicio.Show();
            this.Hide();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Form2 Inicio = new Form2();
            Inicio.Show();
            this.Hide();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            Form4 Inicio = new Form4();
            Inicio.Show();
            this.Hide();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            Form5 Inicio = new Form5();
            Inicio.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

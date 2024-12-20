using System;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Contaduria_Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBalanceInicial_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 Inicio = new Form1();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComprobanteDiario_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 Inicio = new Form3();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 Inicio = new Form4();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("¿Esta seguro que desea Borrar todo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    string Datos;
                    char[] Caracteres = { ' ', '\t' };
                    StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\NOMBREDECUENTAS.text");
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        if (File.Exists("E:\\Contaduria\\Cuentas\\" + Datos + ".text") == true)
                        {
                            string Datos1;
                            char[] Caracteres1 = { ' ', '\t' };
                            StreamReader Leer1 = File.OpenText("E:\\Contaduria\\Cuentas\\" + Datos + ".text");
                            while (Leer1.EndOfStream == false)
                            {
                                Datos1 = Leer1.ReadLine();
                                string[] MisDatos1 = Datos1.Split(Caracteres1);
                                if (File.Exists("E:\\Contaduria\\Mayores\\" + Datos1 + ".text") == true)
                                {
                                    File.Delete("E:\\Contaduria\\Mayores\\" + Datos1 + ".text");
                                }
                            }
                            Leer1.Close();
                        }
                    }
                    Leer.Close();
                    File.Delete("E:\\Contaduria\\Balance de Comprobacion.text");
                    File.Delete("E:\\Contaduria\\Hoja de Trabajo.text");
                    StreamReader Leer2 = File.OpenText("E:\\Contaduria\\Cuentas\\Numero.text");
                    int i = Convert.ToInt32(Leer2.ReadLine());
                    Leer2.Close();
                    for (int j = 0; j <= i; j += 1)
                    {
                        if (File.Exists("E:\\Contaduria\\Diarios\\Comprobante diario " + j + ".text") == true)
                        {
                            File.Delete("E:\\Contaduria\\Diarios\\Comprobante diario " + j + ".text");
                        }
                    }
                    File.Delete("E:\\Contaduria\\Cuentas\\Numero.text");
                    StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\Numero.text");
                    Escribir.Write("0".ToString());
                    Escribir.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHojaDeTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 Inicio = new Form5();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 Inicio = new Form6();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form7 Inicio = new Form7();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form8 Inicio = new Form8();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

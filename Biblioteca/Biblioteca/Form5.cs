using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca
{
    
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }
        //List<string> LCodEst = new List<string>();
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Datos;
            string codest;
            char[] Caracteres = { ' ', '\t' };
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                ltbLista.Items.Clear();
                ltbLista.Items.Add("CodLib\tCodEst\tFecha\tEstado");
                ltbLista.Items.Add("======\t======\t=====\t======");
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    codest = MisDatos[1];
                    if (codest == txtEstudiante.Text)
                    {
                        ltbLista.Items.Add(Datos);
                    }
                }
                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            try
            {
                if (File.Exists("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text") == true) 
                {
                    StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        ltbLista.Items.Add(Datos);
                    }
                    Leer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCajas()
        {
            txtEstudiante.Clear();
            txtEstudiante.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            try
            {
                if (File.Exists("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text") == true)
                {
                    StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                    ltbLista.Items.Clear();
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        ltbLista.Items.Add(Datos);
                    }
                    Leer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEstudiante_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ltbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbLista.SelectedIndex > -1)
            {
                textBox1.Text = ltbLista.Items[ltbLista.SelectedIndex].ToString();
            }
            else
            {
                ltbLista.SelectedIndex = 1;
            }
        }
        int encontrado=0;
        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            DialogResult a;
            int cant1;
            string cant,nota,Datos,Datos1;
            char[] Caracteres = { ' ', '\t' };
            char[] Caracteres1 = { ' ', '\t' };
            a = MessageBox.Show("¿Esta seguro que desea realizar la devolucion?", "Devolucion", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos2.text");
                Datos = Leer.ReadLine();
                Escribir.Write(Datos + Environment.NewLine);
                Datos = Leer.ReadLine();
                Escribir.Write(Datos + Environment.NewLine);
                try
                {
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        nota = MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3];
                        if (textBox1.Text == nota && ltbLista.SelectedIndex!=0 && ltbLista.SelectedIndex!=1)
                        {
                            ltbLista.Items.RemoveAt(ltbLista.SelectedIndex);
                            encontrado = 1;
                            StreamReader Leer1 = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                            StreamWriter Escribir1 = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text");
                            Datos1 = Leer1.ReadLine();
                            Escribir1.Write(Datos1 + Environment.NewLine);
                            Datos1 = Leer1.ReadLine();
                            Escribir1.Write(Datos1 + Environment.NewLine);
                            try
                            {
                                while (Leer1.EndOfStream == false)
                                {
                                    Datos1 = Leer1.ReadLine();
                                    string[] MisDatos1 = Datos1.Split(Caracteres1);
                                    cant = MisDatos1[3];
                                    cant1 = Convert.ToInt32(cant);
                                    if (MisDatos[0] == MisDatos1[0])
                                    {
                                        cant1 += 1;
                                        Escribir1.Write(MisDatos1[0] + "\t" + MisDatos1[1] + "\t" + MisDatos1[2] + "\t" + cant1 + Environment.NewLine);
                                    }
                                    else
                                    {
                                        Escribir1.Write(MisDatos1[0] + "\t" + MisDatos1[1] + "\t" + MisDatos1[2] + "\t" + MisDatos1[3] + Environment.NewLine);
                                    }
                                }
                                                    Escribir1.Close();
                            Leer1.Close();
                            File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros3.text");
                        }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                        else
                        {
                                Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                        }
                        
                    }
                    Escribir.Close();
                    Leer.Close();
                    File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos3.text");
                    CargarDatos();
                    if (encontrado == 1)
                    {
                        MessageBox.Show("Devolucion hecha");
                        encontrado = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se pude realizar la devolucion");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CargarDatos()
        {
            StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
            Leer.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

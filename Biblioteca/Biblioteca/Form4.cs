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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text") == false)
            {
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                Escribir.Write("CodLib\tCodEst\tFecha\tEstado" + Environment.NewLine);
                Escribir.Write("======\t======\t=====\t======" + Environment.NewLine);
                Escribir.Close();
            }
            string libro;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            string est = "";
            string Datos1;
            char[] Caracteres1 = { ' ', '\t' };
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                Datos = Leer.ReadLine();
                Datos = Leer.ReadLine();
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    libro = MisDatos[1];
                    cmbLibro.Items.Add(libro);
                }
                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                Datos1 = Leer.ReadLine();
                Datos1 = Leer.ReadLine();
                while (Leer.EndOfStream == false)
                {
                    Datos1 = Leer.ReadLine();
                    string[] MisDatos1 = Datos1.Split(Caracteres1);
                    est = MisDatos1[1];
                    cmbEstudiante.Items.Add(est);
                }

                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtFecha.Text = (System.DateTime.Today.ToShortDateString()).ToString();
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est;
            string Datos1;
            char[] Caracteres1 = { ' ', '\t' };
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                Datos1 = Leer.ReadLine();
                Datos1 = Leer.ReadLine();
                while (Leer.EndOfStream == false)
                {
                    Datos1 = Leer.ReadLine();
                    string[] MisDatos1 = Datos1.Split(Caracteres1);
                    est = MisDatos1[1];
                    if (cmbEstudiante.Text == est)
                    {
                        txtCodEst.Text = MisDatos1[0];
                    }
                }

                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int encontrado = 0;
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            string codigo, libro, area, cant;
            int cant1;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            if (cmbLibro.Text != "" && cmbEstudiante.Text != "" && txtCodEst.Text != "" && txtCodLib.Text != "" && txtFecha.Text != "")
            {
                try
                {
                    StreamWriter Escribir1 = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Prestamos.text");
                    Escribir1.Write(txtCodLib.Text + "\t" + txtCodEst.Text + "\t" + txtFecha.Text + "\t" + "prestado" + Environment.NewLine);
                    Escribir1.Close();
                    StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                    StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text");
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
                            codigo = MisDatos[0];
                            libro = MisDatos[1];
                            area = MisDatos[2];
                            cant = MisDatos[3];
                            cant1 = Convert.ToInt32(cant);
                            if (Convert.ToInt32(cant) > 0 && cmbLibro.Text == MisDatos[1])
                            {
                                cant1 -= 1;
                                Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + cant1 + Environment.NewLine);
                                encontrado = 1;
                            }
                            else
                            {
                                if (cant1 <= 0)
                                {
                                    MessageBox.Show("Prestamo no realizado");
                                    Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                                    encontrado = 0;
                                }
                                else
                                {
                                    Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                                }

                            }
                        }
                        Escribir.Close();
                        Leer.Close();
                        if (encontrado == 1)
                        {
                            MessageBox.Show("Prestamo guardado");
                        }

                        File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros3.text");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los datos o ingrese datos correctos");
            }
        }

        private void txtCodLib_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est;
            string Datos1;
            char[] Caracteres1 = { ' ', '\t' };
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Libros.text");
                Datos1 = Leer.ReadLine();
                Datos1 = Leer.ReadLine();
                while (Leer.EndOfStream == false)
                {
                    Datos1 = Leer.ReadLine();
                    string[] MisDatos1 = Datos1.Split(Caracteres1);
                    est = MisDatos1[1];
                    if (cmbLibro.Text == est)
                    {
                        txtCodLib.Text = MisDatos1[0];
                    }
                }

                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

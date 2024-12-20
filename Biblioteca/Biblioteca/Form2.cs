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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string codigo, libro, area, cant;
            codigo = txtCodigo.Text;
            libro = txtLibro.Text;
            area = cmbArea.Text;
            cant = txtCantidadCopias.Text;
            try
            {
                if (codigo != "" && libro != "" && area != "" && cant != "")
                {
                    StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                    Escribir.Write(codigo + "\t" + libro + "\t" + area + "\t" + cant + Environment.NewLine);
                    Escribir.Close();
                    MessageBox.Show("Libro guardado");
                    LimpiarCajas();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Por favor complete los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimpiarCajas()
        {
            txtCodigo.Clear();
            txtLibro.Clear();
            cmbArea.Text = "";
            txtCantidadCopias.Clear();
            txtCodigo.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text") == false)
            {
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                Escribir.Write("Codigo\tLibro\tArea\tCantidad" + Environment.NewLine);
                Escribir.Write("======\t=====\t====\t========" + Environment.NewLine);
                Escribir.Close();
            }
            else
            {
                CargarDatos();
            }
        }
        private void CargarDatos()
        {
            StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
            txtLista.Text = Leer.ReadToEnd();
            Leer.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }
        string librobuscado;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo, libro, area, cant;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            try
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text");
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    codigo = MisDatos[0];
                    libro = MisDatos[1];
                    area = MisDatos[2];
                    cant = MisDatos[3];
                    if (codigo == txtCodigo.Text)
                    {
                        txtCodigo.Text = codigo;
                        txtLibro.Text = libro;
                        cmbArea.Text = area;
                        txtCantidadCopias.Text = cant;
                        librobuscado = codigo;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                }
                if (librobuscado != txtCodigo.Text)
                {
                    MessageBox.Show("No se encontro el libro");
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                Leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int encontrado = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            string codigo, libro, area, cant;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            a = MessageBox.Show("¿Esta seguro que desea eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
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
                        if (codigo != txtCodigo.Text)
                        {
                            Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                            encontrado = 1;
                        }
                        else
                        {
                            MessageBox.Show("Libro eliminado");
                        }
                    }
                    Escribir.Close();
                    Leer.Close();
                    File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros3.text");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            string codigo, libro, area, cant;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            a = MessageBox.Show("¿Esta seguro que desea Modificarlo?", "Eliminar", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
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
                        if (codigo != txtCodigo.Text)
                        {
                            Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                            encontrado = 1;
                        }
                        else
                        {
                            Escribir.Write(MisDatos[0] + "\t" + txtLibro.Text + "\t" + cmbArea.Text + "\t" + txtCantidadCopias.Text + Environment.NewLine);
                            MessageBox.Show("Libro Modificado");
                        }
                    }
                    if (encontrado != 1)
                    {
                        MessageBox.Show("No se encontro el libro");
                    }
                    Escribir.Close();
                    Leer.Close();
                    File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\libros3.text");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtLista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

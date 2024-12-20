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
    public partial class Form3 : Form
    {
        public Form3()
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
            string codigo, nombre, apellido, tel;
            codigo = txtCodigo.Text;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            tel = txtTelefono.Text; ;
            try
            {
                if (codigo != "" && nombre != "" && apellido != "" && tel != "")
                {
                    StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                    Escribir.Write(codigo + "\t" + nombre + "\t" + apellido + "\t" + tel + Environment.NewLine);
                    Escribir.Close();
                    MessageBox.Show("Estudiante guardado");
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
            txtNombre.Clear();
            txtApellido.Text = "";
            txtTelefono.Clear();
            txtCodigo.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text") == false)
            {
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                Escribir.Write("Codigo\tNombre\tApellido\tTelefono" + Environment.NewLine);
                Escribir.Write("======\t=====\t====\t========" + Environment.NewLine);
                Escribir.Close();
            }
            else
            {
                CargarDatos();
            }
        }
        int encontrado = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            string codigo, nom, ap, tel;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            a = MessageBox.Show("¿Esta seguro que desea eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes2.text");
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
                        nom = MisDatos[1];
                        ap = MisDatos[2];
                        tel = MisDatos[3];
                        if (codigo != txtCodigo.Text)
                        {
                            Escribir.Write(MisDatos[0] + "\t" + MisDatos[1] + "\t" + MisDatos[2] + "\t" + MisDatos[3] + Environment.NewLine);
                            encontrado = 1;
                        }
                        else
                        {
                            MessageBox.Show("Estudiante eliminado");
                        }
                    }
                    Escribir.Close();
                    Leer.Close();
                    File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes3.text");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CargarDatos()
        {
            StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
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
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
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
                        txtNombre.Text = libro;
                        txtApellido.Text = area;
                        txtTelefono.Text = cant;
                        librobuscado = codigo;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                }
                if (librobuscado != txtCodigo.Text)
                {
                    MessageBox.Show("No se encontro el Estudiante");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            string codigo, libro, area, cant;
            string Datos;
            char[] Caracteres = { ' ', '\t' };
            a = MessageBox.Show("¿Esta seguro que desea Modificarlo?", "Eliminar", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                StreamReader Leer = File.OpenText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text");
                StreamWriter Escribir = File.AppendText("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes2.text");
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
                            Escribir.Write(MisDatos[0] + "\t" + txtNombre.Text + "\t" + txtApellido.Text + "\t" + txtTelefono.Text + Environment.NewLine);
                            MessageBox.Show("Datos Modificado");
                        }
                    }
                    if (encontrado != 1)
                    {
                        MessageBox.Show("No se encontro el estudiante");
                    }
                    Escribir.Close();
                    Leer.Close();
                    File.Replace("C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes2.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes.text", "C:\\AR\\Blabalknbwañdojlqdpoi\\Forms windowes\\Textos\\Estudiantes3.text");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}

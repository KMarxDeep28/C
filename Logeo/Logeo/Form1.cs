using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Logeo
{
    public partial class Form1 : Form
    {
        private MySqlConnection conectar = new MySqlConnection(
            "server=sql10.freesqldatabase.com;" +
            "database=sql10744700;" +
            "Uid=sql10744700;" +
            "pwd=dYi8nDNsDi;" +               // Contraseña
            "Port=3306;"
            );
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar.Open();
            MySqlCommand orden = conectar.CreateCommand();
            orden.CommandType = CommandType.Text;
            orden.CommandText = "SELECT *FROM usuario WHERE Nick='" + textBox1.Text + "'AND Contrasenia='" + textBox2.Text+"'";
            MySqlDataReader datos = orden.ExecuteReader();
            if (datos.HasRows)
            {
                    datos.Read();

                    string nick = datos["Nick"].ToString();
                    string nombre = datos["Nombre"].ToString();
                    string apPaterno = datos["Ap_Paterno"].ToString();
                    string apMaterno = datos["Ap_Materno"].ToString();

                    string mensaje = "Nick: " + nick + "\nNombre: " + nombre + " " + apPaterno + " " + apMaterno;

                MessageBox.Show(mensaje, "Datos del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*datos.Read();
                string ver = datos["Nick"].ToString();

                if (ver == "GROBOT")
                {
                    this.Hide();
                    Form3 fadm = new Form3();
                    fadm.Show();
                }
                else
                {
                    this.Hide();
                    Form2 fusu = new Form2();
                    fusu.Show();
                }*/
            
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }

            conectar.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

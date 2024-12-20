using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contaduria_Proyecto
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                string Datos;
                char[] Caracteres = { ' ', '\t' };
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\NOMBREDECUENTAS.text");
                StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Balance de Comprobacion.text");
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
                                cmbMayor.Items.Add(Datos1);
                            }
                        }
                        Leer1.Close();
                    }
                }
                Leer.Close();
                Escribir.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMayor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMayor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvMayor.Rows.Clear();
                string Datos2;
                char[] Caracteres2 = { ' ', '\t' };
                StreamReader Leer2 = File.OpenText("E:\\Contaduria\\Mayores\\" + cmbMayor.Text + ".text");
                while (Leer2.EndOfStream == false)
                {
                    Datos2 = Leer2.ReadLine();
                    string[] MisDatos2 = Datos2.Split(Caracteres2);
                    int a = dgvMayor.Rows.Add();
                    dgvMayor.Rows[a].Cells[0].Value = MisDatos2[0];
                    dgvMayor.Rows[a].Cells[1].Value = MisDatos2[1];
                }
                gbNombre.Text = cmbMayor.Text;
                Leer2.Close();
                double total = 0, total1 = 0;
                foreach (DataGridViewRow row in dgvMayor.Rows)
                {
                    total += Convert.ToDouble(row.Cells["dgvDEBE"].Value);
                    total1 += Convert.ToDouble(row.Cells["dgvHABER"].Value);
                }
               txtDebe.Text = total.ToString();
                txtHaber.Text = total1.ToString();
                textBox2.Text = "0";
                textBox1.Text = "0";
                if (Convert.ToDouble(txtDebe.Text) >= Convert.ToDouble(txtHaber.Text))
                {
                    textBox2.Text = (Convert.ToDouble(txtDebe.Text)- Convert.ToDouble(txtHaber.Text)).ToString();
                }
                else
                {
                    textBox1.Text = (-Convert.ToDouble(txtDebe.Text) + Convert.ToDouble(txtHaber.Text)).ToString();
                }
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
                Form2 Inicio = new Form2();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void exportaraexcel(DataGridView tabla)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = col.HeaderText;
                }
                int IndeceFila = 0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    IndeceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn col in tabla.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                    }

                }
                excel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                exportaraexcel(dgvMayor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Bitmap bitmap;
        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                int alto = gbNombre.Height;
                gbNombre.Height = dgvMayor.RowCount * dgvMayor.RowTemplate.Height * 2;
                bitmap = new Bitmap(gbNombre.Width, gbNombre.Height);
                gbNombre.DrawToBitmap(bitmap, new Rectangle(0, 0, gbNombre.Width, gbNombre.Height));
                gbNombre.Height = alto;
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imagen = new Bitmap(bitmap);
                    imagen.Save(guardar.FileName, ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

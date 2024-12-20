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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("E:\\Contaduria\\Balance de Comprobacion.text") == true)
                {
                    File.Delete("E:\\Contaduria\\Balance de Comprobacion.text");
                }
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
                                string Datos2;
                                char[] Caracteres2 = { ' ', '\t' };
                                StreamReader Leer2 = File.OpenText("E:\\Contaduria\\Mayores\\" + Datos1 + ".text");
                                double debe = 0, haber = 0;
                                while (Leer2.EndOfStream == false)
                                {
                                    Datos2 = Leer2.ReadLine();
                                    string[] MisDatos2 = Datos2.Split(Caracteres2);
                                    debe += Convert.ToDouble(MisDatos2[0]);
                                    haber += Convert.ToDouble(MisDatos2[1]);
                                }
                                double total = debe - haber;
                                double nulo = 0;
                                if (total > 0)
                                {
                                    Escribir.Write(Datos1.ToString() + "\t" + debe.ToString() + "\t" + haber.ToString() + "\t" + total.ToString() + "\t" + nulo.ToString() + Environment.NewLine);
                                }
                                else
                                {
                                    total *= -1;
                                    Escribir.Write(Datos1.ToString() + "\t" + debe.ToString() + "\t" + haber.ToString() + "\t" + nulo.ToString() + "\t" + total.ToString() + Environment.NewLine);
                                }
                                Leer2.Close();
                            }
                        }
                        Leer1.Close();
                    }
                }
                Leer.Close();
                Escribir.Close();
                Balance_comprobacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Balance_comprobacion()
        {
            try
            {
                string Datos;
                char[] Caracteres = { '\t' };
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Balance de Comprobacion.text");
                StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Balance de Comprobacion2.text");
                double deb = 0, habe = 0, deudor = 0, acreedor = 0;
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    Escribir.Write(Datos + Environment.NewLine);
                    deb += Convert.ToDouble(MisDatos[1]);
                    habe += Convert.ToDouble(MisDatos[2]);
                    deudor += Convert.ToDouble(MisDatos[3]);
                    acreedor += Convert.ToDouble(MisDatos[4]);
                }
                Escribir.Write("SUMA DE SALDOS" + "\t" + deb.ToString() + "\t" + habe.ToString() + "\t" + deudor.ToString() + "\t" + acreedor.ToString() + Environment.NewLine);
                Leer.Close();
                Escribir.Close();
                File.Replace("E:\\Contaduria\\Balance de Comprobacion2.text", "E:\\Contaduria\\Balance de Comprobacion.text", "E:\\Contaduria\\Balance de Comprobacion3.text");
                File.Delete("E:\\Contaduria\\Balance de Comprobacion3.text");
                string Datos9;
                char[] Caracteres9 = { '\t' };
                StreamReader Leer9 = File.OpenText("E:\\Contaduria\\Balance de Comprobacion.text");
                while (Leer9.EndOfStream == false)
                {
                    Datos9 = Leer9.ReadLine();
                    string[] MisDatos9 = Datos9.Split(Caracteres9);
                    int a = dgvComprobacion.Rows.Add();
                    dgvComprobacion.Rows[a].Cells[0].Value = MisDatos9[0];
                    dgvComprobacion.Rows[a].Cells[1].Value = MisDatos9[1];
                    dgvComprobacion.Rows[a].Cells[2].Value = MisDatos9[2];
                    dgvComprobacion.Rows[a].Cells[3].Value = MisDatos9[3];
                    dgvComprobacion.Rows[a].Cells[4].Value = MisDatos9[4];
                }
                Leer9.Close();
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                exportaraexcel(dgvComprobacion);
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
        Bitmap bitmap;
        private void btnCaptura_Click(object sender, EventArgs e)
        {
            try 
            {
                int alto = dgvComprobacion.Height;
                dgvComprobacion.Height = dgvComprobacion.RowCount * dgvComprobacion.RowTemplate.Height * 2;
                bitmap = new Bitmap(dgvComprobacion.Width,dgvComprobacion.Height);
                dgvComprobacion.DrawToBitmap(bitmap,new Rectangle(0,0,dgvComprobacion.Width,dgvComprobacion.Height));
                dgvComprobacion.Height = alto;
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    Bitmap imagen = new Bitmap(bitmap);
                    imagen.Save(guardar.FileName,ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("E:\\Contaduria\\Hoja de Trabajo.text") == true)
                {
                    File.Delete("E:\\Contaduria\\Hoja de Trabajo.text");
                }
                string Datos;
                char[] Caracteres = { '\t' };
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\NOMBREDECUENTAS.text");
                StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Hoja de Trabajo.text");
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    if (File.Exists("E:\\Contaduria\\Cuentas\\" + Datos + ".text") == true)
                    {
                        string Datos1;
                        char[] Caracteres1 = { '\t' };
                        StreamReader Leer1 = File.OpenText("E:\\Contaduria\\Cuentas\\" + Datos + ".text");
                        while (Leer1.EndOfStream == false)
                        {
                            Datos1 = Leer1.ReadLine();
                            string[] MisDatos1 = Datos1.Split(Caracteres1);
                            string Datos2;
                            char[] Caracteres2 = { '\t' };
                            StreamReader Leer2 = File.OpenText("E:\\Contaduria\\Balance de Comprobacion.text");
                            while (Leer2.EndOfStream == false)
                            {
                                Datos2 = Leer2.ReadLine();
                                string[] MisDatos2 = Datos2.Split(Caracteres2);
                                if (MisDatos2[0] == MisDatos1[0])
                                {
                                    if (Datos == "ACTIVOCORRIENTE" || Datos == "ACTIVONO CORRIENTE" || Datos == "PASIVOCORRIENTE" || Datos == "PASIVONO CORRIENTE" || Datos == "PATRIMONIO")
                                    {
                                        Escribir.Write(MisDatos2[0] + "\t" + MisDatos2[3] + "\t" + MisDatos2[4] + "\t" + "0" + "\t" + "0" + "\t" + MisDatos2[3] + "\t" + MisDatos2[4] + Environment.NewLine);
                                    }
                                    else
                                    {
                                        Escribir.Write(MisDatos2[0] + "\t" + MisDatos2[3] + "\t" + MisDatos2[4] + "\t" + MisDatos2[3] + "\t" + MisDatos2[4] + "\t" + "0" + "\t" + "0" + Environment.NewLine);
                                    }
                                }
                            }
                            Leer2.Close();
                        }
                        Leer1.Close();
                    }
                }
                Leer.Close();
                Escribir.Close();
                Hoja_de_Trabajo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Hoja_de_Trabajo()
        {
            try
            {
                string Datos;
                char[] Caracteres = { '\t' };
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Hoja de trabajo.text");
                StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Hoja de Trabajo2.text");
                double deb = 0, habe = 0, perdida = 0, ganancia = 0, activo = 0, pasivo = 0;
                while (Leer.EndOfStream == false)
                {
                    Datos = Leer.ReadLine();
                    string[] MisDatos = Datos.Split(Caracteres);
                    Escribir.Write(Datos + Environment.NewLine);
                    deb += Convert.ToDouble(MisDatos[1]);
                    habe += Convert.ToDouble(MisDatos[2]);
                    perdida += Convert.ToDouble(MisDatos[3]);
                    ganancia += Convert.ToDouble(MisDatos[4]);
                    activo += Convert.ToDouble(MisDatos[5]);
                    pasivo += Convert.ToDouble(MisDatos[6]);
                }
                Escribir.Write("SUMA DE SALDOS" + "\t" + deb.ToString() + "\t" + habe.ToString() + "\t" + perdida.ToString() + "\t" + ganancia.ToString() + "\t" + activo.ToString() + "\t" + pasivo.ToString() + Environment.NewLine);
                double res = perdida - ganancia;
                if (res > 0)
                {
                    Escribir.Write("PERDIDAS ACUMULADAS" + "\t" + "0" + "\t" + "0" + "\t" + "0" + "\t" + res.ToString() + "\t" + res.ToString() + "\t" + "0" + Environment.NewLine);
                    Escribir.Write("TOTALES" + "\t" + deb.ToString() + "\t" + habe.ToString() + "\t" + perdida.ToString() + "\t" + (ganancia + res).ToString() + "\t" + (activo + res).ToString() + "\t" + pasivo.ToString() + Environment.NewLine);
                }
                else
                {
                    res *= -1;
                    Escribir.Write("UTILIDAD DE LA GESTION" + "\t" + "0" + "\t" + "0" + "\t" + res.ToString() + "\t" + "0" + "\t" + "0" + "\t" + res.ToString() + Environment.NewLine);
                    Escribir.Write("TOTALES" + "\t" + deb.ToString() + "\t" + habe.ToString() + "\t" + (perdida + res).ToString() + "\t" + ganancia.ToString() + "\t" + activo.ToString() + "\t" + (pasivo + res).ToString() + Environment.NewLine);
                }
                Leer.Close();
                Escribir.Close();
                File.Replace("E:\\Contaduria\\Hoja de Trabajo2.text", "E:\\Contaduria\\Hoja de Trabajo.text", "E:\\Contaduria\\Hoja de Trabajo3.text");
                File.Delete("E:\\Contaduria\\Hoja de Trabajo3.text");
                string Datos9;
                char[] Caracteres9 = { '\t' };
                StreamReader Leer9 = File.OpenText("E:\\Contaduria\\Hoja de Trabajo.text");
                while (Leer9.EndOfStream == false)
                {
                    Datos9 = Leer9.ReadLine();
                    string[] MisDatos9 = Datos9.Split(Caracteres9);
                    int a = dgvTrabajo.Rows.Add();
                    dgvTrabajo.Rows[a].Cells[0].Value = MisDatos9[0];
                    dgvTrabajo.Rows[a].Cells[1].Value = MisDatos9[1];
                    dgvTrabajo.Rows[a].Cells[2].Value = MisDatos9[2];
                    dgvTrabajo.Rows[a].Cells[3].Value = MisDatos9[3];
                    dgvTrabajo.Rows[a].Cells[4].Value = MisDatos9[4];
                    dgvTrabajo.Rows[a].Cells[5].Value = MisDatos9[5];
                    dgvTrabajo.Rows[a].Cells[6].Value = MisDatos9[6];
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
            exportaraexcel(dgvTrabajo);
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
                int alto = dgvTrabajo.Height;
                dgvTrabajo.Height = dgvTrabajo.RowCount * dgvTrabajo.RowTemplate.Height * 2;
                bitmap = new Bitmap(dgvTrabajo.Width, dgvTrabajo.Height);
                dgvTrabajo.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvTrabajo.Width, dgvTrabajo.Height));
                dgvTrabajo.Height = alto;
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

        private void dgvTrabajo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

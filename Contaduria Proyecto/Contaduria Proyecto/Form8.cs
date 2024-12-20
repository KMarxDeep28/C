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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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
        Bitmap bitmap;
        private void btnCaptura_Click(object sender, EventArgs e)
        {
            try
            {
                int alto = gbBalanceGral.Height;
                //gbNombre.Height = dgvMayor.RowCount * dgvMayor.RowTemplate.Height * 2;
                bitmap = new Bitmap(gbBalanceGral.Width, gbBalanceGral.Height);
                gbBalanceGral.DrawToBitmap(bitmap, new Rectangle(0, 0, gbBalanceGral.Width, gbBalanceGral.Height));
                gbBalanceGral.Height = alto;
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

        private void Form8_Load(object sender, EventArgs e)
        {
            try 
            {
                string Datos;
                char[] Caracteres = { '\t' };
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\NOMBREDECUENTAS.text");
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
                            StreamReader Leer2 = File.OpenText("E:\\Contaduria\\Hoja de Trabajo.text");
                            while (Leer2.EndOfStream == false)
                            {
                                Datos2 = Leer2.ReadLine();
                                string[] MisDatos2 = Datos2.Split(Caracteres2);
                                if (MisDatos2[0] == MisDatos1[0] && Datos == "ACTIVOCORRIENTE")
                                {
                                    if (MisDatos2[5] != "0")
                                    {
                                        int a = dgvAC.Rows.Add();
                                        dgvAC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvAC.Rows[a].Cells[1].Value = MisDatos2[5];
                                    }
                                    else
                                    {
                                        int a = dgvAC.Rows.Add();
                                        dgvAC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvAC.Rows[a].Cells[1].Value = "-" + MisDatos2[6];
                                    }
                                }
                                if (MisDatos2[0] == MisDatos1[0] && Datos == "ACTIVONO CORRIENTE")
                                {
                                    if (MisDatos2[5] != "0")
                                    {
                                        int a = dgvANC.Rows.Add();
                                        dgvANC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvANC.Rows[a].Cells[1].Value = MisDatos2[5];
                                    }
                                    else
                                    {
                                        int a = dgvANC.Rows.Add();
                                        dgvANC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvANC.Rows[a].Cells[1].Value = "-" + MisDatos2[6];
                                    }
                                }
                                if (MisDatos2[0] == MisDatos1[0] && Datos == "PASIVOCORRIENTE")
                                {
                                    if (MisDatos2[6] != "0")
                                    {
                                        int a = dgvPC.Rows.Add();
                                        dgvPC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvPC.Rows[a].Cells[1].Value = MisDatos2[6];
                                    }
                                    else
                                    {
                                        int a = dgvPC.Rows.Add();
                                        dgvPC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvPC.Rows[a].Cells[1].Value = "-" + MisDatos2[5];
                                    }
                                }
                                if (MisDatos2[0] == MisDatos1[0] && Datos == "PASIVONO CORRIENTE")
                                {
                                    if (MisDatos2[6] != "0")
                                    {
                                        int a = dgvPNC.Rows.Add();
                                        dgvPNC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvPNC.Rows[a].Cells[1].Value = MisDatos2[6];
                                    }
                                    else
                                    {
                                        int a = dgvPNC.Rows.Add();
                                        dgvPNC.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvPNC.Rows[a].Cells[1].Value = "-"+MisDatos2[5];
                                    }
                                }
                                if (MisDatos2[0] == MisDatos1[0] && Datos == "PATRIMONIO")
                                {
                                    if (MisDatos2[6] != "0")
                                    {
                                        int a = dgvP.Rows.Add();
                                        dgvP.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvP.Rows[a].Cells[1].Value = MisDatos2[6];
                                    }
                                    else
                                    {
                                        int a = dgvP.Rows.Add();
                                        dgvP.Rows[a].Cells[0].Value = MisDatos2[0];
                                        dgvP.Rows[a].Cells[1].Value = "-" + MisDatos2[5];
                                    }
                                }
                            }
                            Leer2.Close();
                        }
                        Leer1.Close();
                    }
                }
                Leer.Close();
                double total = 0;
                foreach (DataGridViewRow row in dgvAC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["ACTIVO_CORRIENTE_SALDO"].Value);
                }
                txtAC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvANC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["ACTIVO_NO_CORRIENTE_SALDO"].Value);
                }
                txtANC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvPC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["PASIVO_CORRIENTE_SALDO"].Value);
                }
                txtPC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvPNC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["PASIVO_NO_CORRIENTE_SALDO"].Value);
                }
                txtPNC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvP.Rows)
                {
                    total += Convert.ToDouble(row.Cells["PATRIMONIO_SALDO"].Value);
                }
                txtP.Text = total.ToString();
                txtA.Text = (Convert.ToDouble(txtAC.Text) + Convert.ToDouble(txtANC.Text)).ToString();
                txtPasivo.Text = (Convert.ToDouble(txtPC.Text) + Convert.ToDouble(txtPNC.Text)).ToString();
                txtPYP.Text = (Convert.ToDouble(txtPasivo.Text) + Convert.ToDouble(txtP.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

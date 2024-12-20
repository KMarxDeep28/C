using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Contaduria_Proyecto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCuenta.SelectedIndex != -1)
                {
                    cmbCuenta.Items.Clear();
                    cmbCuenta.Text = "";
                    if (cmbTipoCuenta.SelectedIndex == 0 || cmbTipoCuenta.SelectedIndex == 1)
                    {
                        cmbEspecificacion.Enabled = true;
                        lblEspecificacion.Enabled = true;
                        cmbCuenta.Enabled = false;
                        lblCuenta.Enabled = false;
                        txtCantidad.Enabled = false;
                        lblCantidad.Enabled = false;
                    }
                    else
                    {
                        cmbEspecificacion.Enabled = false;
                        lblEspecificacion.Enabled = false;
                        cmbCuenta.Enabled = true;
                        lblCuenta.Enabled = true;
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEspecificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCuenta.Items.Clear();
                cmbCuenta.Text = "";
                if (cmbEspecificacion.SelectedIndex != -1)
                {
                    cmbCuenta.Enabled = true;
                    lblCuenta.Enabled = true;
                    CargarDatos();
                }
                else
                {
                    cmbCuenta.Enabled = false;
                    lblCuenta.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                string Datos;
                char[] Caracteres = { '\t' };
                if (cmbTipoCuenta.SelectedIndex < 2)
                {
                    StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + ".text");
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        cmbCuenta.Items.Add(MisDatos[0]);
                    }
                    Leer.Close();
                }
                else
                {
                    StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + ".text");
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        cmbCuenta.Items.Add(MisDatos[0]);
                    }
                    Leer.Close();
                }
                txtCantidad.Enabled = true;
                lblCantidad.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text != "" && cmbCuenta.SelectedIndex != -1)
                {
                    btnAgregar.Enabled = true;
                }
                else
                {
                    btnAgregar.Enabled = false;
                }
                if (txtCantidad.Text != "")
                {
                    if (txtCantidad.Text == "-")
                    {
                        txtNeto.Text = 0.ToString();
                        txtTrece.Text = 0.ToString();
                        txtTres.Text = 0.ToString();
                    }
                    else
                    {
                        txtNeto.Text = (Convert.ToDouble(txtCantidad.Text) * 87 / 100).ToString();
                        txtTrece.Text = (Convert.ToDouble(txtCantidad.Text) * 13 / 100).ToString();
                        txtTres.Text = (Convert.ToDouble(txtCantidad.Text) * 3 / 100).ToString();
                    }
                }
                else
                {
                    txtNeto.Text = 0.ToString();
                    txtTrece.Text = 0.ToString();
                    txtTres.Text = 0.ToString();
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
                File.Delete("E:\\Contaduria\\Cuentas\\Numero.text");
                StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\Numero.text");
                Escribir.Write(i.ToString());
                Escribir.Close();
                Form2 Inicio = new Form2();
                Inicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCajas()
        {
            try
            {
                cmbTipoCuenta.SelectedIndex = -1;
                cmbEspecificacion.SelectedIndex = -1;
                cmbEspecificacion.Enabled = false;
                cmbCuenta.Items.Clear();
                cmbCuenta.Enabled = false;
                cmbCuenta.Text = null;
                txtCantidad.Clear();
                txtCantidad.Enabled = false;
                btnAgregar.Enabled = false;
                cmbDiario.Text=null;
                txtTitulo.Text=null;
                lblCuenta.Enabled = false;
                lblCantidad.Enabled = false;
                lblEspecificacion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtCantidad.Text) != 0)
                {
                    if (cmbTipoCuenta.SelectedIndex == 0 || cmbTipoCuenta.SelectedIndex == 4 || cmbTipoCuenta.SelectedIndex == 5)
                    {
                        double total = 0;
                        int a = dgvDiario.Rows.Add();
                        dgvDiario.Rows[a].Cells[0].Value = cmbCuenta.Text;
                        if (Convert.ToDouble(txtCantidad.Text) > 0)
                        {
                            dgvDiario.Rows[a].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text)).ToString();
                            dgvDiario.Rows[a].Cells[2].Value = 0.ToString();
                        }
                        else
                        {
                            dgvDiario.Rows[a].Cells[2].Value = (Convert.ToDouble(txtCantidad.Text) * -1).ToString();
                            dgvDiario.Rows[a].Cells[1].Value = 0.ToString();
                        }
                        foreach (DataGridViewRow row in dgvDiario.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["CUENTA_DEBE"].Value);
                        }
                        txtDebe.Text = total.ToString();
                    }
                    if (cmbTipoCuenta.SelectedIndex == 1 || cmbTipoCuenta.SelectedIndex == 2 || cmbTipoCuenta.SelectedIndex == 3)
                    {
                        double total = 0;
                        int a = dgvDiario.Rows.Add();
                        dgvDiario.Rows[a].Cells[0].Value = cmbCuenta.Text;
                        if (Convert.ToDouble(txtCantidad.Text) > 0)
                        {
                            dgvDiario.Rows[a].Cells[1].Value = 0.ToString();
                            dgvDiario.Rows[a].Cells[2].Value = (Convert.ToDouble(txtCantidad.Text)).ToString();
                        }
                        else
                        {
                            dgvDiario.Rows[a].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text) * -1).ToString();
                            dgvDiario.Rows[a].Cells[2].Value = (0).ToString();
                        }
                        foreach (DataGridViewRow row in dgvDiario.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["CUENTA_HABER"].Value);
                        }
                        txtHaber.Text = total.ToString();
                    }
                    if (txtDebe.Text == txtHaber.Text)
                    {
                        btnGuardar.Enabled = true;
                        btnExportar.Enabled = true;
                        btnImagen.Enabled = true;
                    }
                    else
                    {
                        btnGuardar.Enabled = false;
                        btnExportar.Enabled = false;
                        btnImagen.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad no aceptada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarCajas();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Actualizar()
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row in dgvDiario.Rows)
                {
                    total += Convert.ToDouble(row.Cells["CUENTA_DEBE"].Value);
                }
                txtDebe.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvDiario.Rows)
                {
                    total += Convert.ToDouble(row.Cells["CUENTA_HABER"].Value);
                }
                txtHaber.Text = total.ToString();
                if (txtDebe.Text == txtHaber.Text)
                {
                    btnGuardar.Enabled = true;
                    btnExportar.Enabled = true;
                    btnImagen.Enabled=true;
                }
                else
                {
                    btnGuardar.Enabled = false;
                    btnExportar.Enabled = false;
                    btnImagen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
                string cuenta, debe, haber;
                try
                {
                    i += 1;
                    StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Diarios\\Comprobante diario " + i + ".text");
                    foreach (DataGridViewRow row in dgvDiario.Rows)
                    {
                        cuenta = Convert.ToString(row.Cells["CUENTA"].Value);
                        debe = Convert.ToString(row.Cells["CUENTA_DEBE"].Value);
                        haber = Convert.ToString(row.Cells["CUENTA_HABER"].Value);
                        Escribir.Write(cuenta + "\t" + debe + "\t" + haber + Environment.NewLine);
                        if (File.Exists("E:\\Contaduria\\Mayores\\" + cuenta + ".text") == false)
                        {
                            StreamWriter Escribir1 = File.AppendText("E:\\Contaduria\\Mayores\\" + cuenta + ".text");
                            Escribir1.Write(debe + "\t" + haber + Environment.NewLine);
                            Escribir1.Close();
                        }
                        else
                        {
                            string Datos;
                            char[] Caracteres = { ' ', '\t' };
                            StreamReader Leer = File.OpenText("E:\\Contaduria\\Mayores\\" + cuenta + ".text");
                            StreamWriter Escribir1 = File.AppendText("E:\\Contaduria\\Mayores\\" + cuenta + "2.text");
                            while (Leer.EndOfStream == false)
                            {
                                Datos = Leer.ReadLine();
                                string[] MisDatos = Datos.Split(Caracteres);
                                Escribir1.Write(Datos + Environment.NewLine);
                            }
                            Escribir1.Write(debe + "\t" + haber + Environment.NewLine);
                            Leer.Close();
                            Escribir1.Close();
                            File.Replace("E:\\Contaduria\\Mayores\\" + cuenta + "2.text", "E:\\Contaduria\\Mayores\\" + cuenta + ".text", "E:\\Contaduria\\Mayores\\" + cuenta + "3.text");
                            File.Delete("E:\\Contaduria\\Mayores\\" + cuenta + "3.text");
                        }
                    }
                    Escribir.Close();
                    dgvDiario.Rows.Clear();
                    txtDebe.Clear();
                    txtHaber.Clear();
                    string b = "Comprobante diario " + i + ".text";
                    cmbDiario.Items.Add(b);
                    LimpiarCajas();
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
                exportaraexcel(dgvDiario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\Numero.text");
                i = Convert.ToInt32(Leer.ReadLine());
                Leer.Close();
                for (int j=0;j<=i;j++)
                {
                    if (File.Exists("E:\\Contaduria\\Diarios\\Comprobante diario " + j + ".text") ==true)
                    {
                        string a = "Comprobante diario " + j + ".text";
                        cmbDiario.Items.Add(a);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int alto = gbDiario.Height;
                //dgvDiario.Height = dgvDiario.RowCount * dgvDiario.RowTemplate.Height * 2;
                bitmap = new Bitmap(gbDiario.Width, gbDiario.Height);
                gbDiario.DrawToBitmap(bitmap, new Rectangle(0, 0, gbDiario.Width, gbDiario.Height));
                gbDiario.Height = alto;
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

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                gbDiario.Text= txtTitulo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void cmbDiario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDiario.Text != "")
                {
                    btnEliminar.Enabled = true;
                    dgvDiario.Rows.Clear();
                    string Datos;
                    char[] Caracteres = { '\t' };
                    StreamReader Leer = File.OpenText("E:\\Contaduria\\Diarios\\" + cmbDiario.Text);
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        int a = dgvDiario.Rows.Add();
                        dgvDiario.Rows[a].Cells[0].Value = MisDatos[0];
                        if (Convert.ToDouble(MisDatos[1]) > 0)
                        {
                            dgvDiario.Rows[a].Cells[1].Value = MisDatos[1];
                            dgvDiario.Rows[a].Cells[2].Value = 0;
                        }
                        else
                        {
                            dgvDiario.Rows[a].Cells[2].Value = MisDatos[2];
                            dgvDiario.Rows[a].Cells[1].Value = 0;
                        }
                    }
                    Leer.Close();
                    double total = 0;
                    foreach (DataGridViewRow row in dgvDiario.Rows)
                    {
                        total += Convert.ToDouble(row.Cells["CUENTA_DEBE"].Value);
                    }
                    txtDebe.Text = total.ToString();
                    total = 0;
                    foreach (DataGridViewRow row in dgvDiario.Rows)
                    {
                        total += Convert.ToDouble(row.Cells["CUENTA_HABER"].Value);
                    }
                    txtHaber.Text = total.ToString();
                    if (txtDebe.Text == txtHaber.Text)
                    {
                        btnGuardar.Enabled = true;
                        btnExportar.Enabled = true;
                        btnImagen.Enabled = true;
                    }
                    else
                    {
                        btnGuardar.Enabled = false;
                        btnExportar.Enabled = false;
                        btnImagen.Enabled = false;
                    }
                }
                else
                {
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("Se limpiara todo ¿Desea continuar?","Limpiar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    dgvDiario.Rows.Clear();
                    LimpiarCajas();
                    txtDebe.Text = "0";
                    txtHaber.Text = "0";
                    btnGuardar.Enabled = false;
                    btnExportar.Enabled = false;
                    btnImagen.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a;
                a = MessageBox.Show("¿Esta seguro que desea eliminar el Comprobante Diario?", "Eliminar Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    string Datos;
                    char[] Caracteres = { '\t' };
                    StreamReader Leer = File.OpenText("E:\\Contaduria\\Diarios\\" + cmbDiario.Text);
                    string Datos1;
                    char[] Caracteres1 = { '\t' };
                    while (Leer.EndOfStream == false)
                    {
                        Datos = Leer.ReadLine();
                        string[] MisDatos = Datos.Split(Caracteres);
                        StreamReader Leer1 = File.OpenText("E:\\Contaduria\\Mayores\\" + MisDatos[0] + ".text");
                        StreamWriter Escribir1 = File.AppendText("E:\\Contaduria\\Mayores\\" + MisDatos[0] + "2.text");
                        while (Leer1.EndOfStream == false)
                        {
                            Datos1 = Leer1.ReadLine();
                            string[] MisDatos1 = Datos1.Split(Caracteres1);
                            if (MisDatos[1] + "\t" + MisDatos[2] != Datos1)
                            {
                                Escribir1.Write(Datos1 + Environment.NewLine);
                            }
                        }
                        Leer1.Close();
                        Escribir1.Close();
                        File.Replace("E:\\Contaduria\\Mayores\\" + MisDatos[0] + "2.text", "E:\\Contaduria\\Mayores\\" + MisDatos[0] + ".text", "E:\\Contaduria\\Mayores\\" + MisDatos[0] + "3.text");
                        File.Delete("E:\\Contaduria\\Mayores\\" + MisDatos[0] + "3.text");
                        string Datos3;
                        StreamReader Leer3 = File.OpenText("E:\\Contaduria\\Mayores\\" + MisDatos[0] + ".text");
                        Datos3 = Leer3.ReadLine();
                        Leer3.Close();
                        if (Datos3== null)
                        {
                            File.Delete("E:\\Contaduria\\Mayores\\" + MisDatos[0] + ".text");
                        }
                    }
                    Leer.Close();
                    File.Delete("E:\\Contaduria\\Diarios\\" + cmbDiario.Text);
                    LimpiarCajas();
                    cmbDiario.Items.Clear();
                    for (int j = 0; j <= i; j++)
                    {
                        if (File.Exists("E:\\Contaduria\\Diarios\\Comprobante diario " + j + ".text") == true)
                        {
                            string b = "Comprobante diario " + j + ".text";
                            cmbDiario.Items.Add(b);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

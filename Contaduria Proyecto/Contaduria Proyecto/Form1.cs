using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Contaduria_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
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
                if (cmbTipoCuenta.SelectedIndex != 2)
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtCantidad.Text) != 0)
                {
                    if (cmbTipoCuenta.SelectedIndex == 0 && cmbEspecificacion.SelectedIndex == 0)
                    {
                        double total = 0;
                        int a = dgvAC.Rows.Add();
                        dgvAC.Rows[a].Cells[0].Value = cmbCuenta.Text;
                        dgvAC.Rows[a].Cells[1].Value = Convert.ToDouble(txtCantidad.Text);
                        foreach (DataGridViewRow row in dgvAC.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["ACTIVO_CORRIENTE_SALDO"].Value);
                        }
                        txtAC.Text = total.ToString();
                    }
                    if (cmbTipoCuenta.SelectedIndex == 1 && cmbEspecificacion.SelectedIndex == 0)
                    {
                        int b = dgvPC.Rows.Add();
                        dgvPC.Rows[b].Cells[0].Value = cmbCuenta.Text;
                        dgvPC.Rows[b].Cells[1].Value = Convert.ToDouble(txtCantidad.Text);
                        double total = 0;
                        foreach (DataGridViewRow row in dgvPC.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["PASIVO_CORRIENTE_SALDO"].Value);
                        }
                        txtPC.Text = total.ToString();
                    }
                    if (cmbTipoCuenta.SelectedIndex == 0 && cmbEspecificacion.SelectedIndex == 1)
                    {
                        int c = dgvANC.Rows.Add();
                        dgvANC.Rows[c].Cells[0].Value = cmbCuenta.Text;
                        dgvANC.Rows[c].Cells[1].Value = Convert.ToDouble(txtCantidad.Text);
                        double total = 0;
                        foreach (DataGridViewRow row in dgvANC.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["ACTIVO_NO_CORRIENTE_SALDO"].Value);
                        }
                        txtANC.Text = total.ToString();
                    }
                    if (cmbTipoCuenta.SelectedIndex == 1 && cmbEspecificacion.SelectedIndex == 1)
                    {
                        int d = dgvPNC.Rows.Add();
                        dgvPNC.Rows[d].Cells[0].Value = cmbCuenta.Text;
                        dgvPNC.Rows[d].Cells[1].Value = Convert.ToDouble(txtCantidad.Text);
                        double total = 0;
                        foreach (DataGridViewRow row in dgvPNC.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["PASIVO_NO_CORRIENTE_SALDO"].Value);
                        }
                        txtPNC.Text = total.ToString();
                    }
                    if (cmbTipoCuenta.SelectedIndex == 2)
                    {
                        int p = dgvP.Rows.Add();
                        dgvP.Rows[p].Cells[0].Value = cmbCuenta.Text;
                        dgvP.Rows[p].Cells[1].Value = Convert.ToDouble(txtCantidad.Text);
                        double total = 0;
                        foreach (DataGridViewRow row in dgvP.Rows)
                        {
                            total += Convert.ToDouble(row.Cells["PATRIMONIO_SALDO"].Value);
                        }
                        txtP.Text = total.ToString();
                    }
                    txtA.Text = (Convert.ToDouble(txtAC.Text) + Convert.ToDouble(txtANC.Text)).ToString();
                    txtPasivo.Text = (Convert.ToDouble(txtPC.Text) + Convert.ToDouble(txtPNC.Text)).ToString();
                    txtPYP.Text = (Convert.ToDouble(txtPasivo.Text) + Convert.ToDouble(txtP.Text)).ToString();
                    if (txtA.Text == txtPYP.Text)
                    {
                        btnGuardar.Enabled = true;
                    }
                    else
                    {
                        btnGuardar.Enabled = false;
                    }
                    LimpiarCajas();
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Cantidad no aceptada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmbCuenta.Text = "";
                txtCantidad.Clear();
                txtCantidad.Enabled = false;
                btnAgregar.Enabled = false;
                lblCuenta.Enabled=false;
                lblCantidad.Enabled=false;
                lblEspecificacion.Enabled=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Actualizar()
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row in dgvAC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["ACTIVO_CORRIENTE_SALDO"].Value);
                }
                txtAC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvPC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["PASIVO_CORRIENTE_SALDO"].Value);
                }
                txtPC.Text = total.ToString();
                total = 0;
                foreach (DataGridViewRow row in dgvANC.Rows)
                {
                    total += Convert.ToDouble(row.Cells["ACTIVO_NO_CORRIENTE_SALDO"].Value);
                }
                txtANC.Text = total.ToString();
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
                if (txtA.Text == txtPYP.Text)
                {
                    btnGuardar.Enabled = true;
                }
                else
                {
                    btnGuardar.Enabled = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("¿Esta seguro que desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                try
                {
                    StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Diarios\\Comprobante diario 1.text");
                    foreach (DataGridViewRow row in dgvAC.Rows)
                    {
                        string cuenta, debe = "0", haber = "0";
                        cuenta = Convert.ToString(row.Cells["ACTIVO_CORRIENTE"].Value);
                        debe = Convert.ToString(row.Cells["ACTIVO_CORRIENTE_SALDO"].Value);
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
                    foreach (DataGridViewRow row in dgvANC.Rows)
                    {
                        string cuenta, debe = "0", haber = "0";
                        cuenta = Convert.ToString(row.Cells["ACTIVO_NO_CORRIENTE"].Value);
                        debe = Convert.ToString(row.Cells["ACTIVO_NO_CORRIENTE_SALDO"].Value);
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
                    foreach (DataGridViewRow row in dgvPC.Rows)
                    {
                        string cuenta, debe = "0", haber = "0";
                        cuenta = Convert.ToString(row.Cells["PASIVO_CORRIENTE"].Value);
                        haber = Convert.ToString(row.Cells["PASIVO_CORRIENTE_SALDO"].Value);
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
                    foreach (DataGridViewRow row in dgvPNC.Rows)
                    {
                        string cuenta, debe = "0", haber = "0";
                        cuenta = Convert.ToString(row.Cells["PASIVO_NO_CORRIENTE"].Value);
                        haber = Convert.ToString(row.Cells["PASIVO_NO_CORRIENTE_SALDO"].Value);
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
                    foreach (DataGridViewRow row in dgvP.Rows)
                    {
                        string cuenta, debe = "0", haber = "0";
                        cuenta = Convert.ToString(row.Cells["PATRIMONIO"].Value);
                        haber = Convert.ToString(row.Cells["PATRIMONIO_SALDO"].Value);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void cmbCuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblCuenta_Click(object sender, EventArgs e)
        {

        }

        private void lblEspecificacion_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoCuenta_Click(object sender, EventArgs e)
        {

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
                    excel.Cells[1, IndiceColumna] = col.Name;
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int alto = gbBalanceInicial.Height;
                //gbNombre.Height = dgvMayor.RowCount * dgvMayor.RowTemplate.Height * 2;
                bitmap = new Bitmap(gbBalanceInicial.Width, gbBalanceInicial.Height);
                gbBalanceInicial.DrawToBitmap(bitmap, new Rectangle(0, 0, gbBalanceInicial.Width, gbBalanceInicial.Height));
                gbBalanceInicial.Height = alto;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contaduria_Proyecto
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCuenta.SelectedIndex!=-1) {
                cmbCuenta.Items.Clear();
                lstCuenta.Items.Clear();
                cmbCuenta.Text = "";
                if (cmbTipoCuenta.SelectedIndex == 0 || cmbTipoCuenta.SelectedIndex == 1)
                {
                    cmbEspecificacion.Enabled = true;
                    lblEspecificacion.Enabled = true;
                    cmbCuenta.Enabled = false;
                    lblCuenta.Enabled = false;
                    txtNuevaCuenta.Enabled = false;
                    lblNuevaCuenta.Enabled = false;
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
                        lstCuenta.Items.Add(MisDatos[0]);
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
                        lstCuenta.Items.Add(MisDatos[0]);
                    }
                    Leer.Close();
                }
                txtNuevaCuenta.Enabled = true;
                lblNuevaCuenta.Enabled = true;
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
                lstCuenta.Items.Clear();
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

        private void Actualizar()
        {
            try
            {
                CargarDatos();
                cmbTipoCuenta.SelectedIndex = -1;
                cmbEspecificacion.SelectedIndex = -1;
                cmbCuenta.Text = "";
                txtNuevaCuenta.Text = "";
                cmbCuenta.Items.Clear();
                lstCuenta.Items.Clear();
                cmbEspecificacion.Enabled = false;
                lblEspecificacion.Enabled = false;
                cmbCuenta.Enabled = false;
                lblCuenta.Enabled = false;
                txtNuevaCuenta.Enabled = false;
                lblNuevaCuenta.Enabled = false;
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
                if (cmbTipoCuenta.SelectedIndex < 2)
                {
                    if (cmbEspecificacion.SelectedIndex != -1)
                    {
                        StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + ".text");
                        Escribir.Write(txtNuevaCuenta.Text + Environment.NewLine);
                        Escribir.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cmbTipoCuenta.SelectedIndex != -1)
                    {
                        StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + ".text");
                        Escribir.Write(txtNuevaCuenta.Text + Environment.NewLine);
                        Escribir.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNuevaCuenta_Leave(object sender, EventArgs e)
        {

        }

        private void txtNuevaCuenta_Enter(object sender, EventArgs e)
        {
        }

        private void txtNuevaCuenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevaCuenta.Text.Length > 0)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoCuenta.SelectedIndex < 2)
                {
                    if (cmbEspecificacion.SelectedIndex != -1)
                    {
                        string Datos;
                        StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + ".text");
                        StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + "2.text");
                        while (Leer.EndOfStream == false)
                        {
                            Datos = Leer.ReadLine();

                            if (Datos != cmbCuenta.Text)
                            {
                                Escribir.Write(Datos + Environment.NewLine);
                            }
                        }
                        Escribir.Close();
                        Leer.Close();
                        File.Replace("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + "2.text", "E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + ".text", "E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + "3.text");
                        File.Delete("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + cmbEspecificacion.Text + "3.text");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cmbTipoCuenta.SelectedIndex != -1)
                    {
                        string Datos;
                        StreamReader Leer = File.OpenText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + ".text");
                        StreamWriter Escribir = File.AppendText("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + "2.text");
                        while (Leer.EndOfStream == false)
                        {
                            Datos = Leer.ReadLine();
                            if (Datos != cmbCuenta.Text)
                            {
                                Escribir.Write(Datos + Environment.NewLine);
                            }
                        }
                        Escribir.Close();
                        Leer.Close();
                        File.Replace("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + "2.text", "E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + ".text", "E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + "3.text");
                        File.Delete("E:\\Contaduria\\Cuentas\\" + cmbTipoCuenta.Text + "3.text");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCuenta.Text != "")
                {
                    btnEliminar.Enabled = true;
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

        private void lstCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstCuenta.SelectedItem != null)
                {
                    cmbCuenta.Text = lstCuenta.SelectedItem.ToString();
                    txtNuevaCuenta.Text = lstCuenta.SelectedItem.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

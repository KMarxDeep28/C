using System;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using NCalc;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {

        ClaseCalculadora calculadora = new ClaseCalculadora();
        ClaseGraficadora graficadora = new ClaseGraficadora();
        List<double> valoresX = new List<double>(), valoresY = new List<double>();
        List<string> ecuacionPrevia = new List<string>();
        int funcionSecundaria = 0, contadorEcuacion = -1, graficoRendimiento = 0, contadorSistema = 0;
        Boolean existeRsultado = false, esDerivada = false, esIntegral = true;
        Double valorInicioX = -10, valorFinalX = 10, incremento = 0.01, valorInicioY = -10, valorFinalY = 10, incrementoSimulador, epsilon = 1e2;
        Color colorGrafico = Color.Blue;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            funcionSecundaria = funcionSecundaria == 1 ? 0 : 1;
        }

        private void btnAlpha_Click(object sender, EventArgs e)
        {
            funcionSecundaria = funcionSecundaria == 2 ? 0 : 2;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "0";
            }
            else
            {
                txtPantallaOp.Text = "0";
                existeRsultado = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "1";
            }
            else
            {
                txtPantallaOp.Text = "1";
                existeRsultado = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "2";
            }
            else
            {
                txtPantallaOp.Text = "2";
                existeRsultado = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "3";
            }
            else
            {
                txtPantallaOp.Text = "3";
                existeRsultado = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "4";
            }
            else
            {
                txtPantallaOp.Text = "4";
                existeRsultado = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "5";
            }
            else
            {
                txtPantallaOp.Text = "5";
                existeRsultado = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "6";
            }
            else
            {
                txtPantallaOp.Text = "6";
                existeRsultado = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "7";
            }
            else
            {
                txtPantallaOp.Text = "7";
                existeRsultado = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "8";
            }
            else
            {
                txtPantallaOp.Text = "8";
                existeRsultado = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text != "0" && !existeRsultado)
            {
                txtPantallaOp.Text += "9";
            }
            else
            {
                txtPantallaOp.Text = "9";
                existeRsultado = false;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text.IndexOf('.') == -1)
            {
                txtPantallaOp.Text += '.';
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (existeRsultado)
            {
                txtPantallaOp.Text = "ans" + '+';
                existeRsultado = false;
            }
            else
            {
                txtPantallaOp.Text += '+';
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (existeRsultado)
            {
                txtPantallaOp.Text = "ans" + '-';
                existeRsultado = false;
            }
            else
            {
                txtPantallaOp.Text += '-';
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (existeRsultado)
            {
                txtPantallaOp.Text = "ans" + '*';
                existeRsultado = false;
            }
            else
            {
                txtPantallaOp.Text += '*';
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (existeRsultado)
            {
                txtPantallaOp.Text = "ans" + '/';
                existeRsultado = false;
            }
            else
            {
                txtPantallaOp.Text += '/';
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                tmrSimulador.Enabled = false;
                ecuacionPrevia.Add(txtPantallaOp.Text);
                contadorEcuacion++;
                existeRsultado = true;
                switch (funcionSecundaria)
                {
                    case 0:
                        {
                            if (!esDerivada && !esIntegral)
                            {
                                txtPantalla.Text = calculadora.calcularResultado(txtPantallaOp.Text);
                            }
                            else if (esDerivada)
                            {
                                int inicio = txtPantallaOp.Text.IndexOf("("), cerrado = txtPantallaOp.Text.LastIndexOf(")");
                                string funcion = txtPantallaOp.Text.Substring(inicio + 1, cerrado - 1);
                                int valorA = txtPantallaOp.Text.LastIndexOf("=") + 1;
                                double evaluar = double.Parse(txtPantallaOp.Text.Substring(valorA));
                                txtPantalla.Text = graficadora.DerivadaNumerica(funcion, evaluar).ToString();
                                esDerivada = false;
                            }
                            else
                            {
                                int inicio = txtPantallaOp.Text.IndexOf("("), cerrado = txtPantallaOp.Text.LastIndexOf(")");
                                string funcion = txtPantallaOp.Text.Substring(inicio + 1, cerrado - 1);
                                int valorA = txtPantallaOp.Text.IndexOf("=") + 1;
                                int valorB = txtPantallaOp.Text.LastIndexOf("=") + 1;
                                int separacion = txtPantallaOp.Text.IndexOf("|") - 1;
                                double evaluarA = double.Parse(txtPantallaOp.Text.Substring(valorA, separacion - valorA + 1));
                                double evaluarB = double.Parse(txtPantallaOp.Text.Substring(valorB));
                                txtPantalla.Text = graficadora.IntegralTrapecio(funcion, evaluarA, evaluarB).ToString();
                                esDerivada = false;
                            }

                        }
                        break;
                    case 1:
                        {
                            valoresX.Clear();
                            valoresY.Clear();


                            chrtGrafico.Series.Clear();
                            dgvEvaluaciones.Rows.Clear();
                            dgvEvaluaciones.Columns["y"].HeaderText = txtPantallaOp.Text;

                            chrtGrafico.ChartAreas[0].AxisX.Title = "Eje X";
                            chrtGrafico.ChartAreas[0].AxisY.Title = "Eje Y";

                            chrtGrafico.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
                            chrtGrafico.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
                            chrtGrafico.ChartAreas[0].AxisX.LineColor = Color.Black;
                            chrtGrafico.ChartAreas[0].AxisY.LineColor = Color.Black;

                            chrtGrafico.ChartAreas[0].AxisY.Crossing = 0;
                            chrtGrafico.ChartAreas[0].AxisX.Crossing = 0;

                            chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                            chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                            chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                            chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;

                            chrtGrafico.ChartAreas[0].AxisX.MajorTickMark.Enabled = true;
                            chrtGrafico.ChartAreas[0].AxisY.MajorTickMark.Enabled = true;
                            chrtGrafico.ChartAreas[0].AxisX.MinorTickMark.Enabled = true;
                            chrtGrafico.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;

                            if (valorFinalX < valorInicioX)
                            {
                                valorFinalX += valorInicioX;
                            }
                            while (incremento > Math.Abs(valorFinalX - valorInicioX))
                            {
                                incremento /= 100;
                            }

                            if (esDerivada)
                            {
                                int inicio = txtPantallaOp.Text.IndexOf("("), cerrado = txtPantallaOp.Text.LastIndexOf(")");
                                string funcion = txtPantallaOp.Text.Substring(inicio + 1, cerrado - 1);
                                int valorA = txtPantallaOp.Text.LastIndexOf("=") + 1;
                                double evaluar = double.Parse(txtPantallaOp.Text.Substring(valorA));
                                //string derivada = graficadora.DerivadaNumerica(funcion, evaluar).ToString();
                                GraficarDerivada(funcion, evaluar);

                            }

                            else if (esIntegral)
                            {
                                int inicio = txtPantallaOp.Text.IndexOf("("), cerrado = txtPantallaOp.Text.LastIndexOf(")");
                                string funcion = txtPantallaOp.Text.Substring(inicio + 1, cerrado - 1);
                                int valorA = txtPantallaOp.Text.IndexOf("=") + 1;
                                int valorB = txtPantallaOp.Text.LastIndexOf("=") + 1;
                                int separacion = txtPantallaOp.Text.IndexOf("|") - 1;
                                double evaluarA = double.Parse(txtPantallaOp.Text.Substring(valorA, separacion - valorA + 1));
                                double evaluarB = double.Parse(txtPantallaOp.Text.Substring(valorB));
                                GraficarIntegral(funcion, evaluarA, evaluarB);
                                //esIntegral = false;
                            }
                            else
                            {
                                GraficarFuncion(txtPantallaOp.Text);
                            }

                        }
                        break;
                }
                funcionSecundaria = 0;
            }
            catch (Exception ex)
            {
                txtPantalla.Text = ex.Message;
            }
        }
        //dsssssssssssssssssssssssssssssssssssssssssssssssssss
        private void GraficarDerivada(string funcion, double a)
        {
            GraficarFuncion(funcion);

            Series serieDerivada = new Series("Derivada");
            serieDerivada.ChartType = SeriesChartType.Line;
            serieDerivada.BorderWidth = 2;
            serieDerivada.Color = Color.FromArgb(50, Color.Red);
            chrtGrafico.Series.Add(serieDerivada);

            double derivada = graficadora.DerivadaNumerica(funcion, a);
            for (double x = valorInicioX; x <= valorFinalX; x += 0.01)
            {
                
                double valorEnA = graficadora.calcularResultado(funcion, a);
                double y = valorEnA + derivada*(x-a);
                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    serieDerivada.Points.AddXY(x, y);
                    dgvEvaluaciones.Rows.Add(x, y);
                }
            }
        }
        private void GraficarFuncion(string funcion, string nombreSerie = null)
        {
            valoresX.Clear();
            valoresY.Clear();

            Series serie = new Series(funcion);
            serie.ChartType = SeriesChartType.Line;
            serie.BorderWidth = 2;
            serie.Color = colorGrafico;
            chrtGrafico.Series.Add(serie);

            for (double x = valorInicioX; x <= valorFinalX; x += incremento)
            {
                double y = graficadora.calcularResultado(funcion, x);
                valoresX.Add(x);
                valoresY.Add(y);

                dgvEvaluaciones.Rows.Add(x, y);
            }
            int contador = 0;
            for (int i = 0; i < valoresY.Count - 1; i++)
            {
                if (!double.IsNaN(valoresY[i]) && !double.IsInfinity(valoresY[i])
                    && Math.Abs(valoresY[i]) < epsilon && Math.Abs(valoresY[i]) > 1 / epsilon)
                {
                    chrtGrafico.Series[contador].Points.AddXY(valoresX[i], valoresY[i]);
                }
                else
                {
                    if (!double.IsNaN(valoresY[i + 1]))
                    {
                        contador++;
                        Series serie1 = new Series(funcion + $"{contador}");
                        serie1.ChartType = SeriesChartType.Line;
                        serie1.BorderWidth = 2;
                        serie1.Color = colorGrafico;
                        serie1.IsVisibleInLegend = false;
                        chrtGrafico.Series.Add(serie1);
                    }
                }
            }
            chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
            chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
            chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
            chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
        }

        private void GraficarIntegral(string funcion, double a, double b)
        {

            GraficarFuncion(funcion, "Función");

            Series serieIntegral = new Series("Integral");
            serieIntegral.ChartType = SeriesChartType.Area;
            serieIntegral.Color = Color.FromArgb(50, Color.Red);
            chrtGrafico.Series.Add(serieIntegral);

            for (double x = a; x <= b; x += 0.01)
            {
                double y = graficadora.calcularResultado(funcion, x);
                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    serieIntegral.Points.AddXY(x, y);
                    dgvEvaluaciones.Rows.Add(x, y);
                }
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    ecuacionPrevia.Clear();
                    ecuacionPrevia.Add("0");
                    existeRsultado = false;
                    calculadora.ans = 0;
                    txtPantalla.Text = "0";
                    txtPantallaOp.Text = "0";
                    funcionSecundaria = 0;
                    esIntegral = false;
                    esDerivada = false;
                    break;
                case 1:
                    Close();
                    break;
            }

        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            existeRsultado = false;
            txtPantalla.Text = "0";
            txtPantallaOp.Text = "0";
            funcionSecundaria = 0;
            esIntegral = false;
            esDerivada = false;
        }

        private void btnPotencia2_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^2";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^2";
                        else
                            txtPantallaOp.Text = "^2";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^3";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^3";
                        else
                            txtPantallaOp.Text = "^3";
                    }
                    break;
            }
            funcionSecundaria = 0;

        }

        private void btnPotenciaX_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^(";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^(";
                        else
                            txtPantallaOp.Text = "^(";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^(1/";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^(1/";
                        else
                            txtPantallaOp.Text = "^(1/";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (txtPantallaOp.Text != "0")
                        txtPantallaOp.Text += "ans";
                    else
                        txtPantallaOp.Text = "ans";
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "(/100)";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "(/100)";
                        else
                            txtPantallaOp.Text = "(/100)";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^(1/2)";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^(1/2)";
                        else
                            txtPantallaOp.Text = "^(1/2)";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^(1/3)";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^(1/3)";
                        else
                            txtPantallaOp.Text = "^(1/3)";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "log(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "log(";
                        else
                            txtPantallaOp.Text = "log(";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "*10^(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "10^(";
                        else
                            txtPantallaOp.Text = "10^(";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ln(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "ln(";
                        else
                            txtPantallaOp.Text = "ln(";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "euler^(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "euler^(";
                        else
                            txtPantallaOp.Text = "euler^(";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btn10ElevadoX_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "*10^";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "*10^";
                        else
                            txtPantallaOp.Text = "*10^";
                    }

                    break;
                case 1: txtPantallaOp.Text += "pi"; break;
                case 2: txtPantallaOp.Text += "euler"; break;
            }
            funcionSecundaria = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "^(-1)";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "^(-1)";
                        else
                            txtPantallaOp.Text = "^(-1)";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "!";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "!";
                        else
                            txtPantallaOp.Text = "!";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "sin(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "sin(";
                        else
                            txtPantallaOp.Text = "sin(";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "asin(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "asin(";
                        else
                            txtPantallaOp.Text = "asin(";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "cos(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                        {
                            txtPantallaOp.Text += "cos(";
                        }
                        else
                        {
                            txtPantallaOp.Text = "cos(";
                        }
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "acos(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "acos(";
                        else
                            txtPantallaOp.Text = "acos(";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "tan(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                        {
                            txtPantallaOp.Text += "tan(";
                        }
                        else
                        {
                            txtPantallaOp.Text = "tan(";
                        }
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "atan(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                        {
                            txtPantallaOp.Text += "atan(";
                        }
                        else
                        {
                            txtPantallaOp.Text = "atan(";
                        }
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnFraccion_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + '/';
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += '/';
                        else
                            txtPantallaOp.Text = "/";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "(" + "ans" + "*1+1)/1";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "(*1+1)/1";
                        else
                            txtPantallaOp.Text = "(*1+1)/1";
                    }
                    break;
                case 2:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + "R";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "R";
                        else
                            txtPantallaOp.Text = "R";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "ans" + '-';
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += '-';
                        else
                            txtPantallaOp.Text = "-";
                    }
                    break;
                case 1:
                    if (existeRsultado)
                    {
                        txtPantallaOp.Text = "log10(" + "ans";
                        existeRsultado = false;
                    }
                    else
                    {
                        if (txtPantallaOp.Text != "0")
                            txtPantallaOp.Text += "log10(";
                        else
                            txtPantallaOp.Text = "log10(";
                    }
                    break;
            }
            funcionSecundaria = 0;
        }

        private void btnParentesisAbierto_Click(object sender, EventArgs e)
        {
            txtPantallaOp.Text += "(";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtPantallaOp.Text.Length > 1)
            {
                txtPantallaOp.Text = txtPantallaOp.Text.Remove(txtPantallaOp.Text.Length - 1);
            }
            else
            {
                txtPantallaOp.Text = "0";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPantalla.Select();
            tmrSistema.Enabled = true;
            cmbRendimiento.SelectedIndex = 0;
            chrtRendimiento.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chrtRendimiento.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chrtGrafico.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chrtGrafico.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chrtRendimiento.Series[0].Color = Color.FromArgb(43, 141, 163, 255);
            chrtRendimiento.Series[1].Color = Color.FromArgb(97, 113, 186, 255);
            chrtRendimiento.Series[2].Color = Color.FromArgb(43, 141, 163, 255);
            chrtRendimiento.Series[3].Color = Color.FromArgb(43, 141, 163, 255);

            ecuacionPrevia.Add("0");
            btnOn_Click(sender, new EventArgs());
        }

        private void btnParentesisCerrado_Click(object sender, EventArgs e)
        {
            txtPantallaOp.Text += ")";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            txtPantallaOp.Text += "x";
        }

        private void colorGraficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cuadroColor = new ColorDialog();
            cuadroColor.ShowDialog();
            colorGrafico = cuadroColor.Color;
            chrtGrafico.Series[0].Color = colorGrafico;
        }

        private void valorInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorInicioX = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor minimo que desea en el eje x", "Valor minimo x"));
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valorFinalXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorFinalX = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor maximo que desea en el eje x", "Valor maximo x"));
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void incrementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                incrementoSimulador = 0;
                incremento = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor de incremento en el eje x", "Incremento"));
                if (!tmrSimulador.Enabled)
                {
                    funcionSecundaria = 1;
                    btnIgual_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tmrSimulador.Enabled)
            {
                incrementoSimulador = valorInicioX;
                tmrSimulador.Enabled = true;
                chrtGrafico.Series.Clear();
                dgvEvaluaciones.Rows.Clear();
                Series serie = new Series(txtPantallaOp.Text);
                serie.ChartType = SeriesChartType.Line;
                serie.BorderWidth = 2;
                serie.Color = colorGrafico;
                chrtGrafico.Series.Add(serie);
                dgvEvaluaciones.Columns["y"].HeaderText = txtPantallaOp.Text;
            }
        }

        private void detenerSimuladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrSimulador.Enabled = false;
            incrementoSimulador = 0;
            cont = 0;
            contaux = 0;
        }

        int cont = 0;
        int contaux = 0;
        private void tmrSimulador_Tick(object sender, EventArgs e)
        {

            incrementoSimulador += incremento;
            double y = graficadora.calcularResultado(txtPantallaOp.Text, incrementoSimulador);
            valoresX.Add(incrementoSimulador);
            valoresY.Add(y);

            dgvEvaluaciones.Rows.Add(incrementoSimulador, y);
            if (!double.IsNaN(valoresY[cont]) && !double.IsInfinity(valoresY[cont]) && Math.Abs(valoresY[cont]) < epsilon
            && Math.Abs(valoresY[cont]) > 1 / epsilon)
            {
                chrtGrafico.Series[contaux].Points.AddXY(valoresX[cont], valoresY[cont]);
            }
            else
            {
                if (!double.IsNaN(valoresY[cont]))
                {
                    contaux++;
                    Series serie1 = new Series(txtPantallaOp.Text + $"{cont}");
                    serie1.ChartType = SeriesChartType.Line;
                    serie1.BorderWidth = 2;
                    serie1.Color = colorGrafico;
                    serie1.IsVisibleInLegend = false;
                    chrtGrafico.Series.Add(serie1);
                }
            }
            cont++;
        }

        private void valorInicioYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorInicioY = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor minimo que desea en el eje y", "Valor minimo y"));
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valorFinalYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorFinalY = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un valor maximo que desea en el eje y", "Valor maximo y"));
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void graficoAdaptadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorInicioX = valoresX.Min();
                valorFinalX = valoresX.Max();
                valorInicioY = valoresY.Min();
                valorFinalY = valoresY.Max();
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void valoresPredeterminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                valorInicioX = -10;
                valorFinalX = 10;
                incremento = 0.01;
                valorInicioY = -10;
                valorFinalY = 10;
                chrtGrafico.ChartAreas[0].AxisX.Minimum = valorInicioX;
                chrtGrafico.ChartAreas[0].AxisX.Maximum = valorFinalX;
                chrtGrafico.ChartAreas[0].AxisY.Minimum = valorInicioY;
                chrtGrafico.ChartAreas[0].AxisY.Maximum = valorFinalY;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void epsilonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                epsilon = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de epsilon", "Epsilon para evitar errores"));
                if (!tmrSimulador.Enabled)
                {
                    funcionSecundaria = 1;
                    btnIgual_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tmrSistema_Tick(object sender, EventArgs e)
        {
            double b = 0;
            contadorSistema++;
            switch (graficoRendimiento)
            {
                case 0:
                    b = graficadora.ObtenerCPU();
                    chrtRendimiento.Series[0].Points.AddXY(contadorSistema, b);
                    label1.Text = $"Uso: {Math.Round(b)}%";
                    break;
                case 1:
                    b = graficadora.ObtenerRam();
                    chrtRendimiento.Series[1].Points.AddXY(contadorSistema, b);
                    label1.Text = $"Uso: {Math.Round(b)} mb";
                    break;
                case 2:
                    b = graficadora.ObtenerVelocidadLecturaDisco();
                    chrtRendimiento.Series[2].Points.AddXY(contadorSistema, b);
                    label1.Text = $"Velocidad de lectura: {Math.Round(b, 1)} kb/s";
                    break;
                case 3:
                    b = graficadora.ObtenerVelocidadEscrituraDisco();
                    chrtRendimiento.Series[3].Points.AddXY(contadorSistema, b);
                    label1.Text = $"Velocidad de escritura: {Math.Round(b, 1)} kb/s";
                    break;
            }
            label2.Text = $"Tiempo activo: {graficadora.FormatearTiempoActivo(TimeSpan.FromSeconds(graficadora.ObtenerTiempoActividad()))}";
            if (contadorSistema > 15)
            {
                chrtRendimiento.ChartAreas[0].AxisX.Minimum = contadorSistema - 10;
                chrtRendimiento.ChartAreas[0].AxisX.Maximum = contadorSistema;
            }
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            switch (funcionSecundaria)
            {
                case 0:
                    {
                        esIntegral = true;
                        txtPantallaOp.Text = "Integral()a=|b=";
                    }
                    break;
                case 1:
                    {
                        esDerivada = true;
                        txtPantallaOp.Text = "der()a=";
                    }
                    break;
            }
            funcionSecundaria = 0;
            double derivadaEnX = graficadora.DerivadaNumerica(txtPantallaOp.Text, 2);
            txtPantalla.Text = derivadaEnX.ToString();
        }



        private void cmbRendimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            chrtRendimiento.Series[graficoRendimiento].Points.Clear();
            graficoRendimiento = cmbRendimiento.SelectedIndex;
        }

        private void btnPrevio_Click(object sender, EventArgs e)
        {
            try
            {
                contadorEcuacion--;
                txtPantallaOp.Text = ecuacionPrevia[contadorEcuacion];
            }
            catch (Exception ex)
            {
                txtPantallaOp.Text = ecuacionPrevia.First();
            }
        }

        private void btnPosterior_Click(object sender, EventArgs e)
        {
            try
            {
                contadorEcuacion++;
                txtPantallaOp.Text = ecuacionPrevia[contadorEcuacion];
            }
            catch (Exception ex)
            {
                txtPantallaOp.Text = ecuacionPrevia.Last();
            }
        }
    }
}

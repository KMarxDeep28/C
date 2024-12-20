using System;
using System.Diagnostics;

public class ClaseGraficadora
{
    public List<object> coeficientesOperaciones;
    public const double pi = Math.PI, euler = Math.E;
    public ClaseGraficadora()
    {
        coeficientesOperaciones = new List<object>();
    }

    public void separarNumerosOperaciones(string pantallaOperacion, double x)
    {
        coeficientesOperaciones.Clear();
        string? numero = null;
        string? operacion = null;
        bool esNumeroNegativo = false;

        for (int i = 0; i < pantallaOperacion.Length; i++)
        {
            char auxiliar = pantallaOperacion[i];
            if (char.IsLetter(auxiliar) && auxiliar != 'x' && auxiliar != 'R')
            {
                operacion += auxiliar;
                if (esFuncion(operacion))
                {
                    if (esNumeroNegativo)
                    {
                        coeficientesOperaciones.Add(-1.0);
                        coeficientesOperaciones.Add("*");
                        esNumeroNegativo = false;
                    }
                    coeficientesOperaciones.Add(operacion);
                    operacion = null;
                }
                if (operacion == "pi")
                {
                    coeficientesOperaciones.Add(pi);
                    operacion = null;
                }
                if (operacion == "euler")
                {
                    coeficientesOperaciones.Add(euler);
                    operacion = null;
                }
            }
            else if (auxiliar == 'x')
            {
                coeficientesOperaciones.Add(x);
            }
            else if (char.IsDigit(auxiliar) || auxiliar == '.')
            {
                numero += auxiliar;
            }
            else
            {
                if (auxiliar == '-' && (i == 0 || pantallaOperacion[i - 1] == '(' || !char.IsDigit(pantallaOperacion[i - 1])))
                {
                    esNumeroNegativo = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(numero))
                    {
                        coeficientesOperaciones.Add(double.Parse(esNumeroNegativo ? "-" + numero : numero));
                        numero = null;
                        esNumeroNegativo = false;
                    }
                    if (!string.IsNullOrEmpty(operacion))
                    {
                        coeficientesOperaciones.Add(operacion);
                        operacion = null;
                    }
                    if (auxiliar == '(' && esNumeroNegativo)
                    {
                        coeficientesOperaciones.Add(-1.0); // Añadimos -1 para multiplicar por la expresión dentro del paréntesis
                        coeficientesOperaciones.Add("*");
                        esNumeroNegativo = false;
                    }
                    coeficientesOperaciones.Add(auxiliar.ToString());
                }
            }
        }
        if (!string.IsNullOrEmpty(numero))
        {
            coeficientesOperaciones.Add(double.Parse(numero));
        }
        if (!string.IsNullOrEmpty(operacion))
        {
            coeficientesOperaciones.Add(operacion);
        }
    }

    public double calcularResultado(string pantallaOperaciones, double x)
    {
        try
        {
            separarNumerosOperaciones(pantallaOperaciones, x);
            ComprobacionErrores();

            while (coeficientesOperaciones.Contains("(") && coeficientesOperaciones.Contains(")"))
            {
                int abierto = coeficientesOperaciones.LastIndexOf("("), cerrado = coeficientesOperaciones.IndexOf(")", abierto);
                double resultadoParentesis = evaluacionJerarquiaParentesis(abierto + 1, cerrado - 1);
                coeficientesOperaciones.RemoveRange(abierto, cerrado - abierto + 1);
                coeficientesOperaciones.Insert(abierto, resultadoParentesis);
            }

            Double resultadoFinal = evaluacionJerarquia();
            return Math.Round(resultadoFinal, 10);
        }
        catch (Exception ex)
        {
            return 0;
        }
    }

    public double evaluacionJerarquia()
    {
        return evaluacionJerarquiaSublista(coeficientesOperaciones);
    }

    public double evaluacionJerarquiaParentesis(int inicio, int final)
    {
        List<object> subValores = coeficientesOperaciones.GetRange(inicio, final - inicio + 1);

        return evaluacionJerarquiaSublista(subValores);
    }

    private double evaluacionJerarquiaSublista(List<object> subValores)
    {
        for (int i = 0; i < subValores.Count; i++)
        {
            if (subValores[i] is string && esFuncion(subValores[i].ToString()))
            {
                subValores[i] = realizandoOperaciones(subValores, i);
                subValores.RemoveAt(i + 1);
                i--;
            }
        }

        for (int i = 0; i < subValores.Count; i++)
        {
            if (subValores[i].ToString() == "!")
            {
                subValores[i - 1] = realizandoOperaciones(subValores, i);
                subValores.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < subValores.Count; i++)
        {
            if (subValores[i].ToString() == "^")
            {
                subValores[i - 1] = realizandoOperaciones(subValores, i);
                subValores.RemoveAt(i);
                subValores.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < subValores.Count; i++)
        {
            if (subValores[i].ToString() == "*" || subValores[i].ToString() == "/" || subValores[i].ToString() == "R")
            {
                subValores[i - 1] = realizandoOperaciones(subValores, i);
                subValores.RemoveAt(i);
                subValores.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < subValores.Count; i++)
        {
            if (subValores[i].ToString() == "+" || subValores[i].ToString() == "-")
            {
                subValores[i - 1] = realizandoOperaciones(subValores, i);
                subValores.RemoveAt(i);
                subValores.RemoveAt(i);
                i--;
            }
        }

        return (double)subValores[0];
    }

    private Boolean esFuncion(string operacion)
    {
        return operacion == "log" || operacion == "ln" || operacion == "sin" ||
    operacion == "cos" || operacion == "tan" || operacion == "asin" ||
    operacion == "acos" || operacion == "atan";
    }

    public double realizandoOperaciones(List<object> valores, int indice)
    {
        string operacion = valores[indice].ToString();
        switch (operacion)
        {
            case "+":
                {
                    return (double)valores[indice - 1] + (double)valores[indice + 1];
                }
            case "-":
                {
                    return (double)valores[indice - 1] - (double)valores[indice + 1];
                }
            case "*":
                {
                    return (double)valores[indice - 1] * (double)valores[indice + 1];
                }
            case "/":
                {
                    return (double)valores[indice - 1] / (double)valores[indice + 1];
                }
            case "R":
                {
                    return (double)valores[indice - 1] % (double)valores[indice + 1];
                }
            case "^":
                {
                    return Math.Pow((double)valores[indice - 1], (double)valores[indice + 1]);
                }
            case "!":
                {
                    int a = 1;
                    for (int i = 1; i <= Convert.ToInt32(valores[indice - 1]); i++)
                    {
                        a *= i;
                    }
                    return (double)a;
                }
            case "log":
                {
                    return Math.Log((double)valores[indice + 2], (double)valores[indice + 1]);
                }

            case "ln":
                {
                    return Math.Log((double)valores[indice + 1]);
                }
            case "sin":
                {
                    return Math.Sin((double)valores[indice + 1]);
                }
            case "asin":
                {
                    return Math.Asin((double)valores[indice + 1]);
                }
            case "cos":
                {
                    return Math.Cos((double)valores[indice + 1]);
                }
            case "acos":
                {
                    return Math.Acos((double)valores[indice + 1]);
                }
            case "tan":
                {
                    return Math.Tan((double)valores[indice + 1]);
                }
            case "atan":
                {
                    return Math.Atan((double)valores[indice + 1]);
                }
            default:
                {
                    throw new InvalidOperationException("Operacion no valida");
                }
        }
    }

    public void ComprobacionErrores()
    {
        for (int i = 1; i < coeficientesOperaciones.Count; i++)
        {
            if (coeficientesOperaciones[i] is string && coeficientesOperaciones[i].ToString() == coeficientesOperaciones[i - 1].ToString() &&
                (coeficientesOperaciones[i].ToString() != ")" && coeficientesOperaciones[i].ToString() != "("))
            {
                string operador = coeficientesOperaciones[i].ToString();
                int contador = 1;

                while (i + 1 < coeficientesOperaciones.Count && coeficientesOperaciones[i + 1].ToString() == operador)
                {
                    contador++;
                    coeficientesOperaciones.RemoveAt(i + 1);
                }

                if (operador == "-")
                {
                    if (contador % 2 != 0)
                    {
                        coeficientesOperaciones[i - 1] = "+";
                    }
                    else
                    {
                        coeficientesOperaciones[i - 1] = "-";
                    }
                    coeficientesOperaciones.RemoveAt(i);
                    i--;
                }
                else
                {
                    coeficientesOperaciones.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    public double ObtenerCPU()
    {
        using (PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
        {
            cpuCounter.NextValue();
            Thread.Sleep(1000);
            return cpuCounter.NextValue();
        }
    }

    public double ObtenerRam()
    {
        Process procesoRam = Process.GetCurrentProcess();
        double memoriaUsada = procesoRam.WorkingSet64;
        double memoriaUsadaMB = memoriaUsada / (1024 * 1024);
        return memoriaUsadaMB;
    }

    public double ObtenerVelocidadLecturaDisco()
    {
        using (PerformanceCounter lectura = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total"))
        {
            lectura.NextValue();
            Thread.Sleep(1000);
            return lectura.NextValue() / 1024.0;
        }
    }

    public double ObtenerVelocidadEscrituraDisco()
    {
        using (PerformanceCounter escritura = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total"))
        {
            escritura.NextValue();
            Thread.Sleep(1000);
            return escritura.NextValue() / 1024.0;
        }
    }

    public double ObtenerTiempoActividad()
    {
        using (PerformanceCounter uptimeCounter = new PerformanceCounter("System", "System Up Time"))
        {
            uptimeCounter.NextValue();
            return uptimeCounter.NextValue();
        }
    }

    public string FormatearTiempoActivo(TimeSpan tiempoActivo)
    {
        return string.Format("{0:D2}:{1:D2}:{2:D2}",
            tiempoActivo.Hours,
            tiempoActivo.Minutes,
            tiempoActivo.Seconds);
    }

    public double DerivadaNumerica(string pantallaOperaciones, double x, double h = 1e-5)
    {
        double f_x_h = calcularResultado(pantallaOperaciones, x + h);
        double f_x_minus_h = calcularResultado(pantallaOperaciones, x - h);
        return (f_x_h - f_x_minus_h) / (2 * h);
    }

    public double IntegralTrapecio(string pantallaOperaciones, double a, double b, int n = 1000)
    {
        double h = (b - a) / n;
        double sum = 0.5 * (calcularResultado(pantallaOperaciones, a) + calcularResultado(pantallaOperaciones, b));

        for (int i = 1; i < n; i++)
        {
            double x = a + i * h;
            sum += calcularResultado(pantallaOperaciones, x);
        }

        return h * sum;
    }

}
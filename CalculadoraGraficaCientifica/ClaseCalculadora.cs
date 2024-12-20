using System;

public class ClaseCalculadora
{

    public List<object> valores;
    public double ans = 0;
    public const double pi = Math.PI, euler = Math.E;
    public ClaseCalculadora()
    {
        valores = new List<object>();
    }

    public void separarNumerosOperaciones(string pantallaOperacion)
    {
        valores.Clear();
        string? numero = null;
        string? operacion = null;
        bool esNumeroNegativo = false;

        for (int i = 0; i < pantallaOperacion.Length; i++)
        {
            char auxiliar = pantallaOperacion[i];
            if (char.IsLetter(auxiliar) && auxiliar != 'R')
            {
                operacion += auxiliar;
                if (esFuncion(operacion))
                {
                    if (esNumeroNegativo)
                    {
                        valores.Add(-1.0);
                        valores.Add("*");
                        esNumeroNegativo = false;
                    }
                    valores.Add(operacion);
                    operacion = null;
                }
                if (operacion == "pi")
                {
                    valores.Add(pi);
                    operacion = null;
                }
                if (operacion == "euler")
                {
                    valores.Add(euler);
                    operacion = null;
                }
                if (operacion == "ans")
                {
                    valores.Add(ans);
                    operacion = null;
                }
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
                        valores.Add(double.Parse(esNumeroNegativo ? "-" + numero : numero));
                        numero = null;
                        esNumeroNegativo = false;
                    }
                    if (!string.IsNullOrEmpty(operacion))
                    {
                        valores.Add(operacion);
                        operacion = null;
                    }
                    if (auxiliar == '(' && esNumeroNegativo)
                    {
                        valores.Add(-1.0);
                        valores.Add("*");
                        esNumeroNegativo = false;
                    }
                    valores.Add(auxiliar.ToString());
                }
            }
        }
        if (!string.IsNullOrEmpty(numero))
        {
            valores.Add(double.Parse(numero));
        }
        if (!string.IsNullOrEmpty(operacion))
        {
            valores.Add(operacion);
        }
    }

    public string calcularResultado(string pantallaOperaciones)
    {
        try
        {
            separarNumerosOperaciones(pantallaOperaciones);
            ComprobacionErrores();

            while (valores.Contains("(") && valores.Contains(")"))
            {
                int abierto = valores.LastIndexOf("("), cerrado = valores.IndexOf(")", abierto);
                double resultadoParentesis = evaluacionJerarquiaParentesis(abierto + 1, cerrado - 1);
                valores.RemoveRange(abierto, cerrado - abierto + 1);
                valores.Insert(abierto, resultadoParentesis);
            }

            Double resultadoFinal = evaluacionJerarquia();
            ans = resultadoFinal;
            return Math.Round(resultadoFinal, 10).ToString();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public double evaluacionJerarquia()
    {
        return evaluacionJerarquiaSublista(valores);
    }

    public double evaluacionJerarquiaParentesis(int inicio, int final)
    {
        List<object> subValores = valores.GetRange(inicio, final - inicio + 1);

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
        for (int i = 1; i < valores.Count; i++)
        {
            if (valores[i] is string && valores[i].ToString() == valores[i - 1].ToString() &&
                (valores[i].ToString() != ")" && valores[i].ToString() != "("))
            {
                string operador = valores[i].ToString();
                int contador = 1;

                while (i + 1 < valores.Count && valores[i + 1].ToString() == operador)
                {
                    contador++;
                    valores.RemoveAt(i + 1);
                }

                if (operador == "-")
                {
                    if (contador % 2 != 0)
                    {
                        valores[i - 1] = "+";
                    }
                    else
                    {
                        valores[i - 1] = "-";
                    }
                    valores.RemoveAt(i);
                    i--;
                }
                else
                {
                    valores.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}

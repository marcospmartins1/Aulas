using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalculadora
{
    class Calculadora
    {
        public string res;
        public string label;
        public double valor1;
        public double valor2;
        public string op;

        public void Somar()
        {
            op = "+";
            res = "";
        }

        public void Igual()
        {
            double resultado = 0;

            if (op == "+")
            {
                resultado = valor1 + valor2;
                label = resultado.ToString();
            }
            else if (op == "-")
            {
                resultado = valor1 - valor2;
                label = resultado.ToString();
            }
            else if (op == "*")
            {
                resultado = valor1 * valor2;
                label = resultado.ToString();
            }
            else if (op == "/")
            {
                resultado = valor1 / valor2;
                label = resultado.ToString();
            }
        }

        public void Limpar()
        {
            label = "";
            valor1 = 0;
            valor2 = 0;
            op = "";
        }
    }
}

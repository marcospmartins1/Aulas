using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalculadora
{
    class Calculadora
    {
        public double valor1;
        public double valor2;
        public string operacao;
        public string label

        public void Somar()
        {
            operacao = "SOMA";
        }

        public void Igual()
        {
            double resultado = 0;

            if (operacao == "SOMA")
            {
                resultado = valor1 + valor2;
                label = resultado.ToString();
            }
            else if (operacao == "-")
            {
                resultado = valor1 - valor2;
                label = resultado.ToString();
            }
            else if (operacao == "*")
            {
                resultado = valor1 * valor2;
                label = resultado.ToString();
            }
            else if (operacao == "/")
            {
                resultado = valor1 / valor2;
                label = resultado.ToString();
            }
        }
    }
}

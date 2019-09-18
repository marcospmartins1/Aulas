using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalculadora
{
    public partial class MainPage : ContentPage
    {
        private double valor1;
        private double valor2;
        private string operacao;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "7";
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "8";
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "9";
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "6";
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "5";
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "4";
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "3";

        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "2";
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "1";
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text += "0";
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "SOMA";
        }

        private void BtnSubtrair_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "SUBTRAIR";
        }

        private void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "MULTIPLICAR";
        }

        private void BtnDividir_Clicked(object sender, EventArgs e)
        {
            this.valor1 = Convert.ToDouble(entryNumero.Text);
            entryNumero.Text = "";
            this.operacao = "DIVIDIR";
        }

        private void BtnIgual_Clicked(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            this.valor2 = Convert.ToDouble(entryNumero.Text);

            switch (this.operacao)
            {
                case "SOMA":
                    entryNumero.Text = calculadora.Somar(this.valor1, this.valor2).ToString();
                    break;

                case "SUBTRAIR":
                    entryNumero.Text = calculadora.Subtrair(this.valor1, this.valor2).ToString();
                    break;

                case "MULTIPLICAR":
                    entryNumero.Text = calculadora.Multiplicar(this.valor1, this.valor2).ToString();
                    break;

                case "DIVIDIR":
                    entryNumero.Text = calculadora.Dividir(this.valor1, this.valor2).ToString();
                    break;

                default:
                    DisplayAlert("Ops..", "HOUVE UM ERRO! \n TENTE NOVAMENTE", "OK");
                    break;
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            entryNumero.Text = "";
            this.valor1 = 0;
            this.valor2 = 0;
            this.operacao = "";
        }
    }
}

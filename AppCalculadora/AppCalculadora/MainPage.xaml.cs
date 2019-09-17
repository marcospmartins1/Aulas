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

        private void BtnIgual_Clicked(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.valor2 = Convert.ToDouble(entryNumero.Text);

            calculadora.Igual();

            entryNumero.Text = calculadora.label;
        }
        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.valor1 += Convert.ToDouble(entryNumero.Text);
            calculadora.Somar();

            entryNumero.Text = calculadora.res;
        }

        private void BtnSubtrair_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnMultiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnDividir_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Clicked_1(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.label = entryNumero.Text;
        }
    }
}

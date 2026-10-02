using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmInicio : Form
    {

        double num1 = 0;
        string operacion = "";
        String memoria = "";

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Txt1.Text += boton.Text;
        }

        private void Btn_Clear(object sender, EventArgs e)
        {
            Txt1.Text = "";
        }

        private void Btn_CE (object sender, EventArgs e)
        {
            if (Txt1.TextLength == 0) Txt1.Text = "0";
            else Txt1.Text = Txt1.Text.Substring(0,Txt1.TextLength - 1);
        }


        // de momento solo funciona el boton de sumar y el del igual
        private void BtnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Txt1.Text); // se guarda el numero de la pantlla
            operacion = "+";
            Txt1.Text = "";
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Txt1.Text); // se guarda el numero de la pantlla
            operacion = "-";
            Txt1.Text = "";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Txt1.Text); // se guarda el numero de la pantlla
            operacion = "*";
            Txt1.Text = "";
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Txt1.Text); // se guarda el numero de la pantlla
            operacion = "/";
            Txt1.Text = "";
        }

        private void BtnMS_Click(object sender, EventArgs e)
        {
            memoria = Txt1.Text;
        }

        private void BtnMR_Click(object sender, EventArgs e)
        {
            Txt1.Text = memoria;
        }

        private void BtnMC_Click (object sender, EventArgs e)
        {
            memoria = "";
        }

        private void BtnMPlus_Click (object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(memoria) + Convert.ToDouble(Txt1.Text);
            memoria = Convert.ToString(resultado);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(Txt1.Text); // se guarda el otro numeor

            if (operacion == "+")
            {
                double resultado = num1 + num2;
                Txt1.Text = Convert.ToString(resultado); // Mostramos el resultado
            }
            else if (operacion == "-")
            {
                double resultado = num1 - num2;
                Txt1.Text = Convert.ToString(resultado);
            }
            else if (operacion == "*")
            {
                double resultado = num1 * num2;
                Txt1.Text = Convert.ToString(resultado);
            }
            else if (operacion == "/")
            {
                double resultado = num1 / num2;
                Txt1.Text = Convert.ToString(resultado);
            }
        }
    }
}

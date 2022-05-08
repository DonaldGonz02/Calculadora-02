using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_0202
{
    public enum operacion
    {
        DefinedNot = 0,
        Suma = 1,
        Resta = 2,
        Divicion = 3,
        Multiplicacion = 4,
    }
    public partial class Form1 : Form
    {
        double value1 = 0;
        double value2 = 0;
        operacion operador = operacion.DefinedNot;
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            if (Resultados.Text == "0" && Resultados.Text != null)
            {
                Resultados.Text = numero;
            }
            else
            {
                Resultados.Text += numero;
            }
        }
        private double RealizarOpe()
        {
            double Resultado = 0;
            switch (operador)
            {
                case operacion.Suma:
                    Resultado = value1 + value2;
                    break;
                case operacion.Resta:
                    Resultado = value1 - value2;
                    break;
                case operacion.Divicion:
                    Resultado = value1 / value2;
                    break;
                case operacion.Multiplicacion:
                    Resultado = value1 * value2;
                    break;
            }
            return Resultado;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (Resultados.Text == "0")
            {
                return;
            }
            else
            {
                Resultados.Text += "0";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (Resultados.Text == "0" && Resultados.Text != null)
            {
                Resultados.Text = "1";
            }
            else
            {
                Resultados.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = operacion.Suma;
            value1 = Convert.ToDouble(Resultados.Text);
            Resultados.Text = "0";
           
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(value2 == 0)
            {
            value2 = Convert.ToDouble(Resultados.Text);
                double Resultado = RealizarOpe();
            value1 = 0;
            value2 = 0;
            Resultados.Text = Convert.ToString(Resultado);
            }
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = operacion.Resta;
            value1 = Convert.ToDouble(Resultados.Text);
            Resultados.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = operacion.Multiplicacion;
            value1 = Convert.ToDouble(Resultados.Text);
            Resultados.Text = "0";
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            operador = operacion.Divicion;
            value1 = Convert.ToDouble(Resultados.Text);
            Resultados.Text = "0";
        }

        private void btnBorrarT_Click(object sender, EventArgs e)
        {
            Resultados.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Resultados.Text.Length > 1)
            {
                string txtResultado = Resultados.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);
                Resultados.Text = txtResultado;
            }
            else
            {
                Resultados.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Resultados.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resultados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

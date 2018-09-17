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
    public partial class Form1 : Form
    {
        double PrimeiroNumero;
        string Operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        Termos termos = new Termos();
        Operacao Operacao = new Operacao();
        private void button1_Click(object sender, EventArgs e)
        {
            termos.Incluir(1, textBox1);
            /*if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            termos.Incluir(2, textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            termos.Incluir(3, textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            termos.Incluir(4, textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            termos.Incluir(5, textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            termos.Incluir(6, textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            termos.Incluir(7, textBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            termos.Incluir(8, textBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            termos.Incluir(9, textBox1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            termos.Incluir(0, textBox1);
        }

        private void bSoma_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            Operador = "+";
            textBox1.Text = "0";

        }

        private void bSub_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            Operador = "-";
            textBox1.Text = "0";
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            Operador = "*";
            textBox1.Text = "0";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            PrimeiroNumero = Convert.ToDouble(textBox1.Text);
            Operador = "/";
            textBox1.Text = "0";
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            if(Operador == "+")
            {
                textBox1.Text = Operacao.Somar(PrimeiroNumero, Convert.ToDouble(textBox1.Text));
            }
            if (Operador == "-")
            {
                textBox1.Text = Operacao.Subtrair(PrimeiroNumero, Convert.ToDouble(textBox1.Text));
            }
            if (Operador == "*")
            {
                textBox1.Text = Operacao.Multiplicar(PrimeiroNumero, Convert.ToDouble(textBox1.Text));
            }
            if (Operador == "/")
            {
                textBox1.Text = Operacao.Dividir(PrimeiroNumero, Convert.ToDouble(textBox1.Text));
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacao
    {
        public string Somar(double valor1, double valor2)
        {
            return Convert.ToString(valor1 + valor2);
        }

        public string Subtrair(double valor1, double valor2)
        {
            return Convert.ToString(valor1 - valor2);
        }

        public string Multiplicar(double valor1, double valor2)
        {
            return Convert.ToString(valor1 * valor2);
        }

        public string Dividir(double valor1, double valor2)
        {
            return Convert.ToString(valor1 / valor2);
        }
    }
}

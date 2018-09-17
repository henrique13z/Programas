using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Termos
    {
        public void Incluir(double primeiro, TextBox text)
        {
            if (text.Text == "0")
            {
                text.Text = Convert.ToString(primeiro);
            }
            else
            {
                text.Text = text.Text + Convert.ToString(primeiro);
            }
        }
    }
}

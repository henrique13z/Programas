using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto ContaGabriela do tipo ContaCorrente recebe uma nova instancia da classe ContaCorrente
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela Albuquerque";

            Console.WriteLine(contaGabriela.titular);

            Console.ReadLine();
        }
    }
}

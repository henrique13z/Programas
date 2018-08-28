using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(0413, 05762146);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            ContaCorrente contaDaGabriela = new ContaCorrente(0413, 05762146);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}

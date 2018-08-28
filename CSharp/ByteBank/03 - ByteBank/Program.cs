using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;

            Console.WriteLine(contaGabriela == contaGabrielaCosta);
            Console.WriteLine(contaGabriela.agencia == contaGabrielaCosta.agencia);


            int idade1 = 27;
            int idade2 = 27;

            Console.WriteLine(idade1 == idade2);
            Console.ReadLine();

        }
    }
}
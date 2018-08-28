using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine(contaBruno.saldo);

            bool resultadoDoSaque = contaBruno.Sacar(500);

            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultadoDoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo " + contaBruno.titular + ":" + contaBruno.saldo);
            Console.WriteLine("Saldo " + contaGabriela.titular + ":" + contaGabriela.saldo);

            contaBruno.Tranferir(300, contaGabriela);
            Console.WriteLine("Saldo " + contaBruno.titular + ":" + contaBruno.saldo);
            Console.WriteLine("Saldo " + contaGabriela.titular + ":" + contaGabriela.saldo);

            contaGabriela.Tranferir(100, contaBruno);
            Console.WriteLine("Saldo " + contaBruno.titular + ":" + contaBruno.saldo);
            Console.WriteLine("Saldo " + contaGabriela.titular + ":" + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}

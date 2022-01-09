using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {

           ContaCorrente c1 = new ContaCorrente(77,8250);
            Console.WriteLine(ContaCorrente.TotaldeContas);
            ContaCorrente c2 = new ContaCorrente(40, 300);
            Console.WriteLine(ContaCorrente.TotaldeContas);

            c1.Saldo = 100.0;
            c1.Titular = new Cliente();
            c1.Titular.Nome = "Rogério";

            Console.WriteLine("O saldo de " + c1.Titular.Nome + " é de: " + c1.Saldo);
            Console.ReadLine();
        }
    }
}

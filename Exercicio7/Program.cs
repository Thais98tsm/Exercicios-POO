using System;
using Exercicio7.Classes;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor("João", 36, 3500);
            Supervisor supervisor = new Supervisor("Carlos", 38, 5000);
            Gerente gerente = new Gerente("Anna", 32, 7000);

            Console.WriteLine(vendedor);
            Console.WriteLine(vendedor.bonificacao());
            Console.WriteLine(supervisor);
            Console.WriteLine(supervisor.bonificacao());
            Console.WriteLine(gerente);
            Console.WriteLine(gerente.bonificacao());
        }
    }
}

using System;
using Exercicio3.Classes;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago m1 = new Mago("Gandalf", 3200, 150, 10000, 60, 10, 3);
            Mago m2 = new Mago("Hermione", 2800, 150, 15000, 150, 30, 5);
            Guerreiro g1 = new Guerreiro("Thor", 2400, 100, 7000, 30, 150, 4);
            Guerreiro g2 = new Guerreiro("Steven", 2800, 70, 9000, 50, 170, 5);

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(g1);
            Console.WriteLine(g2);

            Console.WriteLine(g2.attack());            
        }
    }
}

using System;
using System.Collections.Generic;
using Exercicio4.Classes;

namespace Exercicio4
{
    class Program
    {
        public static List<Pessoa> listaPessoas =  new List<Pessoa>(){
           new Pessoa("João", 15), new Pessoa("Leandro", 21), new Pessoa("Paulo", 17), new Pessoa("Jessica", 18)
        };

        static int maisVelha = 0, qtdElementos = 0;

        static void Main(string[] args)
        {
            foreach(Pessoa p in listaPessoas){
                if(p.Idade > maisVelha)
                    maisVelha = p.Idade;
                qtdElementos++;
            }

            foreach(Pessoa p in listaPessoas){
                if(p.Idade == maisVelha)
                    Console.WriteLine(p.Nome);
            }

            Console.WriteLine(qtdElementos);

            qtdElementos = 0;
            for(int i = 0; i < listaPessoas.Count; i++){
                if(listaPessoas[i].Idade < 18)
                    listaPessoas.RemoveAt(i);
                qtdElementos++;
            }
            Console.WriteLine(qtdElementos);

            Console.WriteLine("", listaPessoas.Exists(p => p.Nome.Contains("Jessica")));


        }
    }
}

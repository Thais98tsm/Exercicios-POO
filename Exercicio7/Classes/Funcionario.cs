using System;

namespace Exercicio7.Classes
{
    public abstract class Funcionario
    {
        //Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }

        //Métodos
        public abstract string bonificacao();
    }
}
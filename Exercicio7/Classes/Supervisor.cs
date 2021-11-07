using System;

namespace Exercicio7.Classes
{
    public class Supervisor : Funcionario
    {
        //Métodos
        public Supervisor(string nome, int idade, float salario){
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;            
        }
        public override string bonificacao(){
            return "Salário + Bonificação: " + (Salario += 5000);
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmento.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Cargo: Supervisor" + Environment.NewLine;
            retorno += "Idade: " + this.Idade + Environment.NewLine;
            retorno += "Salário: " + this.Salario;
            return retorno;
        }
    }
}
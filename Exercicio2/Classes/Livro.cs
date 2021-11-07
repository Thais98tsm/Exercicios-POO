using System;

namespace Exercicio2 {
    public class Livro : Produto {
        private string Autor;
        private string Tema;
        private int QtdPag;

        public Livro(){}

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag){
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this. Autor = autor;
            this.Tema = tema;
            this.QtdPag = qtdPag;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmento.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Preço: " + this.Preco + Environment.NewLine;
            retorno += "Quantidade: " + this.Qtd + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Tema: " + this.Tema + Environment.NewLine;
            retorno += "Quantidade de páginas: " + this.QtdPag;
            return retorno;
        }
    }
}
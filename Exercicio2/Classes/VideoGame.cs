using System;

namespace Exercicio2 {
    public class VideoGame : Produto {
        private string Marca;
        private string Modelo;
        private bool IsUsado;

        public VideoGame(){}

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado){
            this.Nome = nome;
            this.Preco = preco;
            this.Qtd = qtd;
            this.Marca = marca;
            this.Modelo = modelo;
            this.IsUsado = isUsado;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmento.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Preço: " + this.Preco + Environment.NewLine;
            retorno += "Quantidade: " + this.Qtd + Environment.NewLine;
            retorno += "Marca " + this.Marca + Environment.NewLine;
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "É usado? " + this.IsUsado;
            return retorno;
        }
    }
}
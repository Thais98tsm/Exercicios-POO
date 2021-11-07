using System;
using System.Collections.Generic;

namespace Exercicio2 {
    public class Loja {
        private string Nome;
        private string Cnpj;
        List<Livro> livros;
        List<VideoGame> videoGames;

        public Loja(){}

        public Loja(string nome, string cnpj){
            this.Nome = nome;
            this.Cnpj = cnpj;
            livros = new List<Livro>();
            videoGames = new List<VideoGame>();
        }

        public void listaLivros(){
            if(livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros em seu estoque.");
                return;
            }

            foreach(var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }

        public void listaVideoGames(){
            if(videoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem videogames em seu estoque.");
                return;
            }

            foreach(var videogame in videoGames)
            {
                Console.WriteLine(videoGames);
            }
        }

        public double calculaPatrimonio(){
            return 0;
        }
    }
}
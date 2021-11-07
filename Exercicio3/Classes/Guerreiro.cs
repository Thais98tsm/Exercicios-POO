using System;
using System.Collections.Generic;

namespace Exercicio3.Classes
{
    public class Guerreiro : Personagem
    {
        private List<string> Habilidades;

         public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Habilidades = new List<string>();
        }

        public override void lvlUp()
        {
            Vida += 100;
            Forca += 75;
        }

        public void aprenderHabilidade(string habilidade){
            Habilidades.Add(habilidade);
        }

        public override int attack()
        {
            Random numAleatorio = new Random(); 
            int vrand = numAleatorio.Next(0,301);
            return Forca * Level + vrand;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmento.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Função: Guerreiro " + Environment.NewLine;
            retorno += "Vida: " + this.Vida + Environment.NewLine;
            retorno += "Mana: " + this.Mana + Environment.NewLine;
            retorno += "Xp: " + this.Xp + Environment.NewLine;
            retorno += "Inteligência: " + this.Inteligencia + Environment.NewLine;
            retorno += "Força: " + this.Forca + Environment.NewLine;
            retorno += "Level: " + this.Level;
            return retorno;
        }
    }
}
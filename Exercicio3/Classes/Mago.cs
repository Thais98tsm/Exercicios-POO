using System;
using System.Collections.Generic;
using Exercicio3.Classes;

namespace Exercicio3.Classes
{
    public class Mago : Personagem
    {
        private List<string> Magias;

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Magias = new List<string>();
        }

        public override void lvlUp()
        {
            Mana += 100;
            Inteligencia += 75;
        }

        public void aprenderMagia(string magia){
            Magias.Add(magia);
        }

        public override int attack()
        {
            Random numAleatorio = new Random();
            int vrand = numAleatorio.Next(0,301);
            return Inteligencia * Level + vrand;
        }

        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environmento.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Função: Mago " + Environment.NewLine;
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
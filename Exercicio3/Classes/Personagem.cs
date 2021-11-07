using System;

namespace Exercicio3.Classes
{
    public abstract class Personagem
    {
        //Atributos
        public string Nome;
        public int Vida;
        public int Mana;
        public float Xp;
        public int Inteligencia;
        public int Forca;
        public int Level;
        private static int totalPersonagens = 0;

        //Métodos
        public Personagem(){
            totalPersonagens++;
        }

        public abstract void lvlUp();

        public abstract int attack();
    }
}
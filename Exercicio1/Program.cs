using System;

namespace Exercicio1
{
    public class Veiculo
    {
        //Atributos
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string Placa { get; set; }
        private string Cor { get; set; }
        private float Km { get; set; }
        private bool IsLigado { get; set; }
        private int LitrosCombustivel { get; set; }
        private int Velocidade { get; set; }
        private double Preco { get; set; }

        //Métodos
        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preco){
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Km = km;
            this.IsLigado = isLigado;
            this.LitrosCombustivel = litrosCombustivel;
            this.Velocidade = velocidade;
            this.Preco = preco;
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Placa: " + this.Placa + Environment.NewLine;
            retorno += "Cor: " + this.Cor + Environment.NewLine;
            retorno += "Km: " + this.Km + Environment.NewLine;
            retorno += "IsLigado: " + this.IsLigado + Environment.NewLine;
            retorno += "LitrosCombustível: " + this.LitrosCombustivel + Environment.NewLine;
            retorno += "Velocidade: " + this.Velocidade + Environment.NewLine;
            retorno += "Preço: " + this.Preco;

            return retorno;
        }

        public void acelerar(){
            if(IsLigado)
                this.Velocidade += 20;
            else
                Console.WriteLine("É necessário ligar o carro primeiro");
        }

        public void abastecer(int combustivel){
            if(LitrosCombustivel == 60){
                Console.WriteLine("Tanque cheio");
            }
            else if((LitrosCombustivel + combustivel) >= 60)
                this.LitrosCombustivel = 60;
            else
            {
                this.LitrosCombustivel += combustivel;
            }
        }

        public void frear(){
            if(Velocidade <= 0){
                Console.WriteLine("Veículo parado");
            }
            else
            {
                this.Velocidade -= 20;
            }
        }

        public void pintar(String cor){
            this.Cor = cor;
        }

        public void ligar(){
            if(!IsLigado)
                IsLigado = true;
            else
                Console.WriteLine("Veículo ligado");
        }

        public void desligar(){
            if(IsLigado){
                if(Velocidade == 0)
                    IsLigado = false;
                else
                {
                    Console.WriteLine("Veículo em movimento");
                }
            }
        }

        public static void Main(String [] args){
            Veiculo v1 = new Veiculo("Fiat", "147", "QAC9730", "Vermelho", 10589, false, 45, 0, 2000.00);

            Console.WriteLine(v1);
            v1.ligar();
            v1.acelerar();
            v1.acelerar();
            v1.frear();
            v1.frear();
            v1.desligar();
            v1.abastecer(25);
            v1.pintar("Verde");            
            Console.WriteLine(v1);
        }

        
    }
}

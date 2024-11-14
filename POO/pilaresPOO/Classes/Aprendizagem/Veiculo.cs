

namespace pilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {

        public string? marca;
        public string? modelo;
        public string? cor;
        public string? potencia;
        public int qtdPassageiro;

        public void Ligar(){
            
            Console.WriteLine($"{modelo} Esta ligado");
            
        }

        public void Desligar(){
            Console.WriteLine($"{modelo} Esta Desligado");
        }

        public void Buzinar(){
            Console.WriteLine($"{modelo} Esta Buzinando");
        }

    }
}
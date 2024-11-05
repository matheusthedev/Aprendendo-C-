using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeClasse
{
    public class Carros
    {
        public string marca;
        public string modelo;
        public string  cor;
        public string potencia;
        public int qtdPortas;


        public void Acelerar()
        {
            Console.WriteLine($"vrum vrum");
            
        }

        public void Ligar()
        {
            Console.WriteLine($"{modelo} está ligado");

            
        }

        public void Desligar()
        {
            Console.WriteLine($"{modelo} desligado");

            
        }

        public void Freiar()
        {
            Console.WriteLine($"{modelo} está freando");

            
        }
    }
}
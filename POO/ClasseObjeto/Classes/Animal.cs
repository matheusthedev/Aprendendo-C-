using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes
{
    public class Animal
    {
        public string raca;
        public string cor;
        public string nome;
        public int idade;



        public void FazerBarulho(string barulho = "Barulho Genérico")
        {
            // Console.WriteLine($"Som de animal qualquer");
            Console.WriteLine($"Barulho do animal: {barulho}");
            
        }

        public void Envelhecer()
        {
            idade = idade + 1;
        }

    }

    
}
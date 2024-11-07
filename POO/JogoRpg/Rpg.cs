using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRpg
{
    public class Rpg
    {
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
            
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");
            
        }
        public void Defendeu()
        {
            Console.WriteLine($"O personagem defendeu!");
            
        }
    }
}
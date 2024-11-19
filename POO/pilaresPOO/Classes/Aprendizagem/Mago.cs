using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar(){
            Console.WriteLine($"O mago lança o seu feitiço!");
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class AlunoDois
    {
        public string? Nome;
        public int cpf;

        //Sobrecarga de métodos
        public AlunoDois() { }

        public AlunoDois(string chuchu){
            Nome = chuchu;
        }
        public AlunoDois(string chuchu, int abobrinha){
            Nome = chuchu;
            cpf = abobrinha;
        }
    }
}
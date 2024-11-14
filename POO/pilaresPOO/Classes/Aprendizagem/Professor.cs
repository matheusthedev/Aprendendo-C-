using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        public int nif;
        public float salario;

        public Professor(int _nif)
        {
            nif = _nif;
        }

    }
}
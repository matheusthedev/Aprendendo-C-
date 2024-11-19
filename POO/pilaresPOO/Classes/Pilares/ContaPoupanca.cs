using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Conta
    {
        public int limiteSaque;
        public float rendimento;

        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }

    
    }
}
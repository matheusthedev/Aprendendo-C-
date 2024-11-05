using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Classe
    {
        public float numero1;
        public float numero2;

        public void somar(float resultado)
        {
            resultado = numero1 + numero2;
        }

        public void subtrair(float resultado)
        {
            resultado =  numero1 - numero2;

        }

        public void multiplicar(float resultado)
        {
            resultado = numero1 * numero2;
        }

        public void dividir(float resultado)
        {
            resultado  = numero1 / numero2;

        }
    }
}
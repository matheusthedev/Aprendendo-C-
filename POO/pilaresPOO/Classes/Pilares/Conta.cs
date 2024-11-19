

namespace pilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        protected float Saldo;
        public string? titular;

        public abstract float Sacar(float valor);

        
        public abstract bool Depositar(float valor);

        public float GetSaldo(){
            return Saldo;
        }
    }
}


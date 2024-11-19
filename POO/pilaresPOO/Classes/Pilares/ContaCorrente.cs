
namespace pilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {

        public float limite;
        public bool Transferir()
        {
            return false;
        }

        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;

                return true;
            }
            else
            {
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;

                return valor;
            }
            else
            {
                Console.WriteLine($"Valor maior que o Saldo");
                return 0;
            }
        }


    }
}
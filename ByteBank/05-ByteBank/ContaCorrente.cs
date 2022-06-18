using _05_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        public double saldo;
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;

        }
    }
}


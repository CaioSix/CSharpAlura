using _06_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo;

      


        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                {

                }
                else
                {
                    this._saldo = value;
                }
            }
        }


        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            ContaDestino.Depositar(valor);
            return true;

        }
    }
}



namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }   

        public int _agencia;
        public int Agencia {
            get 
            { 
                return _agencia;
            }
            private set
                { 
                if(value < 0)
                {
                    return;
                }
                _agencia = value;
            }
            }
        public int Numero { get;  }

        private double _saldo = 100;

      


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

        public ContaCorrente(int agencia, int numero)
        {
            this.Agencia = agencia;
            this.Numero = numero;


            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if(agencia <= 0)
            {
                throw new ArgumentException("O Argumento agencia devem ser maiores que 0.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O Argumento numero devem ser maiores que 0.", nameof(numero));
            }
            
            ContaCorrente.TotalDeContasCriadas++;
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


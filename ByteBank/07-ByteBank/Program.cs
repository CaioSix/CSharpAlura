namespace _07_ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(1502, 15612);
                conta.Depositar(50);

                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Erro no parametro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentExeption");
                Console.WriteLine(ex.Message);
            }





            /*try
            {


                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }*/

            Console.ReadLine();

        }


        public static void Metodo()
        {
            TestaDivisao(0);
        }


        public static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisao de 10 por " + "é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com numero = " + numero + "e dividor = " + divisor);
                throw;
            }
        }
    }
}
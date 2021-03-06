using Execoes;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(0, 15612);
                conta.Depositar(50);

                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parametro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentExeption");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exeção do tipo SaldoInsuficienteException");
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

        private static void Teste()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                Console.WriteLine("deu certo");
            }
        }





        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = new LeitorDeArquivos("Contas.txt");
            try
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            catch (IOException e)
            {

                Console.WriteLine("Excecao do tipo IOException capturada e tratada!");
            }
            finally
            {
                //leitor.Fechar();
            }
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
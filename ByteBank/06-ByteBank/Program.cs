namespace _06_ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente clienteCaio = new Cliente();

            clienteCaio.Nome = "Caio";
            clienteCaio.Cpf = "1561";
            clienteCaio.Profissao = "Desenvolvedor";

            conta.Titular = clienteCaio;
            conta.Agencia = 1345;
            conta.Saldo = 50;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Saldo);


            Console.ReadLine();
        }
    }
}
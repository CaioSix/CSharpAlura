namespace _05_ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Dev backend";
            gabriela.cpf = "132456789";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;

            Console.WriteLine(conta.titular);

            Console.ReadLine();
        }
    }
}
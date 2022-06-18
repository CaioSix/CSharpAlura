namespace _07_ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente conta = new ContaCorrente(147, 1564798);
            Cliente Caio = new Cliente();

            conta.Titular = Caio;
            Caio.Nome = "Caio Henrique F C";
            Console.WriteLine("O dono da conta é " + conta.Titular.Nome);
            Console.WriteLine("a primeira conta é :"+ conta.Agencia);
            Console.WriteLine("a segunda conta é : "+ conta.Numero);

            ContaCorrente contaDoBino = new ContaCorrente(147, 14567813);
            ContaCorrente contaDoPedro = new ContaCorrente(231, 32132131);
            ContaCorrente contaDoBlalaino = new ContaCorrente(147, 14567813);
            ContaCorrente contaDoPedroDiLarinha = new ContaCorrente(231, 32132131);

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
namespace _01_Bytebank
{
    class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente ContaDoCaio = new ContaCorrente();

            ContaDoCaio.titular = "caio cavalcanti";
            ContaDoCaio.conta = 1515;
            ContaDoCaio.agencia = 132456;
            ContaDoCaio.saldo = 500.00;

            Console.WriteLine(ContaDoCaio.titular);
            Console.WriteLine("conta:" + ContaDoCaio.conta);
            Console.WriteLine("agencia:" + ContaDoCaio.agencia);
            Console.WriteLine("saldo:" + ContaDoCaio.saldo);

            Console.ReadLine();
        }
    }
}
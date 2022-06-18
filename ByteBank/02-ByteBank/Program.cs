namespace _02_ByteBank { 
    class Program
    {
        static void Main(String[] args)
        {
            ContaCorrente ContaDoCaio = new ContaCorrente();

            ContaDoCaio.titular = "Caio bunitao";

            Console.WriteLine(ContaDoCaio.titular);

        }
    }
}

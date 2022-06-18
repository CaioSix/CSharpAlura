using SegundoByteBank.Funcionarios;

namespace SegundoByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("484.564.231.472");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("456.132.432.613");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("465.987.123.475");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("123.456.789.123");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificacao do mes: " + gerenciadorBonificacao.GetBonificacao());

        }
    }
}
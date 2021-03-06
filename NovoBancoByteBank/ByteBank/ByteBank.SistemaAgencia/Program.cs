using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataFimPagamento = new DateTime(2022,8,17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca) ;

            Console.WriteLine(mensagem);

            Console.ReadLine();


        }

    
    }
}

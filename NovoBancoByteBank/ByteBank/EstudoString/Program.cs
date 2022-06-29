using EstudoString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudostring
{

    class Program
    {
        static void Main(string[] args)
        {

            string urlParametros = "https://bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentos extrator = new ExtratorValorDeArgumentos(urlParametros);

            string valor = extrator.GetValor("moedaDestino");
            Console.WriteLine("Valor de moeda destino é :" + valor);



            Console.ReadLine();


        }

        public static void TreinoComIdexoF()
        {
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);



            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));

        }



        public static void TestandoIsOrEmpy()
        {
            string url = "pagina?argumentos";

            //indexOf procura pela palavra - indiceDê
            int indiceInterrogacao = url.IndexOf('?');

            //Console.WriteLine(indiceInterrogacao);

            //Console.WriteLine(url);
            //    Substring pega a string a partir do indice que foi passado
            string argumentos = url.Substring(indiceInterrogacao + 1);
            //Console.WriteLine(argumentos);


            string textoVazio = "abcaasasas";
            string textoNull = null;

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNull));

        }


    }
}

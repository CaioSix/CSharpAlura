using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoString
{
    public class ExtratorValorDeArgumentos
    {
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentos(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url, não pode ser nulo ou vazio.", nameof(url));   
            }
            

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            return _argumentos.Substring(indiceTermo + termo.Length);
        }
        


    }
}

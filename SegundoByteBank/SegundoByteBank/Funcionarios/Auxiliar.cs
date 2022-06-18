using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf) { }

        public override void AumentarSalario()
        {
            base.Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.2;
        }
    }
}

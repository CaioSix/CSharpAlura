using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            base.Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.17;
        }
    }
}

using SegundoByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoByteBank.Funcionarios 
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }
        public override void AumentarSalario()
        {
            base.Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return base.Salario * 0.25;
        }
    }
}

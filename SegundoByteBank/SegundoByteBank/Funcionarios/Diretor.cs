﻿using SegundoByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoByteBank.Funcionarios
{
    //     Diretor pertentece a Funcionario
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando um Diretor");
        }



        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}

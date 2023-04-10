using BytebankAdm.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Funcionarios
{
    public class Gerente_de_Contas :FuncionarioAutenticavel
    {
    

        public Gerente_de_Contas(string cpf) : base(cpf, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

    }
}


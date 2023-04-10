using BytebankAdm.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
       

        public override double GetBonificacao()
        {
            return this.Salario * 0.5; 
        }


        public Diretor(string cpf):base(cpf,5000)
        {
              
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}

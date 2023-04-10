using BytebankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Utilitario
{
    public class GerencioadorDeBonificacao
    {
        public double TotalDeBonificacoe { get; private set; }
        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoe += funcionario.GetBonificacao();
        }
    }
}

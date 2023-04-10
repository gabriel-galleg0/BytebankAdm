using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; private set; }

           public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public abstract double GetBonificacao();
        

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um Funcionário");
        }


        public abstract void AumentarSalario();
        
    }
}

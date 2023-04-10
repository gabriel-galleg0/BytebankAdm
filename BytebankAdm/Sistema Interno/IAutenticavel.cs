using BytebankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Sistema_Interno
{
    public interface IAutenticavel 
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);
       
    }
    }


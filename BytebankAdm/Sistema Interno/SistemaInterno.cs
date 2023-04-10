using BytebankAdm.Funcionarios;
using BytebankAdm.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankAdm.Sistema_Interno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos");
                return false;
            }
        }
    }
    }

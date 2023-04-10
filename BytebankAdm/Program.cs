using BytebankAdm.Funcionarios;
using BytebankAdm.Parceria;
using BytebankAdm.Sistema_Interno;
using BytebankAdm.Utilitario;
using System;


Auxiliar gabriel = new Auxiliar("12345678910");
gabriel.Nome = "Gabriel Gallego";

gabriel.AumentarSalario();
Console.WriteLine(gabriel.Nome);
Console.WriteLine(gabriel.GetBonificacao());  

Diretor jeferson = new Diretor("12345678911");
jeferson.Nome = "Jeferson Jegues";


Console.WriteLine(jeferson.Nome);
Console.WriteLine(jeferson.GetBonificacao());

GerencioadorDeBonificacao gerenciador = new GerencioadorDeBonificacao();
gerenciador.Registrar(gabriel);
gerenciador.Registrar(jeferson);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacoe);
Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

jeferson.AumentarSalario();

Console.WriteLine("Novo salário de Gabriel: " + gabriel.Salario);
Console.WriteLine("Novo salário de Jeferson: " + jeferson.Salario);


CalcularBonificacao();

UsarSistema();
void CalcularBonificacao()
{
    GerencioadorDeBonificacao gerencioador = new GerencioadorDeBonificacao();

    Designer ulisses = new Designer("2345678");
    ulisses.Nome = "Ulisses Souza";


    Diretor paola = new Diretor("897246");
    paola.Nome = "Paola Voadora";

    Auxiliar igor = new Auxiliar("48523123");
    igor.Nome = "Igor Dias";


    Gerente_de_Contas camila = new Gerente_de_Contas("38347293842");
    camila.Nome = "Camila Oliveira";

    gerencioador.Registrar(ulisses);
    gerencioador.Registrar(camila);
    gerencioador.Registrar(paola);
    gerencioador.Registrar(igor);

    Console.WriteLine("Total de bonificação: " + gerencioador.TotalDeBonificacoe);
}


void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("123517");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    Gerente_de_Contas ursula = new Gerente_de_Contas("121378");
    ursula.Nome = "Ursula Bezerra";
    ursula.Senha = "456";   

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";


    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "111");
    sistema.Logar(caio, "999");
}
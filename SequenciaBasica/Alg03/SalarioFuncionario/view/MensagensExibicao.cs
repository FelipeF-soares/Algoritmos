using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalarioFuncionario.service;

namespace SalarioFuncionario.view
{
    public class MensagensExibicao
    {
        public string SolicitaNome(){
            return "Nome do Funcionário:";
        }

        public string SolicitaSalario(){
            return "Salário:";
        }

        public string ExibiNomeSalario(Pessoa pessoa){
            RetornaMes mes = new RetornaMes();
            return $"O funcionário {pessoa.Nome} tem um salário de {pessoa.Salario.ToString("C2")} em {mes.ToString()}.";
        }
    }
}
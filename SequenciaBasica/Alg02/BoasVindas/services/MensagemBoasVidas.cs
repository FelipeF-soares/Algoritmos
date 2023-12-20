using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoasVindas.services
{
    public class MensagemBoasVidas
    {
        public string Nome {get;set;}

        public string Perguntar(){
            return "Qual é o seu nome?";
        }

        public string Exibir(){
            return $"Olá {this.Nome}, é um prazer te conhecer!";
        }
    }
}
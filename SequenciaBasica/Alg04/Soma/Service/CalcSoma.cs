using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soma.Service
{
    public class CalcSoma
    {
        public int Numero1 {get;set;}
        public int Numero2 {get;set;}

        private int Soma(){
            return Numero1 + Numero2;
        }
        public override string ToString()
        {
            return $"A soma entre {Numero1} e {Numero2} é igual a {Soma()}.";
        }
    }
}
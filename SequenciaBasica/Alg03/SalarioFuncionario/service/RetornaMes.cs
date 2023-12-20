using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalarioFuncionario.service
{
    public class RetornaMes
    {
        private Dictionary<int,String> _mes;
        private DateTime _data;
        public RetornaMes()
        {
            _data = DateTime.Now;
            _mes = new Dictionary<int, string>();
            _mes.Add(1,"Janeiro");
            _mes.Add(2,"Fevereiro");
            _mes.Add(3,"Março");
            _mes.Add(4,"Abril");
            _mes.Add(5,"Maio");
            _mes.Add(6,"Junho");
            _mes.Add(7,"Julho");
            _mes.Add(8,"Agosto");
            _mes.Add(9,"Setembro");
            _mes.Add(10,"Outubro");
            _mes.Add(11,"Novembro");
            _mes.Add(12, "Dezembro");
        }

        public override string ToString()
        {
            return _mes[_data.Month];
        }
    }
}
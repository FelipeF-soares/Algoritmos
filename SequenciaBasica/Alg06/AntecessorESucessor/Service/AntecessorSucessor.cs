namespace AntecessorESucessor.Service
{
    public class AntecessorSucessor
    {
        public int Numero {get;set;}

        public override string ToString()
        {
            return $"O antecessor de {Numero} é {Numero-1} O sucessor de {Numero} é {Numero+1}";
        }
    }
}
namespace NumeroReal.views
{
    public class View
    {
        public string SolicitaUmNumero(){
            return "Digite um número:";
        }

        public string Resposta(double numero,double dobro, double terca){
            return $"O dobro de {numero} é {dobro.ToString("F1")} A terça parte de {numero} é {Math.Round(terca , 5, MidpointRounding.ToZero)}";
        }
    }
}
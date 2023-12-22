namespace MediaAluno.service
{
    public class CalculadoraDeMedia
    {
        public decimal Nota1 {get;set;}
        public decimal Nota2 {get;set;}

        public decimal Calcular(){
            return (Nota1 + Nota2)/2;
        }

        public override string ToString()
        {
            return $"A média entre {Nota1} e {Nota2} é igual a {Calcular().ToString("F1")}";
        }
    }
}
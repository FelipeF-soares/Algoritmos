namespace NumeroReal.service
{
    public class DobroDeUmNumero
    {
        private double _numero;
        public DobroDeUmNumero(double numero)
        {
            _numero = numero;
        }

        public double Resultado(){
            return _numero*2;
        }
    }
}
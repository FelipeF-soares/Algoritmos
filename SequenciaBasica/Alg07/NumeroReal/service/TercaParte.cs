namespace NumeroReal.service
{
    public class TercaParte
    {
        private double _numero;
        public TercaParte(double numero)
        {
            _numero = numero;
        }

        public double Resultado(){
            return _numero/3;
        }
    }
}
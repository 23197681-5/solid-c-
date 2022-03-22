namespace WebApplication1.ComOpenClosed
{
    public class Correios : IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * 2;
        }
    }
}

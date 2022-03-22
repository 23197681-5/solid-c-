namespace WebApplication1.ComOpenClosed
{
    public class Amazon : IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * .9;
        }
    }
}
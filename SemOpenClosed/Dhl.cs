namespace WebApplication1.SemOpenClosed
{
    public class Dhl : IFreteServico
    {
        public double Calcular(double peso)
        {
            return .8 * peso * 2;
        }
    }
}

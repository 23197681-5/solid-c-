namespace WebApplication1.ComOpenClosed
{
    public class Dhl:IFreteServico
    {
        public double Calcular(double peso)
        {
            return .8 * peso * 2;
        }
    }
}

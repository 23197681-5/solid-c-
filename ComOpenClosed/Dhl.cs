namespace WebApplication1.ComOpenClosed
{
    //Concret Strategy
    public class Dhl :IFreteServico
    {
        public double Calcular(double peso)
        {
            return .8 * peso * 2;
        }
    }
}

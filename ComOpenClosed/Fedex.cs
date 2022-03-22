namespace WebApplication1.ComOpenClosed
{
    public class Fedex :IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * 1.8 + 3;
        }
    }
}

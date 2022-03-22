namespace WebApplication1.ComOpenClosed
{
    //Concret Strategy
    public class Correios : IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * 2;
        }
    }
}

namespace WebApplication1.SemOpenClosed
{
    public class Correios : IFreteServico
    {
        
        public double Calcular(double peso)
        {
            return peso * 2;
        }
    }
}

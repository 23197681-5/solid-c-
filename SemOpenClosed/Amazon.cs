namespace WebApplication1.SemOpenClosed
{

    public class Amazon : IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * .9;
        }
        
    }
}

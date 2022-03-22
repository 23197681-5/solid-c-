namespace WebApplication1.ComOpenClosed
{
    //Concret Strategy
    public class MercadoLivre : IFreteServico
    {
        public double Calcular(double peso)
        {
            return (peso - 5) * 2;
        }
    }
}

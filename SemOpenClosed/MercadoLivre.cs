using System;

namespace WebApplication1.SemOpenClosed
{
    public class MercadoLivre
    {
        internal double CalculateDelivery(double peso)
        {
            return (peso - 5) * 2;
        }
    }
}

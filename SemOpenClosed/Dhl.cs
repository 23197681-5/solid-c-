using System;

namespace WebApplication1.SemOpenClosed
{
    public class Dhl
    {
        internal double PriceCalculator(double peso)
        {
            return .8 * peso * 2;
        }
    }
}

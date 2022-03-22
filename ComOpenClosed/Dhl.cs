using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

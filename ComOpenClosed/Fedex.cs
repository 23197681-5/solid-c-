using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

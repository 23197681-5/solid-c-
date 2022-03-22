using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ComOpenClosed
{
    public class MercadoLivre:IFreteServico
    {
        public double Calcular(double peso)
        {
            return (peso - 5) * 2;
        }
    }
}

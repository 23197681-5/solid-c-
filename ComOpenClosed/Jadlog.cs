﻿namespace WebApplication1.ComOpenClosed
{
    //Concret Strategy
    public class Jadlog : IFreteServico
    {
        public double Calcular(double peso)
        {
            return peso * 1.7;
        }
    }
}

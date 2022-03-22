namespace WebApplication1.SemOpenClosed
{
    public class Frete
    {
        public double Calcular(string servico, double peso)
        {
            double valorTotal = 0;
            if (servico == "sedex")
            {
                var entrega = new Correios();
                valorTotal = entrega.CalcularRemessa(peso);
            } else if (servico == "jadlog")
            {
                var entrega = new Jadlog();
                valorTotal = entrega.CalcularFreteJadLog(peso);
            }
            else if (servico == "dhl")
            {
                var entrega = new Dhl();
                valorTotal = entrega.PriceCalculator(peso);
            }
            else if (servico == "fedex")
            {
                var entrega = new Fedex();
                valorTotal = entrega.ShippingPrice(peso);
            }
            else if (servico == "mercadolivre")
            {
                var entrega = new MercadoLivre();
                valorTotal = entrega.CalculateDelivery(peso);
            }

            return valorTotal;
        }
    }
}
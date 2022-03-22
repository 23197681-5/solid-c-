namespace WebApplication1.SemOpenClosed
{
    public class Frete
    {
        public double Calcular(string servico, double peso)
        {
            double valorTotal = 0;

            if (servico == "sedex")
            {
                var correios = new Correios();
                valorTotal = correios.CalcularRemessa(peso);
            } 
            else if (servico == "jadlog")
            {
                var jadlog = new Jadlog();
                valorTotal = jadlog.CalcularFreteJadLog(peso);
            }
            else if (servico == "dhl")
            {
                var dhl = new Dhl();
                valorTotal = dhl.PriceCalculator(peso);
            }
            else if (servico == "fedex")
            {
                var fedex = new Fedex();
                valorTotal = fedex.ShippingPrice(peso);
            }
            else if (servico == "mercadolivre")
            {
                var mercadoLivre = new MercadoLivre();
                valorTotal = mercadoLivre.CalculateDelivery(peso);
            }
            else if (servico == "amazon")
            {
                var amazon = new Amazon();
                valorTotal = amazon.Calculate(peso);
            }

            return valorTotal;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ComOpenClosed;

using WebApplication1.SemOpenClosed;
using Amazon = WebApplication1.SemOpenClosed.Amazon;
using Frete = WebApplication1.ComOpenClosed.Frete;
using MercadoLivre = WebApplication1.ComOpenClosed.MercadoLivre;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public double SemOpenClosed()
        {
                
            var amazon = new Amazon();
            var frete = new SemOpenClosed.Frete(amazon);
            var valor = frete.Calcular( 2.5);

            return valor;
        }

        [HttpGet]
        public double FreteAmazon()
        {
            var amazon = new Amazon();
            var mercadoLivre = new MercadoLivre();
            var frete = new Frete(amazon);
            var valor = frete.Calcular(2.5);

            return valor;
        }
    }
}

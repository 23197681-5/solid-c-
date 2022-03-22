using Microsoft.AspNetCore.Mvc;
using WebApplication1.ComOpenClosed;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public double SemOpenClosed()
        {
            var frete = new SemOpenClosed.Frete();
            var valor = frete.Calcular("sedex", 2.5);

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

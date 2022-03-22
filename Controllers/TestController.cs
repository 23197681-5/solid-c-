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
            var valor = new SemOpenClosed.Frete().Calcular("sedex",2.5);

            return valor;
        }

        [HttpGet]
        public double ComOpenClosed()
        {
            var correios = new Correios();
            var valor = new ComOpenClosed.Frete(correios).Calcular(2.5);

            return valor;
        }
    }
}

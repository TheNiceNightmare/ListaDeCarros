using ListaDeCarros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListaDeCarros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {

        private static List<Carro> _carro = new List<Carro>
        {
            new Carro
            {
                Id = 1,
                Brand = "Audi",
                Model = "Lexus LS"

            },
            new Carro
            {
                Id = 2,
                Brand = "Lamborghini",
                Model = "Veneno Roadster"

            },
            new Carro
            {
                Id = 3,
                Brand = "Ford",
                Model = "Shelby 260 Cobra de 1962"

            },

             new Carro
            {
                Id = 4,
                Brand = "Mercedes-Benz",
                Model = "300 SLR Uhlenhaut Coupé"

            },
        };

        [HttpGet]

        public IEnumerable<Carro> GetAllCarro()
        {
            return _carro;
        }

    }
}
    

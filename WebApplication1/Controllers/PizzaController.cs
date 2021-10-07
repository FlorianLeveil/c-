using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebApplication1.Services;

namespace WebApplication1.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet ("pizza")]
        public IEnumerable<Pizza> Get(int ?id = null)
        {
            return PizzaService.GetOnePizzaOrAll(id);
        }
    }
}
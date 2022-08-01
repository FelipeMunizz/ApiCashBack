using ApiCashback.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCashback.Controllers
{
    [Produces("application/json")]
    [Route("api/CashBackPercentual")]
    public class CashbackPercentualController : ControllerBase
    {
        private ICashBackPercentualService _service;

        public CashbackPercentualController(ICashBackPercentualService cashBackPercentualService)
        {
            _service = cashBackPercentualService;
        }

        [HttpGet("{marca}")]
        public IActionResult Get(string marca)
        {
            var valor = _service.ObterCashback(marca);
            return Ok(valor);
        }
    }
}

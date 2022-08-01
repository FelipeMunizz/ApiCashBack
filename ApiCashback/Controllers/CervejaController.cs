using ApiCashback.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCashback.Controllers
{
    [Produces("application/json")]    
    public class CervejaController : ControllerBase
    {
        private readonly ICatalogoCervejaService _catalogoCervejaService;
        public CervejaController(ICatalogoCervejaService catalogo)
        {
            _catalogoCervejaService = catalogo;
        }

        [HttpGet]
        [Route("api/CatalogoCerveja/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var disco = _catalogoCervejaService.ObterCervejaPorId(id);
                if (disco != null)
                    return new ObjectResult(disco);
                else
                    return NotFound();
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }

        }

        [HttpGet]
        [Route("api/CatalogoCerveja/marca/{marca}")]
        public IActionResult Get(string marca, [FromQuery] int offset = 0, [FromQuery] int limit = 10)
        {
            try
            {
                return new JsonResult(_catalogoCervejaService.ListarTodosPorMarca(marca, offset, limit));
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }

        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploController : ControllerBase
    {
        [HttpGet("pruebas")]
        public IActionResult prueba()
        {
            return Ok("Respuesta de prueba");
        }
    }
}

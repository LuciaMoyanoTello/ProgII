using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Models;

namespace MiPrimerApi.Controllers //agregar => nuevo elemento => web => controlador de API: en blanco
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() //devuelve un resultado
        {
            return Ok(new Fecha()); //Ok hace referencia al código 200
        }
    }
}

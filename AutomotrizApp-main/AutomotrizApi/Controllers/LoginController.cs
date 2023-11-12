using AutomotrizApp.Datos.Implementacion;
using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILogin back;

        public LoginController()
        {
            back = new Login();
        }

        [HttpPost("GetLoged")]
        public IActionResult GetLoged(Cliente c)
        {
            if (c is not null)
            {
                try
                {
                    return Ok(back.Logeado(c));

                }
                catch (Exception)
                {
                    return BadRequest("Error del Servidor");
                }
            }
            else
            {
                return BadRequest("Debe ingresar nuevamente");
            }
        }
    }
}

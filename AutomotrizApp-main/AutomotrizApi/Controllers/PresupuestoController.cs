using AutomotrizApp.Entidades;
using AutomotrizApp.Fachada.Implementacion;
using AutomotrizApp.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private IAplicacion app;
        public PresupuestoController()
        {
            app = new Aplicacion();
        }
        [HttpGet("/productos")]
        public IActionResult GetProductos()
        {
            List<Producto> lst;
            try
            {
                lst = app.GetProductos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente luego!!");
            }
        }

        [HttpPost("/presupuesto")]
        public IActionResult PostPresupuesto(Presupuesto oPre)
        {
            try
            {
                if (oPre == null)
                {
                    return BadRequest("Presupuesto incorrecto!!");
                }
                return Ok(app.GuadarPresupuesto(oPre));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente luego!!");
            }
        }
    }
}

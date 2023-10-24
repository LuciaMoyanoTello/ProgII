using CarpinteriaBack.Entidades;
using CarpinteriaBack.Fachada.Implementacion;
using CarpinteriaBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarpinteriaApi.Controllers
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
                if(oPre == null)
                {
                    return BadRequest("Presupuesto incorrecto!!");
                }
                return Ok(app.SavePresupuesto(oPre));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente luego!!");
            }
        }
    }
}

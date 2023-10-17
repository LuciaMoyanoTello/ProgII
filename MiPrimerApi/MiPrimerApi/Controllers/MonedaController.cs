using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiPrimerApi.Controllers //controlador de API con acciones de lectura y escritura
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private static List<Moneda> lMonedas = new List<Moneda>();
        // GET: api/<MonedaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(lMonedas);
        }

        // GET api/<MonedaController>/5
        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            foreach (Moneda m in lMonedas)
            {
                if (m.Nombre.Equals(nombre))
                {
                    return Ok(m);
                }
            }
            return NotFound("Moneda no encontrada");
        }

        // POST api/<MonedaController>
        [HttpPost]
        public IActionResult Post([FromBody] Moneda moneda)
        {
            if (moneda == null || string.IsNullOrEmpty(moneda.Nombre))
            {
                return BadRequest("Moneda Incorrecta");
            }
            lMonedas.Add(moneda);
            return Ok(moneda);
        }

        //// PUT api/<MonedaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MonedaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

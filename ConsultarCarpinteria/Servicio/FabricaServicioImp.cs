using ConsultarCarpinteria.Servicio.Interfaz;
using ConsultarCarpinteria.Servicio.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCarpinteria.Servicio
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicio.Implementacion.Servicio();
        }
    }
}

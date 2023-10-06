using modeloParcial.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Servicio
{
    public abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}

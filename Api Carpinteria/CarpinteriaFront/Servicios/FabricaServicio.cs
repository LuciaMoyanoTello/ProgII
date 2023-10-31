using CarpinteriaFront.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios
{
    public abstract class FabricaServicio //factory
    {
        public abstract IServicio CrearServicio();
    }
}

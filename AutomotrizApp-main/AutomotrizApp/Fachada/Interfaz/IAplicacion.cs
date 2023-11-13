using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Producto> GetProductos();
        bool GuadarPresupuesto(Presupuesto presupuesto);
        bool Logeado(Cliente c);
    }
}

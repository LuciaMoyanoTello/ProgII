using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Producto> TraerProductos();
        bool TraerCrearPresupuesto(Presupuesto presupuesto);
    }
}

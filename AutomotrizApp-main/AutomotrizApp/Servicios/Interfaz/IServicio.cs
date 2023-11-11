using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Datos;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Producto> TraerProductos();
        bool TraerCrearPresupuesto(Presupuesto presupuesto);
    }
}

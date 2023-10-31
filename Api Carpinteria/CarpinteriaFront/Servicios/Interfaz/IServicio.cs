using CarpinteriaFront.Datos;
using CarpinteriaFront.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios.Interfaz
{
    public interface IServicio
    {
        int TraerProximoPresupuesto();
        List<Producto> TraerProductos();
        bool CrearPresupuesto(Presupuesto oPresupuesto);
        List<Presupuesto> TraerPresupuestosFiltrados(List<Parametro> lFiltros);
    }
}

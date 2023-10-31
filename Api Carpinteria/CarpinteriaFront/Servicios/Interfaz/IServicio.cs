using CarpinteriaBack.Datos;
using CarpinteriaBack.Entidades;
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

using ConsultarCarpinteria.Datos;
using ConsultarCarpinteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCarpinteria.Servicio.Interfaz
{
    public interface IServicio
    {
        Presupuesto ObtenerPresupuestoPorNro(int nro);
        List<Presupuesto> ObtenerPresupuestoPorFiltros(List<Parametro> lParam);
    }
}

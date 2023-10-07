using ConsultarCarpinteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCarpinteria.Datos.Interfaz
{
    public interface IPresupuestoDao
    {
        Presupuesto ObtenerPresupuestoPorNro(int nro);
        List<Presupuesto> ObtenerPresupuestoPorFiltro(List<Parametro> lParam);
    }
}

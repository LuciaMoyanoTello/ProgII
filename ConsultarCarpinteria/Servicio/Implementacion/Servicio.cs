using ConsultarCarpinteria.Datos;
using ConsultarCarpinteria.Datos.Implementacion;
using ConsultarCarpinteria.Datos.Interfaz;
using ConsultarCarpinteria.Entidades;
using ConsultarCarpinteria.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCarpinteria.Servicio.Implementacion
{
    public class Servicio : IServicio
    {
        IPresupuestoDao dao;
        public Servicio()
        {
            dao = new PresupuestoDao();
        }
        public List<Presupuesto> ObtenerPresupuestoPorFiltros(List<Parametro> lParam)
        {
            return dao.ObtenerPresupuestoPorFiltro(lParam);
        }

        public Presupuesto ObtenerPresupuestoPorNro(int nro)
        {
            return dao.ObtenerPresupuestoPorNro(nro);
        }
    }
}

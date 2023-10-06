using modeloParcial.Datos;
using modeloParcial.Datos.Interfaz;
using modeloParcial.Dominio;
using modeloParcial.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Servicio.Implementacion
{
    public class Servicio : IServicio
    {
        IOrdenDao dao;
        public Servicio()
        {
            dao = new OrdenDao();
        }
        public bool ObtenerCrear(OrdenRetiro OrdRet)
        {
            return dao.Crear(OrdRet);
        }

        public List<Material> ObtenerMaterial()
        {
            return dao.ObtenerMaterial();
        }

        public int ObtenerProximaOrden()
        {
            return dao.ObtenerProximaOrden();
        }
    }
}

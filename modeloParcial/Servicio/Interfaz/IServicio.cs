using modeloParcial.Datos;
using modeloParcial.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Servicio.Interfaz
{
    public interface IServicio
    {
        int ObtenerProximaOrden();
        List<Material> ObtenerMaterial();
        bool ObtenerCrear(OrdenRetiro OrdRet);
    }
}

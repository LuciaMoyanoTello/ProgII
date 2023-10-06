using modeloParcial.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Datos.Interfaz
{
    public interface IOrdenDao
    {
        int ObtenerProximaOrden();
        List<Material> ObtenerMaterial();
        bool Crear(OrdenRetiro OR);
    }
}

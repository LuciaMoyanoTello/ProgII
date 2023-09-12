using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConInterface
{
    interface IProducto //interface son públicas por defecto //solo tiene métodos
    {
        double CalcularPrecio();
    }
}

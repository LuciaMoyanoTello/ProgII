using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Datos.Interfaz
{
    public interface IPresupuestoDao
    {
        //Nuevo presupuesto
        List<Producto> ObtenerProductos();
        bool CrearPresupuesto(Presupuesto presupuesto);
    }
}

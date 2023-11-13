using AutomotrizApp.Datos.Implementacion;
using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using AutomotrizApp.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao dao;
        private ILogin login;
        public Aplicacion()
        {
            dao = new PresupuestoDao();
            login = new Login();
        }
        public List<Producto> GetProductos()
        {
            return dao.ObtenerProductos();
        }

        public bool GuadarPresupuesto(Presupuesto presupuesto)
        {
            return dao.CrearPresupuesto(presupuesto);
        }

        bool IAplicacion.Logeado(Cliente c)
        {
            return login.Logeado(c);
        }
    }
}

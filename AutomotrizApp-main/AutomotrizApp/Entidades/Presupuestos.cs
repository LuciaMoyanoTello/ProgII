using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Presupuestos
    {
        //Propiedades
        public int PresupuestoNro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<Detalles> Detalle { get; set; }

        //Constructor
        public Presupuestos()
        {
            Detalle = new List<Detalles>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    internal class Presupuesto
    {
        //Atributos
        int id;
        Cliente clientePresupuesto;
        DateTime fecha;
        float total;
        DateTime fechaBaja;
        List<Detalle> detalles;

        //Propiedades
        public int Id                       { get { return id; }                    set { id = value; } }
        public Cliente ClientePresupuesto   { get { return clientePresupuesto; }    set { clientePresupuesto = value; } }
        public DateTime Fecha               { get { return fecha; }                 set { fecha = value; } }
        public float Total                  { get { return total; }                 set { total = value; } }
        public DateTime FechaBaja           { get { return fechaBaja; }             set { fechaBaja = value; } }
        public List<Detalle> Detalles       { get { return detalles; }              set { detalles = value; } }



        //Constructor
        public Presupuesto(int Id = 0, Cliente ClientePresupuesto = null, DateTime Fecha = new DateTime(), float Total = 0, DateTime FechaBaja = new DateTime(), List<Detalle> Detalles = null)
        {
            this.Id = Id;
            this.ClientePresupuesto = ClientePresupuesto;
            this.Fecha = Fecha;
            this.Total = Total;
            this.FechaBaja = FechaBaja;
            this.Detalles = Detalles;
        }


        //Metodos

    }
}

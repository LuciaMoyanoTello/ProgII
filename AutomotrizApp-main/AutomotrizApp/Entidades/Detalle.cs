using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Detalle
    {
        //Atributos
        Producto productoDetalle;
        int cantidad;


        //Propiedades
        public Producto ProductoDetalle     { get { return productoDetalle; }   set { productoDetalle = value; } }
        public int Cantidad                 { get { return cantidad; }          set { cantidad = value; } }


        //Constructor
        public Detalle(Producto ProductoDetalle = null, int Cantidad = 0)
        {
            this.ProductoDetalle = ProductoDetalle;
            this.Cantidad = Cantidad;
        }


        //Metodos
        public float CalcularSubTotal()
        {
            float subTotal;

            subTotal = ProductoDetalle.Precio * Cantidad;

            return subTotal;
        }
    }
}

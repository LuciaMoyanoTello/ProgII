using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Detalles
    {
        //Propiedades
        public Productos Producto { get; set; }
        public int Cantidad { get; set; }

        //Constructor
        public Detalles(Productos producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }
}

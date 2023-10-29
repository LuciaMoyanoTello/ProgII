using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Productos
    {
        //Propiedades
        public int ProductoNro { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Tipo Tipo { get; set; }

        //Constructor
        public Productos(int prodNro, string nombre, double precio, Tipo tipo)
        {
            ProductoNro = prodNro;
            Nombre = nombre;
            Precio = precio;
            Tipo = tipo;
        }

        //ToString
        public override string ToString()
        {
            return Nombre;
        }
    }
}

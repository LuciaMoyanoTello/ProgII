using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConInterface
{
    public abstract class Producto : IProducto //por cada clase se utiliza la interface
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(int cod, string nom, double pre)
        {
            Codigo = cod;
            Nombre = nom;
            Precio = pre;
        }
        //es abstracto para que las hijas hagan el calcular precio
        public abstract double CalcularPrecio(); //Metodo abstracto necesito la clase abstracta
        public override string ToString()
        {
            return Codigo + " - " + Nombre+ " - $" + CalcularPrecio();
        }
    }
}

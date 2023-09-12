using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConInterface
{
    public class Suelto: Producto //hereda de producto
    {
        public int Medida { get; set; }
        public Suelto(int cod, string nom, double pre, int med)//lo que hereda de producto y agrego medida
            :base(cod,nom,pre)
        {
            Medida = med;
        }
        public override double CalcularPrecio()
        {
            return Medida * Precio;
        }
        public override string ToString()
        {
            return "Suelto: " + base.ToString(); //la base muestra un producto
        }
    }
}

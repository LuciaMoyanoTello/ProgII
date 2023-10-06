using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Dominio
{
    public class DetalleOrden
    {
        public int IdDetalle { get; set; }
        public Material MaterialDetalle { get; set; }
        public int Cantidad { get; set; }
        public DetalleOrden()
        {
            IdDetalle = 0;
            MaterialDetalle = new Material();
            Cantidad = 0;
        }
        public DetalleOrden(int id, Material matDet, int cant)
        {
            IdDetalle = id;
            MaterialDetalle = matDet;
            Cantidad = cant;
        }
        public override string ToString()
        {
            return IdDetalle + " " + MaterialDetalle;
        }
    }
}

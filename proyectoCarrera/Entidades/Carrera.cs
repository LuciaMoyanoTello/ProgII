using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarrera.Entidades
{
    internal class Carrera
    {
        public int CarreraNro { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }
        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
            CarreraNro = 0;
            Nombre = string.Empty;
            Titulo = string.Empty;
        }
        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
    }
}

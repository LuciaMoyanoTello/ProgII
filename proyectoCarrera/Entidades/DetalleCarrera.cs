using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarrera.Entidades
{
    internal class DetalleCarrera
    {
        public Asignatura Asignatura { get; set; }
        public int Anio { get; set; }
        public int Cuatrimestre { get; set; }
        public DetalleCarrera(Asignatura asignatura,int anio,int cuatrimestre)
        {
            Asignatura = asignatura;
            Anio = anio;
            Cuatrimestre = cuatrimestre;
        }
    }
}

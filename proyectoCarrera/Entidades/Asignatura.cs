using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCarrera.Entidades
{
    internal class Asignatura
    {
        public int AsignaturaNro { get; set; }
        public string Nombre { get; set; }
        public Asignatura()
        {
            AsignaturaNro = 0;
            Nombre = string.Empty;
        }
        public Asignatura(int asignaturaNro, string nombre)
        {
            AsignaturaNro = asignaturaNro;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

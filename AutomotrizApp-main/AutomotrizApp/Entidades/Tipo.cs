using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Tipo
    {
        //Propiedades
        public int TipoNro { get; set; }
        public string NombreTipo { get; set; }
        
        //Constructor
        public Tipo(int tipoNro, string nombreTipo)
        {
            TipoNro = tipoNro;
            NombreTipo = nombreTipo;
        }

        //ToString
        public override string ToString()
        {
            return NombreTipo;
        }
    }
}

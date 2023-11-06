using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos
{
    internal class Parametro
    {
        //Atributos
        string nombre;
        object valor;


        //Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public object Valor { get { return valor; } set { valor = value; } }


        //Constructor
        public Parametro(string Nombre = "", object Valor = null)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
        }


    }
}

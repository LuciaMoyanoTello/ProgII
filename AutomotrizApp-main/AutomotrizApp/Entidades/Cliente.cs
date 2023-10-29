using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Cliente
    {
        //Atributos
        string nombreCompleto;
        string dni;
        string telefono;


        //Propiedades
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public string Dni { get { return dni; } set { dni = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }


        //Constructor
        public Cliente(string NombreCompleto = "(Sin especificar)", string Dni = "(Sin especificar)", string Telefono = "(Sin especificar)")
        {
            this.NombreCompleto = NombreCompleto;
            this.Dni = Dni;
            this.Telefono = Telefono;
        }
    }
}

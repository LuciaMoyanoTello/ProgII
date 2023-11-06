using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    internal class Producto
    {
        //Atributos
        int id;
        string nombre;
        float precio;
        string tipo;


        //Propiedades
        public int Id           { get { return id; }        set { id = value; } }
        public string Nombre    { get { return nombre; }    set { nombre = value; } }
        public float Precio     { get { return precio; }    set { precio = value; } }
        public string Tipo      { get { return tipo; }      set { tipo = value; } }


        //Constructor
        public Producto(int Id = 0, string Nombre = "(Sin especificar)", float Precio = 0, string Tipo = "(Sin especificar)")
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Tipo = Tipo;
        }


        //Metodos

    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Entidades
{
    public class Cliente
    {
        //Atributos
        int id;
        string nombreCompleto;
        string dni;
        string telefono;
        string usuario;
        string pass;


        //Propiedades
        public int Id                   { get { return id; }                set { id = value; } }
        public string NombreCompleto    { get { return nombreCompleto; }    set { nombreCompleto = value; } }
        public string Dni               { get { return dni; }               set { dni = value; } }
        public string Telefono          { get { return telefono; }          set { telefono = value; } }
        public string Usuario { get; set; }
        public string Pass { get; set; }


        //Constructor
        public Cliente(int Id, string NombreCompleto, string Dni, string Telefono, string usuario, string pass)
        {
            this.Id = Id;
            this.NombreCompleto = NombreCompleto;
            this.Dni = Dni;
            this.Telefono = Telefono;
            this.Usuario = usuario;
            this.Pass = pass;
        }


        //Metodos

    }
}

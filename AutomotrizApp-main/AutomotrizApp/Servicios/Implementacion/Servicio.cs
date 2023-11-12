﻿using AutomotrizApp.Entidades;
using AutomotrizApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IPresupuestoDao dao;
        public Servicio()
        {
            dao = new PresupuestoDao();
        }

        public bool TraerCrearPresupuesto(Presupuesto presupuesto)
        {
            return dao.CrearPresupuesto(presupuesto);
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProductos();
        }
    }
}
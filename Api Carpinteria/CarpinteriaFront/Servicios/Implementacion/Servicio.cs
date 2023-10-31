﻿using CarpinteriaFront.Datos;
using CarpinteriaFront.Datos.Implementacion;
using CarpinteriaFront.Datos.Interfaz;
using CarpinteriaFront.Entidades;
using CarpinteriaFront.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IPresupuestoDao dao;
        public Servicio()
        {
            dao = new PresupuestoDao();
        }
        public bool CrearPresupuesto(Presupuesto oPresupuesto)
        {
           return dao.Crear(oPresupuesto);
        }

        public List<Producto> TraerProductos()
        {
            return dao.ObtenerProductos();
        }

        public int TraerProximoPresupuesto()
        {
            return dao.ObtenerProximoPresupuesto(); 
        }

        public List<Presupuesto> TraerPresupuestosFiltrados(List<Parametro> lFiltros)
        {
            return dao.ObtenerPresupuestosPorFiltros(lFiltros);
        }
    }
}

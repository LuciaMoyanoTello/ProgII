﻿using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Servicios
{
    public abstract class FabricaServicio //factory
    {
        public abstract IServicio CrearServicio();
    }
}

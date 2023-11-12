using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Interfaz
{
    public interface ILogIn
    {
        bool Logeado(Cliente c);
    }
}

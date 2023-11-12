using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class LoginDao : ILogin
    {
        private ILogin login;

        public LoginDao() 
        {
            login = new Login();
        }

        public bool Logeado(Cliente c)
        {
            return login.Logeado(c);
        }
    }
}

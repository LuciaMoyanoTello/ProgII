using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class Login : ILogin
    {
        public bool Logeado(Cliente c)
        {
            DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@usuario", c.Usuario);
            DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@pass", c.Pass);
            DBHelper.ObtenerInstancia().LeerDB("[SP_CONSULTAR_LOGIN]");

            if (DBHelper.ObtenerInstancia().Reader.Read())
            {
                DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
                DBHelper.ObtenerInstancia().CerrarConexion();
                return true;
            }
            DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            DBHelper.ObtenerInstancia().CerrarConexion();
            return false;
        }
    }
}

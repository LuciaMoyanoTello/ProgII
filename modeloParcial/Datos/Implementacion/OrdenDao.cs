using modeloParcial.Datos.Interfaz;
using modeloParcial.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace modeloParcial.Datos
{
    public class OrdenDao : IOrdenDao
    {
        public bool Crear(OrdenRetiro OR)
        {
            bool resultado = true;
            SqlTransaction t = null;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            try
            {
                //MAESTRO
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_ORDEN", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                //Output
                SqlParameter param = new SqlParameter("@nro", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                //input
                cmd.Parameters.AddWithValue("@responsable", OR.Responsable);
                cmd.ExecuteNonQuery();

                //DETALLE
                int nroOrden = (int)param.Value;
                int i = 0;
                foreach (DetalleOrden d in OR.ListaDetalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nroOrden);
                    cmdDetalle.Parameters.AddWithValue("@detalle", i);
                    cmdDetalle.Parameters.AddWithValue("@codigo", d.MaterialDetalle.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", d.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    i++;
                }
                t.Commit();
            }
            catch
            {
                if(t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                if(cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return resultado;
        }

        public List<Material> ObtenerMaterial()
        {
            List<Material> lMaterial = new List<Material>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");
            foreach(DataRow fila in tabla.Rows)
            {
                int cod = int.Parse(fila["codigo"].ToString());
                string nom = fila["nombre"].ToString();
                double stock = double.Parse(fila["stock"].ToString());
                lMaterial.Add(new Material(cod, nom, stock));
            }
            return lMaterial;
        }

        public int ObtenerProximaOrden()
        {
            return HelperDao.ObtenerInstancia().ObtenerNro("SP_PROXIMA_ORDEN","@next");
        }
    }
}

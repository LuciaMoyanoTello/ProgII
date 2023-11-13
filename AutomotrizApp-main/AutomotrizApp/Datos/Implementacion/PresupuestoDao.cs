using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class PresupuestoDao : IPresupuestoDao
    {
        public bool CrearPresupuesto(Presupuesto presupuesto)
        {
            bool resultado = true;
            SqlConnection conexion = DBHelper.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                //Iniciar la conexion
                conexion.Open();
                t = conexion.BeginTransaction();

                //Inicializar y asignar el tipo de comando a la conexion
                SqlCommand cmdPresupuesto = new SqlCommand("[SP_INSERTAR_PRESUPUESTOS]", conexion, t);
                cmdPresupuesto.CommandType = CommandType.StoredProcedure;


                //Carga de parametros de entrada
                cmdPresupuesto.Parameters.AddWithValue("@input_id_cliente", presupuesto.ClientePresupuesto.Id);
                cmdPresupuesto.Parameters.AddWithValue("@input_total", presupuesto.CalcularTotal());

                //Toma de parametros de salida
                SqlParameter output = new SqlParameter();
                output.ParameterName = "@output_id_presupuesto";
                output.SqlDbType = SqlDbType.Int;
                output.Direction = ParameterDirection.Output;
                cmdPresupuesto.Parameters.Add(output);


                //Ejecuta alta del Presupuesto
                cmdPresupuesto.ExecuteNonQuery();


                presupuesto.Id = Convert.ToInt32(output.Value);
                SqlCommand cmdDetalle;

                for (int i = 0; i < presupuesto.Detalles.Count; i++)
                {
                    //Inicializar y asignar el tipo de comando a la conexion
                    cmdDetalle = new SqlCommand("[SP_INSERTAR_DETALLES]", conexion, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    //Carga de parametros de entrada
                    cmdDetalle.Parameters.AddWithValue("@input_id_presupuesto", presupuesto.Id);
                    cmdDetalle.Parameters.AddWithValue("@input_id_detalle", i + 1);
                    cmdDetalle.Parameters.AddWithValue("@input_id_producto", presupuesto.Detalles[i].ProductoDetalle.Id);
                    cmdDetalle.Parameters.AddWithValue("@input_cantidad", presupuesto.Detalles[i].Cantidad);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch
            {

                if (t != null)
                {
                    t.Rollback();
                }
                resultado = false;
            }
            finally
            {
                //Cierra la conexion independientemente si la transaccion se realizo o no con exito
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return resultado;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> lProductos = new List<Producto>();
            DataTable tProductos = DBHelper.ObtenerInstancia().ConsultarSP("[SP_CONSULTAR_PRODUCTOS]");

            foreach (DataRow row in tProductos.Rows)
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = Convert.ToString(row["Nombre"]),
                    Precio = Convert.ToSingle(row["Precio"]),
                    Tipo = Convert.ToString(row["Tipo"])
                };

                lProductos.Add(producto);
            }
            return lProductos;
        }
    }
}

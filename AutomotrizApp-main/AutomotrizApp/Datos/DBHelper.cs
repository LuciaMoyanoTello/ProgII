using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using AutomotrizApp.Entidades;

namespace AutomotrizApp.Datos
{
    internal class DBHelper
    {
        //Atributos
        // ================================================================================================================================= //
        private SqlConnection conexion;
        private static DBHelper instancia;
        // ================================================================================================================================= //

        //Cerrar conexion
        public void CerrarConexion()
        {
            conexion.Close();
        }

        //Obtener conexion
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        //Comando y reader
        SqlCommand cmd = new SqlCommand();
        public SqlCommand Comando
        {
            get { return cmd; }
            set { cmd = value; }
        }

        SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }
        //Constructor e instancia
        // ================================================================================================================================= //
        private DBHelper(SqlConnection Conexion = null)
        {
            if (Conexion == null)
            {
                conexion = new SqlConnection(@"Data Source=DESKTOP-GE4ANJO\SQLEXPRESS;Initial Catalog=AutomotrizApp;Integrated Security=True");
            }
            else
            {
                conexion = Conexion;
            }
        }


        //Genera una instancia del helper para facilitar su acceso y mantener consistencia con el manejo de datos
        public static DBHelper ObtenerInstancia(SqlConnection Conexion = null)
        {
            if (instancia == null)
                instancia = new DBHelper(Conexion);
            return instancia;
        }
        // ================================================================================================================================= //



        //Metodos
        // ================================================================================================================================= //
        //Consuta con o sin parametros a la base de datos por medio de procedimientos almacenados
        public DataTable ConsultarSP(string NombreSP = "", List<Parametro> Parametros = null)
        {
            //Iniciar a conexion
            conexion.Open();

            //Inicializar y asignar el tipo de comando a la conexion
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            //Recorrer y agregar tantos parametros como elementos de la lista al comando que ejecuta el SP
            comando.Parameters.Clear();
            if (Parametros != null)
            {
                foreach (Parametro parametro in Parametros)
                {
                    comando.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                }
            }

            //Inicializar la tabla de retorno y cargar en ella los resultados de la consuta con el SP
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            //Cerrar la conexion
            conexion.Close();

            //Devolver la tabla como resutado de la consulta
            return tabla;
        }


        //Metodo para cargar los datos de un combo, recibe el combo y el nombre del SP donde toma los datos
        public void CargarCombo(ComboBox Combo, string NombreSP)
        {
            //Cargar los datos de la consulta en una tabla
            DataTable tabla = ConsultarSP(NombreSP);

            //Asignar valores de la tabla al combo
            Combo.DataSource = tabla;
            Combo.ValueMember = tabla.Columns[0].ColumnName;
            Combo.DisplayMember = tabla.Columns[1].ColumnName;

            //Formateo del combo
            Combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo.SelectedIndex = -1;
        }


        //Metodo para cargar los datos de un dgv y colocarlos en sus columnas segun los headers del dgv, recibe la grilla, la lista de parametros y el nombre del SP
        public void CargarGrilla(DataGridView grilla, List<Parametro> lista, string NombreSP)
        {
            DataTable tabla = ConsultarSP(NombreSP, lista);                     // Consulta el SP desde otro metodo

            foreach (DataRow fila in tabla.Rows)                                // Recorre todas las filas de la tabla resultado
            {
                List<string> valores = new List<string>();                      // Creamos una lista que se agregara al DGV a modo de "Rows" (filas)

                foreach (DataGridViewColumn columna in grilla.Columns)          // Recorre todas las columnas del DGV (no de la tabla)
                {
                    if (columna.HeaderText == "Accion")                         // Si la columna es de "Accion" pone como texto en la lista el VALOR de la columna (no el header.text)
                    {
                        valores.Add(columna.Name);
                    }
                    else                                                        // Agrega a la lista el valor correspondiente de la tabla con el header del dgv
                    {
                        string valor = fila[columna.HeaderText].ToString();
                        valores.Add(valor);
                    }

                }

                grilla.Rows.Add(valores.ToArray());                             // Agrega la lista resultante (ordenada) como una "Row" al dgv
            }

        }


        //Transaccion
        public bool Transaccion(Presupuesto presupuesto)
        {
            bool resultado = true;
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
                    cmdDetalle.Parameters.AddWithValue("@input_id_detalle", i+1);
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

        //Leer sp de la base de datos
        public SqlDataReader LeerDB(string procedure)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procedure;
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            return reader;
        }
        // ================================================================================================================================= //


    }
}
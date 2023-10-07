using ConsultarCarpinteria.Datos.Interfaz;
using ConsultarCarpinteria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarCarpinteria.Datos.Implementacion
{
    public class PresupuestoDao : IPresupuestoDao
    {
        public List<Presupuesto> ObtenerPresupuestoPorFiltro(List<Parametro> lParam)
        {
            List<Presupuesto> lPre = new List<Presupuesto>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_PRESUPUESTOS", lParam);

            foreach (DataRow fila in tabla.Rows)
            {
                Presupuesto p = new Presupuesto();
                p.PresupuestoNro = int.Parse(fila["presupuesto_nro"].ToString());
                p.Fecha = DateTime.Parse(fila["fecha"].ToString());
                p.Cliente = fila["cliente"].ToString();
                p.Descuento = double.Parse(fila["descuento"].ToString());
                lPre.Add(p);
            }
            return lPre;
        }

        public Presupuesto ObtenerPresupuestoPorNro(int nro)
        {
            Presupuesto oPre = null;
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@presupuesto_nro", nro));

            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_CONSULTAR_DETALLES_PRESUPUESTO", lParam);
            if(tabla.Rows.Count > 0)
            {
                bool primero = true;

                oPre = new Presupuesto();

                foreach(DataRow fila in tabla.Rows)
                {
                    if (primero)
                    {
                        oPre.PresupuestoNro = int.Parse(fila["presupuesto_nro"].ToString());
                        oPre.Fecha = DateTime.Parse(fila["fecha"].ToString());
                        oPre.Cliente = fila["cliente"].ToString();
                        oPre.Descuento = double.Parse(fila["descuento"].ToString());
                        primero = false;
                    }
                    //PRODUCTO
                    int numero = int.Parse(fila["id_producto"].ToString());
                    string nom = fila["n_producto"].ToString();
                    double pre = double.Parse(fila["precio"].ToString());
                    Producto p = new Producto(numero,nom,pre);
                    //DETALLE
                    int cant = int.Parse(fila["cantidad"].ToString());
                    DetallePresupuesto d = new DetallePresupuesto(p,cant);

                    oPre.AgregarDetalle(d);
                }
            }
            return oPre;
        }
    }
}

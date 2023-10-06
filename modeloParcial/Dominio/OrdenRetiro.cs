using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloParcial.Dominio
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> ListaDetalles { get; set; }
        public OrdenRetiro()
        {
            NroOrden = 0;
            Fecha = DateTime.Now;
            Responsable = string.Empty;
            ListaDetalles = new List<DetalleOrden>();
        }
        public OrdenRetiro(int nro, DateTime fec, string resp)
        {
            NroOrden = nro;
            Fecha = fec;
            Responsable = resp;
            this.ListaDetalles = new List<DetalleOrden>();
        }
        public void AgregarDetalle(DetalleOrden detalle)
        {
            ListaDetalles.Add(detalle);
        }
        public void QuitarDetalle(int nroDet)
        {
            ListaDetalles.RemoveAt(nroDet);
        }
    }
}

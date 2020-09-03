using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas.Models
{
    public class Factura
    {
        public int ID { get; set; }
        public string DetalleFactura { get; set; }
        public DateTime Fecha { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadItem { get; set; }
        public string DetalleItem { get; set; }
        public Cliente Cliente { get; set; }
    }
}
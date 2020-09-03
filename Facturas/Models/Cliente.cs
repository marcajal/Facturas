using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public DateTime NombreCompleto { get; set; }
        public ICollection<Factura> Students { get; set; }
    }
}
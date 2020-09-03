using Facturas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Facturas.DAL
{
    public class FacturaContext : DbContext
    {
        public FacturaContext() : base("FacturaDB")
        {

        }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
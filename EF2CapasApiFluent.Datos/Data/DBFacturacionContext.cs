using EF2CapasApiFluent.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Data
{
    public class DBFacturacionContext : DbContext
    {
        public DBFacturacionContext () : base("KeyFacturacionV2") {}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteEntityConfiguration());
            modelBuilder.Configurations.Add(new FacturaEntityConfiguration());
            modelBuilder.Configurations.Add(new DetalleEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

    }
}

using EF2CapasApiFluent.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Data
{
    public class FacturaEntityConfiguration : EntityTypeConfiguration<Factura>
    {
        public FacturaEntityConfiguration ()
        {
            this.ToTable("Factura");

            this.HasKey(f => f.IdFactura);

            this.HasRequired(f => f.Cliente)
                .WithMany()
                .HasForeignKey(f => f.IdCliente);

            this.Property(c => c.Fecha)
                .IsRequired()
                .HasColumnType("date");

            this.Property(c => c.IVA)
                .IsRequired()
                .HasColumnType("decimal");

        }
    }
}

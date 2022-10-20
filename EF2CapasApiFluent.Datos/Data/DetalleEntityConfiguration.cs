using EF2CapasApiFluent.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Data
{
    public class DetalleEntityConfiguration : EntityTypeConfiguration<Detalle>
    {
        public DetalleEntityConfiguration()
        {
            this.ToTable("Detalle");

            this.HasKey<int>(c => c.IdDetalle);

            this.HasRequired(c => c.Factura)
                .WithMany()
                .HasForeignKey(c => c.IdFactura);

            this.Property(c => c.Precio)
                .IsRequired()
                .HasColumnType("money");

            this.Property(c => c.Cantidad)
                .IsRequired();

            this.Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(200);

        }
    }
}

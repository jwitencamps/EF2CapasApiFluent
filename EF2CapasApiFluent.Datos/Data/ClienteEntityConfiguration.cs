using EF2CapasApiFluent.Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Data
{
    public class ClienteEntityConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteEntityConfiguration()
        {
            this.ToTable("Cliente");

            this.HasKey<int>(c => c.IdCliente);

            this.Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(c => c.Apellido)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(c => c.DNI)
                .HasColumnType("varchar");

        }
    }
}

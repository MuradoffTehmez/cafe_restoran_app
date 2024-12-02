using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeRestoranApp.Entities.Interfaces;
using CafeRestoranApp.Entities.Models;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdSoyad).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Telefon).HasColumnType("varchar").HasMaxLength(25);
            this.Property(p => p.Adres).HasColumnType("varchar").HasMaxLength(200);
            this.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(500);

        }
    }
}

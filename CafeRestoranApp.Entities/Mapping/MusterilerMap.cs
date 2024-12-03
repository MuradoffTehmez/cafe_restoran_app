using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdSoyad).HasColumnType("nvarchar").HasMaxLength(150);
            this.Property(p => p.Telefon).HasColumnType("nvarchar").HasMaxLength(25);
            this.Property(p => p.Adres).HasColumnType("nvarchar").HasMaxLength(200);
            this.Property(p => p.Email).HasColumnType("nvarchar").HasMaxLength(150);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(500);

        }
    }
}

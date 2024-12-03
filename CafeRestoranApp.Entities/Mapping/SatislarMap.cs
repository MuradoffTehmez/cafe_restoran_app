using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class SatislarMap : EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("nvarchar").HasMaxLength(30);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(300);
            this.HasOptional(s => s.Musteriler).WithMany(s => s.Satislar).HasForeignKey(s => s.MusteriId);
        }
    }
}

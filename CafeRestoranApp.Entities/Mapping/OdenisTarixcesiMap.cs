using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class OdenisTarixcesiMap : EntityTypeConfiguration<OdenisTarixcesi>
    {
        public OdenisTarixcesiMap()
        {
            this.ToTable("OdenisTarixcesi");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.OdemeTuru).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("nvarchar").HasMaxLength(300);
        }
    }
}

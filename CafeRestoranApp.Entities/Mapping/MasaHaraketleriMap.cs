using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MasaHaraketleriMap : EntityTypeConfiguration<MasaHaraketleri>
    {
        public MasaHaraketleriMap()
        {
            this.ToTable("MasaHaraketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.HasRequired(x => x.Masalar).WithMany(x => x.MasaHaraketleri).HasForeignKey(x => x.MasaId);
            this.HasRequired(U => U.Urun).WithMany(U => U.MasaHaraketleri).HasForeignKey(U => U.UrunId);
        }
    }
}

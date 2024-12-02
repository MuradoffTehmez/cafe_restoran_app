using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MasalarMap : EntityTypeConfiguration<Masalar>
    {
        public MasalarMap()
        {
            this.ToTable("Masalar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MasaAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(30);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
            this.Property(p => p.ElaveOlmaTarixi).HasColumnType("Date");
            this.HasOptional(m => m.İsIstifadeciler).WithMany(m => m.Masalar).HasForeignKey(m => m.KullaniciId);

        }
    }
}

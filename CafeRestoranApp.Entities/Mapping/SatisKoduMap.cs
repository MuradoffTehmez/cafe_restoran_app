using CafeRestoranApp.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class SatisKoduMap : EntityTypeConfiguration<SatisKodu>
    {
        public SatisKoduMap()
        {
            this.ToTable("SatisKodu");
            //this.HasKey(s => s.Id);
            //this.Property(s => s.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            //this.Property(s => s.SatisTanimi).HasColumnType("nvarchar").HasMaxLength(20).IsOptional();
            //this.Property(s => s.Sayi).IsRequired();
        }
    }
}
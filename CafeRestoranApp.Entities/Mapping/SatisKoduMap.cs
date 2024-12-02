using CafeRestoranApp.Entities.Models;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class SatisKoduMap : EntityTypeConfiguration<SatisKodu>
    {
        public SatisKoduMap()
        {
            // Table Name
            ToTable("SatisKodu");

            // Primary Key
            HasKey(s => s.Id);

            // Properties
            //Property(s => s.Id)
            //    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
            //    .IsRequired();

            Property(s => s.SatisTanimi)
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsOptional();

            Property(s => s.Sayi)
                .IsRequired();
        }
    }
}
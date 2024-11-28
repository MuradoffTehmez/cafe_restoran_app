using CafeRestoranApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Mapping
{
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
           
            this.HasKey(p => p.Id);
            
            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            this.Property(p => p.UrunKodu)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            
            this.Property(p => p.UrunAdi)
                .HasColumnType("varchar")
                .HasMaxLength(60);
            
            this.Property(p => p.Aciklama)
                .HasColumnType("varchar")
                .HasMaxLength(300);
            
            this.Property(p => p.Qiymet1)
                .HasPrecision(28, 2);
            
            this.Property(p => p.Qiymet2)
                .HasPrecision(28, 2);


            this.HasRequired(x => x.Menu)
                .WithMany(x => x.Urun)
                .HasForeignKey(x => x.MeynuID);

        }
    }
}

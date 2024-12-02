using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class IstifadecilerMap : EntityTypeConfiguration<Istifadeciler>
    {
        public IstifadecilerMap()
        {
            this.ToTable("Istifadeciler");

            this.HasKey(p => p.Id);

            this.Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.AdSoyad)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(p => p.Telefon)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(p => p.Adress)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            this.Property(p => p.Email)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            this.Property(p => p.Vezifesi)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(p => p.IstifadeciAdi)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(p => p.Parol)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            this.Property(p => p.HatirlamaSuali)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            this.Property(p => p.Cavab)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            this.Property(p => p.Aciklama)
                .HasColumnType("varchar")
                .HasMaxLength(300);

            this.Property(p => p.FailedLoginAttempts)
                .HasColumnType("int");
        }
    }
}

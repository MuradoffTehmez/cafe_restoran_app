using CafeRestoranApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            this.ToTable("Meynu");
            this.HasKey(p => p.Id); // Kodun qalan hissəsi Allahda  bilmir necə yazılıb
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MenuAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(500);


            this.Property(p => p.Aciklama).HasColumnName("Melumat");   // Adini deyismek ucun

        }
    }
}

using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class ModlarMap : EntityTypeConfiguration<Modlar>
    {
        public ModlarMap()
        {
            this.ToTable("Modlar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.ControlCaption).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.ControlName).HasColumnType("nvarchar").HasMaxLength(50);
            this.Property(p => p.FormName).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}

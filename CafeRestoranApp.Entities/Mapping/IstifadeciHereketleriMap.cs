﻿using CafeRestoranApp.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeRestoranApp.Entities.Mapping
{
    public class IstifadeciHereketleriMap : EntityTypeConfiguration<IstifadeciHereketleri>

    {
        public IstifadeciHereketleriMap()
        {
            this.ToTable("IstifadeciHereketleri");

            this.HasKey(p => p.Id);

            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Aciklama)
                .HasColumnType("nvarchar")
                .HasMaxLength(300);

            this.HasRequired(x => x.Istifadeciler)
                .WithMany(x => x.IstifadeciHereketleri)
                .HasForeignKey(x => x.IstifadeciID);

        }
    }
}

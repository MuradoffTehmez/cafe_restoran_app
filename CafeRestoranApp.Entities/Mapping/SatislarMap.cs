﻿using CafeRestoranApp.Entities.Models;
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
    public class SatislarMap : EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}

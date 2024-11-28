using CafeRestoranApp.Entities.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    public class CafeContext:DbContext
    {
        // Connection string - sistemin ürək döyüntüsü
        public CafeContext(): base("name =connection")
        {
            
        }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Urun> Urun { get; set; }

        public DbSet<Istifadeciler> Istifadeciler { get; set; }

        public DbSet<IstifadeciHereketleri> IstifadeciHereketleri { get; set; }

        public DbSet<Satislar> Satislar { get; set; }

        public DbSet<Modlar> Modlar { get; set; }

        public DbSet<Masalar> Masalar { get; set; }

        public DbSet<MasaHaraketleri> MasaHaraketleri { get; set; }

        public DbSet<OdenisTarixcesi> OdenisTarixcesi { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuMap());
            //base.OnModelCreating(modelBuilder);
        }

    }
}

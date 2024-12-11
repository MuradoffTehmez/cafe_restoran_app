using CafeRestoranApp.Entities.Mapping;
using System.Data.Entity;

namespace CafeRestoranApp.Entities.Models
{
    public class CafeContext : DbContext
    {

        public CafeContext() : base("name =connection")
        {
            // Connection string - sistemin ürək döyüntüsü
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

        public DbSet<SatisKodu> SatisKodu { get; set; }

        public DbSet<Musteriler> Musteriler { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IstifadeciHereketleriMap());
            modelBuilder.Configurations.Add(new IstifadecilerMap());
            modelBuilder.Configurations.Add(new MasaHaraketleriMap());
            modelBuilder.Configurations.Add(new MasalarMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new ModlarMap());
            modelBuilder.Configurations.Add(new OdenisTarixcesiMap());
            modelBuilder.Configurations.Add(new SatislarMap());
            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new SatisKoduMap());
            modelBuilder.Configurations.Add(new MusterilerMap());
        }

    }
}

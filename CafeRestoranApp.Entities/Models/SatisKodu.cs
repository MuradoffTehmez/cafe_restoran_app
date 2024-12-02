using CafeRestoranApp.Entities.Interfaces;

namespace CafeRestoranApp.Entities.Models
{
    public class SatisKodu : IEntity
    {
        public int Id { get; set; }

        public string SatisTanimi { get; set; }

        public int Sayi { get; set; }
    }
}

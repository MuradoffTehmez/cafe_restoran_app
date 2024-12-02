using CafeRestoranApp.Entities.Interfaces;
using System;

namespace CafeRestoranApp.Entities.Models
{
    public class OdenisTarixcesi : IEntity
    {
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public string OdemeTuru { get; set; }

        public decimal Odenis { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }
    }
}

using CafeRestoranApp.Entities.Interfaces;
using System;

namespace CafeRestoranApp.Entities.Models
{
    public class Satislar : IEntity
    {

        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public int? MusteriId { get; set; }

        public decimal Tutar { get; set; }

        public decimal EndirimToplam { get; set; }

        public decimal Odenis { get; set; }

        public decimal Qalan { get; set; }

        public string Aciklama { get; set; }

        public DateTime SonIslemTarixi { get; set; }

        public virtual Musteriler Musteriler { get; set; }

    }
}

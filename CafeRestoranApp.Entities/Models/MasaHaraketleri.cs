using CafeRestoranApp.Entities.Interfaces;
using System;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("MasaHaraketleri")]
    public class MasaHaraketleri : IEntity
    {
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public int MasaId { get; set; }

        public int MenuId { get; set; }

        public int UrunId { get; set; }

        public int Miqdari { get; set; }

        public decimal Qiymeti { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public Masalar Masalar { get; set; }


    }
}

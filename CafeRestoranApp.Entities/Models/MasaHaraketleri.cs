using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("MasaHaraketleri")]
    public class MasaHaraketleri : IEntity
    {
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public int MasaId { get; set; }

        public int Miqdari { get; set; }

        public decimal Qiymeti { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public Masalar Masalar { get; set; }


    }
}

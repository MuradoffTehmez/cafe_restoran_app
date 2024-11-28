using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("Satislar")]
    public class Satislar
    {
      
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public decimal Tutar { get; set; }

        public decimal Odenis { get; set; }

        public decimal Qalan { get; set; }

        public string Aciklama { get; set; }

        //public DateTime ElaveOlmaTarixi { get; set; }

        public DateTime SonIslemTarixi { get; set; }

        
    }
}

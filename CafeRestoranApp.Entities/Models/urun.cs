using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("Urun")]
    public class Urun
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Menu")]
        public int MeynuID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string UrunKodu { get; set; }

        public string Uruni { get; set; }

        public decimal Qiymet1 { get; set; }

        public decimal Qiymet2 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public virtual Menu Menu { get; set; }  

    }
}

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
    internal class urun
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Menu")]
        public int MeynuID { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string UrunKodu { get; set; }

        public string Uruni { get; set; }

        public decimal qiymet1 { get; set; }

        public decimal qiymet2 { get; set; }


    }
}

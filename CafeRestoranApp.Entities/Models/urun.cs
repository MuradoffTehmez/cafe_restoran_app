using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("Urun")]
    public class Urun
    {

        public int Id { get; set; }

        public int MeynuID { get; set; }

        public string UrunKodu { get; set; }

        public string UrunAdi { get; set; }

        public decimal Qiymet1 { get; set; }

        public decimal Qiymet2 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public Menu Menu { get; set; }

       
        
        
        
        //[Key]
        //[ForeignKey("Menu")]
        //[Column(TypeName = "varchar")]
        //[StringLength(50)]


        //public virtual Menu Menu { get; set; }  
    }
}

using CafeRestoranApp.Entities.Interfaces;
using System.Collections.Generic;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("Meyu")]
    public class Menu : IEntity
    {
        public int Id { get; set; }

        public string MenuAdi { get; set; }

        public string Aciklama { get; set; }


        public ICollection<Urun> Urun { get; set; }

        //public virtual ICollection<Urun> Urun { get; set; }

        /*
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        */

    }
}

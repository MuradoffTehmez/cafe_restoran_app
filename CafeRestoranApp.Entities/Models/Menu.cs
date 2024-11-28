using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("Meyu")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string MenuAdi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Aciklama { get; set; }
    }
}

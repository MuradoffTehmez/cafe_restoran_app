using CafeRestoranApp.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeRestoranApp.Entities.Models
{
    public class SatisKodu : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string SatisTanimi { get; set; }

        public int Sayi { get; set; }
    }
}

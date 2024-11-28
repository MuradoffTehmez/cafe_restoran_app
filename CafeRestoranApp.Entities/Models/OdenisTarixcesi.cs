using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    //[Table("OdenisTarixcesi")]
    public class OdenisTarixcesi
    {
        public int Id { get; set; }

        public string SatisKodu { get; set; }

        public string OdemeTuru { get; set; }

        public decimal Odenis {  get; set; }

        public string Aciklama {  get; set; }

        public DateTime Tarix {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("Masalar")]
    public class Masalar
    {
        public int Id { get; set; }

        public string MasaAdi { get; set; }

        public string Aciklama { get; set; }

        public bool Durumu {  get; set; }   

        public bool Rezervasiya {  get; set; }

        public DateTime ElaveOlmaTarixi { get; set; }

        public DateTime SonIslemTarixi { get; set; }


    }
}

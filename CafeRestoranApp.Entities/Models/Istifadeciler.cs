using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    [Table("Istifadeciler")]
    public class Istifadeciler
    {
        public int Id { get; set; }

        public string AdSoyad { get; set; }

        public string Telefon { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public string Vezifesi { get; set; }

        public string IstifadeciAdi { get; set; }

        public string Parol { get; set; }

        public string HatirlamaSuali { get; set; }

        public string Cavab { get; set; }

        public string Aciklama { get; set; }

        public DateTime KaytTarixi { get; set; }

        public bool IsDurumu { get; set; }


    }
}

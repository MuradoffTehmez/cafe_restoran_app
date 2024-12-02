using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeRestoranApp.Entities.Models
{
    public class Istifadeciler : IEntity
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

        public int FailedLoginAttempts { get; set; }

        public virtual ICollection<IstifadeciHereketleri> IstifadeciHereketleri { get; set; }

        public virtual ICollection<Masalar> Masalar { get; set; }

    }
}

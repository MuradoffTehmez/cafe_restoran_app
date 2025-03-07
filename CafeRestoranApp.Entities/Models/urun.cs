﻿using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeRestoranApp.Entities.Models
{
    public class Urun : IEntity
    {

        public int Id { get; set; }

        public int MeynuID { get; set; }

        public string UrunKodu { get; set; }

        public string UrunAdi { get; set; }

        public decimal Qiymet1 { get; set; }

        public decimal Qiymet2 { get; set; }

        public decimal Qiymet3 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarix { get; set; }

        public string Sekil { get; set; }

        public virtual Menu Menu { get; set; }

        public virtual ICollection<MasaHaraketleri> MasaHaraketleri { get; set; }

    }
}

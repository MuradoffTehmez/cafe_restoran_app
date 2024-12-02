using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    public class SatisKodu : IEntity
    {
        public int Id { get; set; }
        
        public string SatisTanimi { get; set; }
        
        public int Sayi { get; set; }
    }
}

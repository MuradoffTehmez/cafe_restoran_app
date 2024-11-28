using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Models
{
    public class CafeContext:DbContext
    {
        public CafeContext(): base("name =connection")
        {
            
        }

        public DbSet<Menu>Menu { get; set; }

        public DbSet<Urun> Urun { get; set; }


    }
}

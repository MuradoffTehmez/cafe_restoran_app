using CafeRestoranApp.Entities.Mapping;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.DAL
{
    public class IstifadeciHereketleriDAL : EntityRepositoryBase<CafeContext, IstifadeciHereketleri>
    {
        public static implicit operator IstifadeciHereketleriDAL(IstifadeciHereketleriMap v)
        {
            throw new NotImplementedException();
        }
    }
}

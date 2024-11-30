using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Repository;
using CafeRestoranApp.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.DAL
{
    public class UrunDAL : EntityRepositoryBase<CafeContext, Urun,UrunVALIDATOR>
    {
        public IEnumerable<dynamic> UrunListele(CafeContext context)
        {
            var liste = (from u in context.Urun
                select new
                {
                    u.Id,
                    u.MeynuID,
                    Menu = u.Menu.MenuAdi,
                    u.UrunKodu,
                    u.UrunAdi,
                    u.Qiymet1,
                    u.Qiymet2,
                    u.Qiymet3,
                    u.Aciklama,
                    u.Sekil,
                    u.Tarix
                }).ToList();

            return liste;
        }
        public Urun GetByProductCode(CafeContext context, string productCode)
        {
            return context.Urun.FirstOrDefault(u => u.UrunKodu == productCode);
        }
    }
}

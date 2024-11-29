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
        public object UrunListele(CafeContext context)
        {
            var liste = (from u in context.Urun
                select new
                {
                    u.Id,
                    u.MeynuID,
                    Menu =u.Menu.MenuAdi,
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

        /*
         var liste = (from u in context.Urun
                         select new UrunDTO
                         {
                             Id = u.Id,
                             MeynuID = u.MeynuID,
                             Menu = u.Menu != null ? u.Menu.MenuAdi : "Menü Adı Yok",  // Null kontrolü
                             UrunKodu = u.UrunKodu,
                             UrunAdi = u.UrunAdi,
                             Qiymet1 = u.Qiymet1,
                             Qiymet2 = u.Qiymet2,
                             Qiymet3 = u.Qiymet3,
                             Aciklama = u.Aciklama,
                             Sekil = u.Sekil,
                             Tarix = u.Tarix
                         }).ToList();

            return liste;
         */

    }
}

using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Repository;
using CafeRestoranApp.Entities.Validations;
using System.Linq;

namespace CafeRestoranApp.Entities.DAL
{
    public class MasalarDAL : EntityRepositoryBase<CafeContext, Masalar, MasalarVALIDATOR>
    {
        public object MasaListele(CafeContext context)
        {
            var model = (from masa in context.Masalar
                         join kullanici in context.Istifadeciler on masa.KullaniciId equals kullanici.Id
                             into iftideci
                         from
                             KullaniciMasa in iftideci.DefaultIfEmpty()
                         select new
                         {
                             masa.Id,
                             masa.MasaAdi,
                             masa.Aciklama,
                             masa.Durumu,
                             masa.Islem,
                             masa.Rezervasiya,
                             masa.ElaveOlmaTarixi,
                             masa.SonIslemTarixi,
                             kullanici = KullaniciMasa.IstifadeciAdi
                         }).ToList();
            return model;
        }
    }
}

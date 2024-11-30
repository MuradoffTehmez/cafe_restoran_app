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
    public class MasalarDAL : EntityRepositoryBase<CafeContext, Masalar,MasalarVALIDATOR>
    {
        public object MasaListele(CafeContext context)
        {
            var model = (from masa in context.Masalar join K in context.Istifadeciler.DefaultIfEmpty() on masa.KullaniciId equals K.Id
                
                select new
                {
                    masa.Aciklama,
                    masa.Durumu,
                    masa.ElaveOlmaTarixi,
                    masa.Id,
                    masa.Islem,
                    masa.KullaniciId,
                    masa.MasaAdi,
                    masa.Rezervasiya,
                    masa.SonIslemTarixi,
                    kullanici = K.IstifadeciAdi

                }).ToList();
            return model;
        }
    }
}

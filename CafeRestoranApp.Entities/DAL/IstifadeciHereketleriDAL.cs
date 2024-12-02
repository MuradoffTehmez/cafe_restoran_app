using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Repository;
using CafeRestoranApp.Entities.Validations;
using System;

namespace CafeRestoranApp.Entities.DAL
{
    public class IstifadeciHereketleriDAL : EntityRepositoryBase<CafeContext, IstifadeciHereketleri, IstifadeciHereketleriVALIDATOR>
    {
        //public static int istifadeciId { get; set; }

        public void IstifadeciHereketleriElaveEt(CafeContext context, IstifadeciHereketleri IstidaceciHereketleriEntity, string Aciklama)
        {

            IstifadeciHereketleriDAL isHereketleriDal = new IstifadeciHereketleriDAL();
            IstidaceciHereketleriEntity.Tarix = DateTime.Now;
            IstidaceciHereketleriEntity.Aciklama = Aciklama;
            if (isHereketleriDal.AddOrUpdate(context, IstidaceciHereketleriEntity))
            {
                isHereketleriDal.Save(context);
            }
        }
    }
}

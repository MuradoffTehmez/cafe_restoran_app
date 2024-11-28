using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class IstifadeciHereketleriVALIDATOR : AbstractValidator<IstifadeciHereketleri>
    {
        public IstifadeciHereketleriVALIDATOR()
        {
            // IstifadeciID
            RuleFor(x => x.IstifadeciID)
                .NotEmpty().WithMessage("İstifadəçi ID boş ola bilməz.")
                .GreaterThan(0).WithMessage("İstifadəçi ID sıfırdan böyük olmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .NotEmpty().WithMessage("Açıqlama sahəsi boş ola bilməz.")
                .Length(5, 500).WithMessage("Açıqlama 5 ilə 500 simvol arasında olmalıdır.");

            // Tarix
            RuleFor(x => x.Tarix)
                .NotEmpty().WithMessage("Tarix sahəsi boş ola bilməz.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tarix indiki tarixdən böyük ola bilməz.");

            // Istifadeciler
            RuleFor(x => x.Istifadeciler)
                .NotNull().WithMessage("İstifadəçi məlumatı boş ola bilməz.");
        }

    }
}

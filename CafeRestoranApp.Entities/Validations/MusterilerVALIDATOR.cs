using CafeRestoranApp.Entities.Models;
using FluentValidation;

namespace CafeRestoranApp.Entities.Validations
{
    public class MusterilerVALIDATOR : AbstractValidator<Musteriler>
    {

        public MusterilerVALIDATOR()
        {
            RuleFor(x => x.AdSoyad)
                .NotEmpty().WithMessage("Ad Soyad  boş ola bilməz.");

            RuleFor(x => x.Telefon)
                .NotEmpty().WithMessage("Telefon Xanisi boş ola bilməz.");
        }
    }
}

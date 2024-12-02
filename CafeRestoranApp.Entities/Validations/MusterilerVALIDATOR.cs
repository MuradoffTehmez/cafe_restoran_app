using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

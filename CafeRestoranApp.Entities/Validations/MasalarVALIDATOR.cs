using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class MasalarVALIDATOR : AbstractValidator<Masalar>
    {
        public MasalarVALIDATOR()
        {
            //// Id
            //RuleFor(x => x.Id)
            //    .GreaterThanOrEqualTo(0).WithMessage("ID sıfırdan kiçik ola bilməz.");

            // MasaAdi
            RuleFor(x => x.MasaAdi)
                .NotEmpty().WithMessage("Masa adı boş ola bilməz.")
                .Length(1, 50).WithMessage("Masa adı 1 ilə 50 simvol arasında olmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan çox ola bilməz.");

            // Durumu
            RuleFor(x => x.Durumu)
                .NotNull().WithMessage("Durumu boş ola bilməz.");

            // Rezervasiya
            RuleFor(x => x.Rezervasiya)
                .NotNull().WithMessage("Rezervasiya vəziyyəti boş ola bilməz.");

            // ElaveOlmaTarixi
            RuleFor(x => x.ElaveOlmaTarixi)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Əlavə olunma tarixi indiki vaxtdan sonra ola bilməz.");

            // SonIslemTarixi
            RuleFor(x => x.SonIslemTarixi)
                .GreaterThanOrEqualTo(x => x.ElaveOlmaTarixi)
                .WithMessage("Son əməliyyat tarixi, əlavə olunma tarixindən kiçik ola bilməz.");
        }
    }
}

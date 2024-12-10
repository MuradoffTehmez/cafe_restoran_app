using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;

namespace CafeRestoranApp.Entities.Validations
{
    public class OdenisTarixcesiVALIDATOR : AbstractValidator<OdenisTarixcesi>
    {
        public OdenisTarixcesiVALIDATOR()
        {
            // Id
            //RuleFor(x => x.Id)
            //.GreaterThanOrEqualTo(0).WithMessage("ID sıfırdan kiçik ola bilməz.");

            // SatisKodu
            //RuleFor(x => x.SatisKodu)
            //    .NotEmpty().WithMessage("Satış kodu boş ola bilməz.")
            //    .MaximumLength(50).WithMessage("Satış kodu 50 simvoldan uzun ola bilməz.");

            // OdemeTuru
            RuleFor(x => x.OdemeTuru)
                .NotEmpty().WithMessage("Ödəniş növü boş ola bilməz.")
                .MaximumLength(50).WithMessage("Ödəniş növü 50 simvoldan uzun ola bilməz.");

            // Odenis
            RuleFor(x => x.Odenis)
                .GreaterThan(0).WithMessage("Ödəniş məbləği sıfırdan böyük olmalıdır.")
                .PrecisionScale(18, 2, true).WithMessage("Ödəniş məbləği maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan uzun ola bilməz.");

            // Tarix
            RuleFor(x => x.Tarix)
                .NotEmpty().WithMessage("Tarix boş ola bilməz.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tarix gələcəkdə ola bilməz.");
        }
    }
}

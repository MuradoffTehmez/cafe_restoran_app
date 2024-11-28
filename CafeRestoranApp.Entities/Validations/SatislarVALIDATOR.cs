using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class SatislarVALIDATOR : AbstractValidator<Satislar>
    {
        public SatislarVALIDATOR()
        {
            // Id
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("ID sıfırdan böyük olmalıdır.");

            // SatisKodu
            RuleFor(x => x.SatisKodu)
                .NotEmpty().WithMessage("Satış kodu boş ola bilməz.")
                .MaximumLength(50).WithMessage("Satış kodu 50 simvoldan uzun ola bilməz.");

            // Tutar
            RuleFor(x => x.Tutar)
                .GreaterThan(0).WithMessage("Tutar sıfırdan böyük olmalıdır.")
                .PrecisionScale(18, 2, true).WithMessage("Tutar maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Odenis
            RuleFor(x => x.Odenis)
                .GreaterThanOrEqualTo(0).WithMessage("Ödəniş sıfır və ya daha böyük olmalıdır.")
                .LessThanOrEqualTo(x => x.Tutar).WithMessage("Ödəniş tutardan böyük ola bilməz.")
                .PrecisionScale(18, 2, true).WithMessage("Ödəniş maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Qalan
            RuleFor(x => x.Qalan)
                .GreaterThanOrEqualTo(0).WithMessage("Qalan sıfır və ya daha böyük olmalıdır.")
                .LessThanOrEqualTo(x => x.Tutar).WithMessage("Qalan məbləğ tutardan böyük ola bilməz.")
                .PrecisionScale(18, 2, true).WithMessage("Qalan maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan uzun ola bilməz.");

            // SonIslemTarixi
            RuleFor(x => x.SonIslemTarixi)
                .NotEmpty().WithMessage("Son əməliyyat tarixi boş ola bilməz.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Son əməliyyat tarixi gələcəkdə ola bilməz.");
        }
    }
}

using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class UrunVALIDATOR : AbstractValidator<Urun>
    {
        public UrunVALIDATOR()
        {
            // Id
            //RuleFor(x => x.Id)
              //  .GreaterThan(0).WithMessage("ID sıfırdan böyük olmalıdır.");

            // UrunKodu
            RuleFor(x => x.UrunKodu)
                .NotEmpty().WithMessage("Məhsul kodu boş ola bilməz.")
                .MaximumLength(50).WithMessage("Məhsul kodu 50 simvoldan uzun ola bilməz.");

            // UrunAdi
            RuleFor(x => x.UrunAdi)
                .NotEmpty().WithMessage("Məhsul adı boş ola bilməz.")
                .MaximumLength(100).WithMessage("Məhsul adı 100 simvoldan uzun ola bilməz.");

            // Qiymet1
            RuleFor(x => x.Qiymet1)
                .GreaterThan(0).WithMessage("Qiymət 1 sıfırdan böyük olmalıdır.")
                .PrecisionScale(18, 2, true).WithMessage("Qiymət 1 maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Qiymet2
            RuleFor(x => x.Qiymet2)
                .GreaterThan(0).WithMessage("Qiymət 2 sıfırdan böyük olmalıdır.")
                .PrecisionScale(18, 2, true).WithMessage("Qiymət 2 maksimum iki onluq rəqəmi ilə məhdudlaşdırılmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan uzun ola bilməz.");

            // Tarix
            RuleFor(x => x.Tarix)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tarix gələcəkdə ola bilməz.");

            // MeynuID (Menu ID)
            RuleFor(x => x.MeynuID)
                .GreaterThan(0).WithMessage("Menu ID sıfırdan böyük olmalıdır.");
        }
    }
}

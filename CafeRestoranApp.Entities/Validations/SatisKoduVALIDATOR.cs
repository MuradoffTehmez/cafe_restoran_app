using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class SatisKoduVALIDATOR : AbstractValidator<SatisKodu>
    {
        public SatisKoduVALIDATOR()
        {
            // Id sahəsinin müsbət bir dəyər olması tələb olunur
            //RuleFor(s => s.Id)
            //    .GreaterThan(0).WithMessage("Id 0-dan böyük olmalıdır.");

            // SatisTanimi sahəsi üçün qaydalar
            RuleFor(s => s.SatisTanimi)
                .NotEmpty().WithMessage("Satış tanımı boş buraxıla bilməz.")
                .Length(1, 20).WithMessage("Satış tanımı 1-20 simvol arasında olmalıdır.");

            //// Sayi sahəsi üçün qaydalar
            //RuleFor(s => s.Sayi)
            //    .GreaterThanOrEqualTo(0).WithMessage("Sayı sıfırdan az ola bilməz.");
        }
    }
}

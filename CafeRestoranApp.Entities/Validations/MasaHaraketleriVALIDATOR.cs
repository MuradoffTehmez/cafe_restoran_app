using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class MasaHaraketleriVALIDATOR : AbstractValidator<MasaHaraketleri>
    {
        public MasaHaraketleriVALIDATOR()
        {
            //// Id
            //RuleFor(x => x.Id)
            //    .GreaterThanOrEqualTo(0).WithMessage("ID sıfırdan kiçik ola bilməz.");

            // SatisKodu
            RuleFor(x => x.SatisKodu)
                .NotEmpty().WithMessage("Satış kodu boş ola bilməz.")
                .Length(1, 50).WithMessage("Satış kodu 1 ilə 50 simvol arasında olmalıdır.");

            // MasaId
            RuleFor(x => x.MasaId)
                .GreaterThan(0).WithMessage("Masa ID sıfırdan böyük olmalıdır.");

            // Miqdari
            RuleFor(x => x.Miqdari)
                .GreaterThan(0).WithMessage("Miqdar sıfırdan böyük olmalıdır.");

            // Qiymeti
            RuleFor(x => x.Qiymeti)
                .GreaterThan(0).WithMessage("Qiymət sıfırdan böyük olmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan çox ola bilməz.");

            // Tarix
            RuleFor(x => x.Tarix)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tarix indiki vaxtdan sonra ola bilməz.");
        }
    }
}

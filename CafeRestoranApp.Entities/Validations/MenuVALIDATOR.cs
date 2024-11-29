using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class MenuVALIDATOR : AbstractValidator<Menu>
    {
        public MenuVALIDATOR()
        {
            //// Id
              //   RuleFor(x => x.Id)
               // .GreaterThanOrEqualTo(0).WithMessage("ID sıfırdan kiçik ola bilməz.");

            // MenuAdi
                 RuleFor(x => x.MenuAdi)
                .NotEmpty().WithMessage("Menyu adı boş ola bilməz.")
                .MaximumLength(11).WithMessage("Menyu adı 11 simvol arasında olmalıdır.")
                .MinimumLength(4).WithMessage("Menyu adı 4 simvoldan az olmamalıdır.");

            //// Aciklama
                 RuleFor(x => x.Aciklama)
                .MaximumLength(200).WithMessage("Açıqlama 200 simvoldan çox ola bilməz.");

            //// Urun kolleksiyası
                 RuleFor(x => x.Urun)
                .NotNull().WithMessage("Menyuya aid məhsul siyahısı boş ola bilməz.")
                .Must(x => x.Count > 0).WithMessage("Menyuya ən azı bir məhsul əlavə olunmalıdır.");

        }
    }
}

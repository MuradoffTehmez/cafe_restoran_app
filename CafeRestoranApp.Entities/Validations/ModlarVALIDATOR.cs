using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class ModlarVALIDATOR : AbstractValidator<Modlar>
    {
        public ModlarVALIDATOR()
        {
            //// Id
            //RuleFor(x => x.Id)
            //    .GreaterThanOrEqualTo(0).WithMessage("ID sıfırdan kiçik ola bilməz.");

            // IstifadeciID
            RuleFor(x => x.IstifadeciID)
                .GreaterThan(0).WithMessage("İstifadəçi ID sıfırdan böyük olmalıdır.");

            // FormName
            RuleFor(x => x.FormName)
                .NotEmpty().WithMessage("Form adı boş ola bilməz.")
                .MaximumLength(100).WithMessage("Form adı 100 simvoldan uzun ola bilməz.");

            // ControlName
            RuleFor(x => x.ControlName)
                .NotEmpty().WithMessage("Kontrol adı boş ola bilməz.")
                .MaximumLength(100).WithMessage("Kontrol adı 100 simvoldan uzun ola bilməz.");

            // ControlCaption
            RuleFor(x => x.ControlCaption)
                .NotEmpty().WithMessage("Kontrol başlığı boş ola bilməz.")
                .MaximumLength(200).WithMessage("Kontrol başlığı 200 simvoldan uzun ola bilməz.");
        }
    }
}

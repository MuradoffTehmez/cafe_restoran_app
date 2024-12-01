using CafeRestoranApp.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Validations
{
    public class IstifadecilerVALIDATOR : AbstractValidator<Istifadeciler>
    {
        public IstifadecilerVALIDATOR()
        {
            // AdSoyad
            RuleFor(x => x.AdSoyad)
                .NotEmpty().WithMessage("Ad və Soyad sahəsi boş ola bilməz.")
                .Length(2, 100).WithMessage("Ad və Soyad 2 ilə 100 simvol arasında olmalıdır.");

            // Telefon
            RuleFor(x => x.Telefon)
                .NotEmpty().WithMessage("Telefon sahəsi boş ola bilməz.")
                .Matches(@"^\+994(50|51|55|60|70|77|99)\d{7}$").WithMessage("Telefon nömrəsi düzgün deyil. Məsələn: +994605536990");

            // Adress
            RuleFor(x => x.Adress)
                .NotEmpty().WithMessage("Ünvan sahəsi boş ola bilməz.")
                .Length(5, 200).WithMessage("Ünvan 5 ilə 200 simvol arasında olmalıdır.");

            // Email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email sahəsi boş ola bilməz.")
                .EmailAddress().WithMessage("Düzgün bir email ünvanı daxil edin.");

            // Vezifesi
            RuleFor(x => x.Vezifesi)
                .NotEmpty().WithMessage("Vəzifə sahəsi boş ola bilməz.")
                .Length(2, 50).WithMessage("Vəzifə 2 ilə 50 simvol arasında olmalıdır.");

            // IstifadeciAdi
            RuleFor(x => x.IstifadeciAdi)
                .NotEmpty().WithMessage("İstifadəçi adı sahəsi boş ola bilməz.")
                .Length(4, 20).WithMessage("İstifadəçi adı 4 ilə 20 simvol arasında olmalıdır.");

            // Parol
            RuleFor(x => x.Parol)
                .NotEmpty().WithMessage("Parol sahəsi boş ola bilməz.")
                .MinimumLength(8).WithMessage("Parol ən az 8 simvol uzunluğunda olmalıdır.");

            // HatirlamaSuali
            RuleFor(x => x.HatirlamaSuali)
                .NotEmpty().WithMessage("Xatırlama sualı sahəsi boş ola bilməz.")
                .Length(5, 100).WithMessage("Xatırlama sualı 5 ilə 100 simvol arasında olmalıdır.");

            // Cavab
            RuleFor(x => x.Cavab)
                .NotEmpty().WithMessage("Cavab sahəsi boş ola bilməz.")
                .Length(2, 100).WithMessage("Cavab 2 ilə 100 simvol arasında olmalıdır.");

            // Aciklama
            RuleFor(x => x.Aciklama)
                .Length(0, 500).WithMessage("Açıklama 500 simvoldan çox ola bilməz.");

            // KaytTarixi
            RuleFor(x => x.KaytTarixi)
                .NotEmpty().WithMessage("Qeydiyyat tarixi boş ola bilməz.");

            //// IsDurumu
            //RuleFor(x => x.IsDurumu)
            //    .NotNull().WithMessage("İş durumu boş ola bilməz.");
        }
    
    
    }
}


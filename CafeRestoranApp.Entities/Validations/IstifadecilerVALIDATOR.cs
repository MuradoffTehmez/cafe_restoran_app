using CafeRestoranApp.Entities.Models;
using FluentValidation;

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
                .MinimumLength(8).WithMessage("Parol ən az 8 simvol uzunluğunda olmalıdır.")
                .Matches(@"[A-Z]").WithMessage("Parol ən az bir böyük hərf içerməlidir.")
                .Matches(@"[a-z]").WithMessage("Parol ən az bir kiçik hərf içerməlidir.")
                .Matches(@"[0-9]").WithMessage("Parol ən az bir rəqəm içerməlidir.")
                .Matches(@"[\W_]").WithMessage("Parol ən az bir xüsusi simvol içerməlidir.");

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

            // FailedLoginAttempts
            RuleFor(x => x.FailedLoginAttempts)
                .GreaterThanOrEqualTo(0).WithMessage("FailedLoginAttempts dəyəri sıfırdan kiçik ola bilməz.");

        }

    }
}


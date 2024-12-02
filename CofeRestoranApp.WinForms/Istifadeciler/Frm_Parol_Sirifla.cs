using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Mapping;
using CafeRestoranApp.Entities.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Parol_Sirifla : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext _context;
        private IstifadecilerDAL _istifadecilerDal;
        private IstifadeciHereketleriDAL _istifadeciHereketleriDal;
        private IstifadeciHereketleri _entity;

        public Frm_Parol_Sirifla()
        {
            InitializeComponent();
            _context = new CafeContext();
            _istifadecilerDal = new IstifadecilerDAL();
            _istifadeciHereketleriDal = new IstifadeciHereketleriDAL();
            _entity = new IstifadeciHereketleri();
        }

        private void Frm_Parol_Sirifla_Load(object sender, EventArgs e)
        {
            // Form yükləndikdə ediləcək əməliyyatları buraya əlavə edin
        }

        private void Btn_Qeyd_Et_Click(object sender, EventArgs e)
        {
            if (!GirisSaheleriniYoxla()) return;

            try
            {
                // İstifadəçi adı və ya e-poçtla istifadəçi tapılmağa çalışılır
                var istifadeci = _istifadecilerDal.GetByFilter(_context,
                    user => user.IstifadeciAdi == Txt_Istifadeci_Adi.Text ||
                            user.Email == Txt_Istifadeci_Adi.Text);

                if (istifadeci == null)
                {
                    SehvGoster("Belə bir istifadəçi yoxdur");
                    return;
                }

                // Təhlükəsizlik sualı yoxlanır
                if (!TehlukesulikSualiniYoxla(istifadeci))
                {
                    SehvGoster("Sual və ya cavab düzgün deyil");
                    return;
                }

                // Şifrə yenilənir
                SifreniYenile(istifadeci);
            }
            catch (Exception ex)
            {
                SehvGoster($"Xəta baş verdi: {ex.Message}");
            }
        }

        private bool GirisSaheleriniYoxla()
        {
            if (string.IsNullOrWhiteSpace(Txt_Istifadeci_Adi.Text))
            {
                SehvGoster("İstifadəçi adı boş ola bilməz");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Sual.Text))
            {
                SehvGoster("Sual boş ola bilməz");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Cavab.Text))
            {
                SehvGoster("Cavab boş ola bilməz");
                return false;
            }

            return SifreniYoxla();
        }

        private bool SifreniYoxla()
        {
            if (string.IsNullOrWhiteSpace(Txt_Parol.Text))
            {
                SehvGoster("Şifrə boş ola bilməz");
                return false;
            }

            if (Txt_Parol.Text != Txt_Parol_Tekrar.Text)
            {
                SehvGoster("Şifrələr uyğun gəlmir");
                return false;
            }

            if (!SifreGuclumu(Txt_Parol.Text))
            {
                SehvGoster("Şifrə zəifdir. Ən az 8 simvol, böyük hərf, kiçik hərf və rəqəm olmalıdır.");
                return false;
            }

            return true;
        }

        private bool SifreGuclumu(string sifre)
        {
            return sifre.Length >= 8 &&
                   sifre.Any(char.IsUpper) &&
                   sifre.Any(char.IsLower) &&
                   sifre.Any(char.IsDigit);
        }

        private bool TehlukesulikSualiniYoxla(CafeRestoranApp.Entities.Models.Istifadeciler istifadeci)
        {
            return istifadeci.HatirlamaSuali == Txt_Sual.Text &&
                   istifadeci.Cavab == Txt_Cavab.Text;
        }

        private void SifreniYenile(CafeRestoranApp.Entities.Models.Istifadeciler istifadeci)
        {
            // Şifrə yenilənir
            istifadeci.Parol = Txt_Parol.Text;

            // İstifadəçi məlumatı əlavə və ya yenilənir
            if (_istifadecilerDal.AddOrUpdate(_context, istifadeci))
            {
                _istifadecilerDal.Save(_context);

                // İstifadəçi hərəkətləri qeyd edilir
                _entity.IstifadeciID = istifadeci.Id;
                string Aciklama = istifadeci.IstifadeciAdi + " adlı istifadəçinin parolu yeniləndi";
                _istifadeciHereketleriDal.IstifadeciHereketleriElaveEt(_context, _entity, Aciklama);

                MessageBox.Show("Şifrə uğurla dəyişdirildi", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                SehvGoster("Şifrə dəyişdirilərkən xəta baş verdi");
            }
        }

        private void SehvGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

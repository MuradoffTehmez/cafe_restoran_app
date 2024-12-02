using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Parol_Sirifla : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private IstifadecilerDAL istifadecilerDal = new IstifadecilerDAL();
        private  CafeContext _context;
        private  IstifadecilerDAL _istifadecilerDal;
        
        public Frm_Parol_Sirifla()
        {
            InitializeComponent();
            _context = new CafeContext();
            _istifadecilerDal = new IstifadecilerDAL();
        }

        private void Frm_Parol_Sirifla_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Qeyd_Et_Click(object sender, EventArgs e)
        {
            if (!GirisSaheleriniYoxla())
            {
                return;
            }

            try
            {
                
                var istifadeci = _istifadecilerDal.GetByFilter(_context,
                    user => user.IstifadeciAdi == Txt_Istifadeci_Adi.Text ||
                            user.Email == Txt_Istifadeci_Adi.Text);

                if (istifadeci == null)
                {
                    SehvGoster("Belə bir istifadəçi yoxdur");
                    return;
                }

                if (!TehlukesulikSualiniYoxla(istifadeci))
                {
                    SehvGoster("Sual və ya cavab düzgün deyil");
                    return;
                }

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

            if (!SifreniYoxla())
            {
                return false;
            }

            return true;
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

        
        private bool TehlukesulikSualiniYoxla(CafeRestoranApp.Entities.Models.Istifadeciler istifadeci)
        {
            return istifadeci.HatirlamaSuali == Txt_Sual.Text &&
                   istifadeci.Cavab == Txt_Cavab.Text;
        }

        
        private void SifreniYenile(CafeRestoranApp.Entities.Models.Istifadeciler istifadeci)
        {
            
            istifadeci.Parol = SifreniHash(Txt_Parol.Text);

            if (_istifadecilerDal.AddOrUpdate(_context, istifadeci))
            {
                _istifadecilerDal.Save(_context);
                MessageBox.Show("Şifrə uğurla dəyişdirildi", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                SehvGoster("Şifrə dəyişdirilərkən xəta baş verdi");
            }
        }

        
        private string SifreniHash(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private bool SifreGuclumu(string sifre)
        {
                    return sifre.Length >= 8 &&
                   sifre.Any(char.IsUpper) &&
                   sifre.Any(char.IsLower) &&
                   sifre.Any(char.IsDigit);
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
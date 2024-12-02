using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Istifadeci_Giris : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private CafeContext _context;
        private bool _girisUgurlu;

        //private bool giris;
        public Frm_Istifadeci_Giris()
        {
            InitializeComponent();
            _context = new CafeContext();
            IstifadeciniMelumatlariniYukle();
        }
        /// <summary>
        /// Əvvəlki istifadəçi məlumatlarını yükləyir
        /// </summary>
        private void IstifadeciniMelumatlariniYukle()
        {
            // Əvvəlki istifadəçi məlumatlarını yükləmə
            if (Properties.Settings.Default.BeniHatirla)
            {
                Txt_Kullanici_Adi.Text = Properties.Settings.Default.KullaniciAdi;
                Txt_Sifre.Text = Properties.Settings.Default.Parola;
                check_Yadda_Saxla.Checked = true;
            }
            else
            {
                // Əgər yadda saxlama seçili deyilsə, sahələri təmizlə
                Txt_Kullanici_Adi.Text = string.Empty;
                Txt_Sifre.Text = string.Empty;
                check_Yadda_Saxla.Checked = false;
            }
        }
        /*
         void MelumatGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                Txt_Kullanici_Adi.Text = Properties.Settings.Default.KullaniciAdi;
                Txt_Sifre.Text = Properties.Settings.Default.Parola;
                check_Yadda_Saxla.Checked = true;
            }
            else
            {
                Txt_Kullanici_Adi.Text = null;
                Txt_Sifre.Text = null;
                check_Yadda_Saxla.Checked = false;
            }
        }
        */

        /// <summary>
        /// İstifadəçi məlumatlarını qeyd edir
        /// </summary>
        private void IstifadeciniMelumatlariniQeydEt()
        {
            // Yadda saxlama seçimləri
            if (check_Yadda_Saxla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = Txt_Kullanici_Adi.Text;
                Properties.Settings.Default.Parola = Txt_Sifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                // Yadda saxlama söndürülərsə məlumatları təmizlə
                Properties.Settings.Default.KullaniciAdi = string.Empty;
                Properties.Settings.Default.Parola = string.Empty;
                Properties.Settings.Default.BeniHatirla = false;
            }

            // Parametrləri yadda saxla
            Properties.Settings.Default.Save();
        }
        /*
        void MelumatQeydEt()
        {
            if (check_Yadda_Saxla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = Txt_Kullanici_Adi.Text;
                Properties.Settings.Default.Parola= Txt_Sifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        */
        private void frm_Istifadeciler_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Çıxış düyməsi üzərində klik hadisəsi
        /// </summary>
        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            // Əgər giriş uğursuz olarsa proqramı bağla
            if (!_girisUgurlu)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Forma bağlanarkən baş verən hadisə
        /// </summary>
        private void Frm_Istifadeci_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Əgər giriş uğursuz olarsa proqramı bağla
            if (!_girisUgurlu)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Giriş düyməsi üzərində klik hadisəsi
        /// </summary>
        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            // Giriş məlumatlarını yoxla
            if (!GirisMelumatlariniYoxla())
            {
                return;
            }

            try
            {
                var istifadeci = _context.Istifadeciler
                    .FirstOrDefault(i => i.IstifadeciAdi == Txt_Kullanici_Adi.Text);

                if (istifadeci != null &&
                    BCrypt.Verify(Txt_Sifre.Text, istifadeci.Parol))
                {
                    _girisUgurlu = true;
                    IstifadeciniMelumatlariniQeydEt();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "İstifadəçi adı və ya şifrə yanlışdır.",
                        "Giriş xətası",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    $"Bir xəta baş verdi:\n{ex.Message}",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Logger.LogError(ex.Message, ex);
            }
            /*
            try
            {
                var user = context.Istifadeciler
                    .FirstOrDefault(i => i.IstifadeciAdi == Txt_Kullanici_Adi.Text && i.Parol == Txt_Sifre.Text);
                if (user != null)
                {
                    giris = true;  
                    MelumatQeydEt();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır.", "Giriş xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Logger.LogError(ex.Message, ex);
            }
            */
        }
        /// <summary>
        /// Giriş məlumatlarının düzgünlüyünü yoxlayır
        /// </summary>
        /// <returns>Məlumatlar düzgündürsə true, əks halda false</returns>
        private bool GirisMelumatlariniYoxla()
        {
            // Boş sahələri yoxla
            if (string.IsNullOrWhiteSpace(Txt_Kullanici_Adi.Text))
            {
                MessageBox.Show(
                    "İstifadəçi adı boş ola bilməz.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Sifre.Text))
            {
                MessageBox.Show(
                    "Şifrə boş ola bilməz.",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        /// <summary>
        /// Şifrəni dəyişdirmək üçün formanı açır
        /// </summary>
        private void Btn_Sifre_Deyis_Click(object sender, EventArgs e)
        {
            using (var frm = new Frm_Parol_Sirifla())
            {
                frm.ShowDialog();
            }
            //Frm_Parol_Sirifla frm = new Frm_Parol_Sirifla();
            //frm.ShowDialog();
        }

        /// <summary>
        /// Qeydiyyat formasını açır
        /// </summary>
        private void hyper_Qeydiyyat_Click(object sender, EventArgs e)
        {
            using (var frm = new Frm_Qeydiyyat(new CafeRestoranApp.Entities.Models.Istifadeciler()))
            {
                frm.ShowDialog();
            }
        }
    }
}
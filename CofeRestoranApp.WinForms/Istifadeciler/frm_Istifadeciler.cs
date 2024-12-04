using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;
using CofeRestoranApp.WinForms.WinTools;
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
        private IstifadeciHereketleriDAL istifadeciHereketleriDal = new IstifadeciHereketleriDAL();
        private IstifadeciHereketleri entity = new IstifadeciHereketleri();

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
            if (Properties.Settings.Default.BeniHatirla)
            {
                Txt_Kullanici_Adi.Text = Properties.Settings.Default.KullaniciAdi;
                Txt_Sifre.Text = Properties.Settings.Default.Parola;
                check_Yadda_Saxla.Checked = true;
            }
            else
            {
                Txt_Kullanici_Adi.Text = string.Empty;
                Txt_Sifre.Text = string.Empty;
                check_Yadda_Saxla.Checked = false;
            }
        }

        /// <summary>
        /// İstifadəçi məlumatlarını qeyd edir
        /// </summary>
        private void IstifadeciniMelumatlariniQeydEt()
        {
            if (check_Yadda_Saxla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = Txt_Kullanici_Adi.Text;
                Properties.Settings.Default.Parola = Txt_Sifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = string.Empty;
                Properties.Settings.Default.Parola = string.Empty;
                Properties.Settings.Default.BeniHatirla = false;
            }

            Properties.Settings.Default.Save();
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            if (!_girisUgurlu)
            {
                Application.Exit();
            }
        }

        private void Frm_Istifadeci_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            if (!GirisMelumatlariniYoxla())
            {
                return;
            }

            try
            {
                var istifadeci = _context.Istifadeciler
                    .FirstOrDefault(i => i.IstifadeciAdi == Txt_Kullanici_Adi.Text);

                if (istifadeci != null && istifadeci.Parol == Txt_Sifre.Text)
                {
                    _girisUgurlu = true;
                    IstifadeciniMelumatlariniQeydEt();
                    IstifadeciAyarlari.istifadciId = istifadeci.Id;
                    entity.IstifadeciID = istifadeci.Id;
                    string Aciklama = istifadeci.IstifadeciAdi + "  Adlı İstifacədi Sistemə Giriş Etdi";
                    istifadeciHereketleriDal.IstifadeciHereketleriElaveEt(context, entity, Aciklama);
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
        }

        /// <summary>
        /// Giriş məlumatlarının düzgünlüyünü yoxlayır
        /// </summary>
        private bool GirisMelumatlariniYoxla()
        {
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

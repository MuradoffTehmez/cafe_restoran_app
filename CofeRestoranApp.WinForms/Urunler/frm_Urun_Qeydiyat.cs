using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Urunler
{
    public partial class frm_Urun_Qeydiyat : DevExpress.XtraEditors.XtraForm
    {
        private MenuDAL menuDAL = new MenuDAL();
        private UrunDAL urunDAL = new UrunDAL();
        private Urun _entity;
        private CafeContext Context = new CafeContext();
        public bool Qeydet = false;

        public frm_Urun_Qeydiyat(Urun entity)
        {
            InitializeComponent();
            _entity = entity;

            if (_entity.Id!= 0)
            {
                if (_entity.Sekil != "")
                {
                    Foto_Resim_elave_et.Image = Image.FromFile(_entity.Sekil);
                }

                txt_Urun_Adi.Enabled = true;
                txt_Urun_kodu.Enabled = true;
                Cal_Qiymet_1.Enabled = true;
                Cal_Qiymet_2.Enabled = true;
                Cal_Qiymet_3.Enabled = true;
                txtR_Aciklama.Enabled = true;
                Date_Edit_Tarix.Enabled = true;
                Combo_Meynu_Secimi.Enabled = true;

            }

            Combo_Meynu_Secimi.Properties.DataSource = menuDAL.GetAll(Context);
            Combo_Meynu_Secimi.DataBindings.Add("EditValue", _entity, "MeynuID");
            txt_Urun_Adi.DataBindings.Add("Text", _entity, "UrunAdi");
            txt_Urun_kodu.DataBindings.Add("Text", _entity, "UrunKodu");
            Cal_Qiymet_1.DataBindings.Add("Text", _entity, "Qiymet1",true);
            Cal_Qiymet_2.DataBindings.Add("Text", _entity, "Qiymet2",true);
            Cal_Qiymet_3.DataBindings.Add("Text", _entity, "Qiymet3", true);
            txtR_Aciklama.DataBindings.Add("Text", _entity, "Aciklama");
            Date_Edit_Tarix.DataBindings.Add("Text", _entity, "Tarix", true);
        }

        private void frm_Urun_Qeydiyat_Load(object sender, EventArgs e)
        {
        }

        private void brn_Mehsul_Elave_Et_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                try
                {
                    // Şəkil qovluğunu yoxla və mövcud deyilsə yarat
                    string imagePath = $"{Application.StartupPath}\\Image";
                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }

                    // Şəkil faylını saxlamaq üçün yol təyin edilir
                    string hedefyol = $"{imagePath}\\{txt_Urun_Adi.Text}-{txt_Urun_kodu.Text}.png";

                    // Şəkil seçilib-seçilmədiyini yoxla
                    if (string.IsNullOrEmpty(Foto_Resim_elave_et.GetLoadedImageLocation()))
                    {
                        MessageBox.Show("Zəhmət olmasa şəkil seçin.");
                        return;
                    }

                    // Fayl artıq mövcuddursa, istifadəçiyə xəbərdarlıq göstər
                    if (File.Exists(hedefyol))
                    {
                        MessageBox.Show("Bu fayl artıq mövcuddur.");
                        return;
                    }

                    // Məhsul artıq mövcud deyilsə
                    if (_entity.Id == 0)
                    {
                        // Şəkil faylını köçürmək
                        File.Copy(Foto_Resim_elave_et.GetLoadedImageLocation(), hedefyol);

                        // Şəkil yolunu `Sekil` sahəsinə əlavə etmək
                        _entity.Sekil = $"Image\\{txt_Urun_Adi.Text}-{txt_Urun_kodu.Text}.png";

                        // Məhsul əlavə olunur
                        urunDAL.AddorUpdate(Context, _entity);
                        urunDAL.Save(Context);
                        Qeydet = true;

                        MessageBox.Show("Məhsul uğurla saxlanıldı!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Məhsul artıq mövcuddur.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Məhsul saxlanarkən xəta baş verdi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün tələb olunan sahələri doldurun.");
            }
        }
        private bool IsValid()
        {
            // Formdakı bütün tələb olunan sahələrin yoxlanması
            bool isValid =
                !string.IsNullOrWhiteSpace(txt_Urun_Adi.Text) &&
                !string.IsNullOrWhiteSpace(txt_Urun_kodu.Text) &&
                Combo_Meynu_Secimi.EditValue != null &&
                !string.IsNullOrWhiteSpace(Cal_Qiymet_1.Text) &&
                !string.IsNullOrWhiteSpace(Cal_Qiymet_2.Text) &&
                !string.IsNullOrWhiteSpace(Cal_Qiymet_3.Text) &&
                !string.IsNullOrWhiteSpace(txtR_Aciklama.Text) &&
                !string.IsNullOrWhiteSpace(Date_Edit_Tarix.Text);

            if (!isValid)
            {
                MessageBox.Show("Zəhmət olmasa bütün tələb olunan sahələri doldurun.");
            }

            return isValid;
        }


        private void txt_Urun_Adi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
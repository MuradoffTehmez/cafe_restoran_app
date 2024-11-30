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

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity nesnesi boş olamaz.");
            }

            _entity = entity;

            if (_entity.Id != 0)
            {
                if (_entity.Sekil != null)
                {
                    try
                    {
                        Foto_Resim_elave_et.Image = Image.FromFile(_entity.Sekil);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Sekil faylı tapılmadı.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            Cal_Qiymet_1.DataBindings.Add("Text", _entity, "Qiymet1", true);
            Cal_Qiymet_2.DataBindings.Add("Text", _entity, "Qiymet2", true);
            Cal_Qiymet_3.DataBindings.Add("Text", _entity, "Qiymet3", true);
            txtR_Aciklama.DataBindings.Add("Text", _entity, "Aciklama");

            Date_Edit_Tarix.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"; 
            Date_Edit_Tarix.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;

           
            Date_Edit_Tarix.DataBindings.Add("EditValue", _entity, "Tarix", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void frm_Urun_Qeydiyat_Load(object sender, EventArgs e)
        {
            Date_Edit_Tarix.EditValue = DateTime.Now;
        }

        private void brn_Mehsul_Elave_Et_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                try
                {
                    string imagePath = $"{Application.StartupPath}\\Image";
                    if (!Directory.Exists(imagePath))
                    {
                        Directory.CreateDirectory(imagePath);
                    }
                    string hedefyol = $"{imagePath}\\{txt_Urun_Adi.Text}-{txt_Urun_kodu.Text}.png";

                    if (string.IsNullOrEmpty(Foto_Resim_elave_et.GetLoadedImageLocation()))
                    {
                        MessageBox.Show("Zəhmət olmasa şəkil seçin.");
                        return;
                    }
                    string fileExtension = Path.GetExtension(Foto_Resim_elave_et.GetLoadedImageLocation()).ToLower();
                    if (fileExtension != ".jpg" && fileExtension != ".png" && fileExtension != ".jpeg")
                    {
                        MessageBox.Show("Yalnız JPG, PNG və JPEG şəkil formatları dəstəklənir.");
                        return;
                    }

                    var image = Image.FromFile(Foto_Resim_elave_et.GetLoadedImageLocation());
                    if (image.Width > 2000 || image.Height > 2000)
                    {
                        MessageBox.Show("Şəkilin ölçüsü çox böyükdür. Zəhmət olmasa daha kiçik ölçülü şəkil seçin.");
                        return;
                    }

                    var existingProduct = urunDAL.GetByProductCode(Context, _entity.UrunKodu);
                    if (existingProduct != null && _entity.Id == 0)
                    {
                        MessageBox.Show("Bu məhsul artıq mövcuddur.");
                        return;
                    }

                    if (_entity.Id != 0 && !string.IsNullOrEmpty(_entity.Sekil))
                    {
                        string eskiSekilYolu = Path.Combine(Application.StartupPath, _entity.Sekil);
                        if (File.Exists(eskiSekilYolu))
                        {
                            File.Delete(eskiSekilYolu);
                        }
                    }

                    if (File.Exists(hedefyol))
                    {
                        MessageBox.Show("Bu fayl artıq mövcuddur.");
                        return;
                    }

                    if (_entity.Id == 0)
                    {
                        File.Copy(Foto_Resim_elave_et.GetLoadedImageLocation(), hedefyol);
                        _entity.Sekil = $"Image\\{txt_Urun_Adi.Text}-{txt_Urun_kodu.Text}.png";
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
                    MessageBox.Show("Məhsul saxlanarkən bir xəta baş verdi. Xəta detalı: " + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün tələb olunan sahələri doldurun.");
            }
        }
        private bool IsValid()
        { 
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
    }
}
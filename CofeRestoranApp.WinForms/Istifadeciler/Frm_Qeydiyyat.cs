using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Qeydiyyat : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private IstifadecilerDAL istifadecilerDal = new IstifadecilerDAL();
        private CafeRestoranApp.Entities.Models.Istifadeciler _entity;
        private IstifadeciHereketleri isHereketleri = new IstifadeciHereketleri();
        private IstifadeciHereketleriDAL isHereketleriDal = new IstifadeciHereketleriDAL();

        public Frm_Qeydiyyat(CafeRestoranApp.Entities.Models.Istifadeciler entity)
        {
            InitializeComponent();
            _entity = entity ?? new CafeRestoranApp.Entities.Models.Istifadeciler(); // Null yoxlama əlavə edildi
            toggleAktiv.DataBindings.Add("EditValue", _entity, "IsDurumu");
            Txt_Ad_Soyad.DataBindings.Add("Text", _entity, "AdSoyad");
            Txt_Telefon.DataBindings.Add("Text", _entity, "Telefon");
            TxtB_Ulvan.DataBindings.Add("Text", _entity, "Adress");
            Txt_Email.DataBindings.Add("Text", _entity, "Email");
            Txt_Vezifesi.DataBindings.Add("Text", _entity, "Vezifesi");
            Txt_Istifadeci_Adi.DataBindings.Add("Text", _entity, "IstifadeciAdi");
            Txt_Parol.DataBindings.Add("Text", _entity, "Parol");
            Txt_Sual.DataBindings.Add("Text", _entity, "HatirlamaSuali");
            Txt_Cavab.DataBindings.Add("Text", _entity, "Cavab");
            TxtB_Melumat.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void Btn_Qeydiyyat_Click(object sender, EventArgs e)
        {
            try
            {
                // Şifrə və şifrə təkrarı uyğundurmu yoxlanır
                if (Txt_Parol.Text == Txt_Parol_Tekrar.Text)
                {
                    // Əgər _entity null-dursa, yeni obyekt təyin olunur
                    if (_entity == null)
                    {
                        MessageBox.Show("İstifadəçi məlumatı düzgün alınmadı.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _entity.KaytTarixi = DateTime.Now;

                    if (istifadecilerDal.AddOrUpdate(context, _entity))
                    {
                        istifadecilerDal.Save(context);
                        var model = context.Istifadeciler.Max(i => i.Id);
                        isHereketleri.IstifadeciID = model;
                        string aciklama = "Yeni Istifadeci Elave olundu";
                        isHereketleriDal.IstifadeciHereketleriElaveEt(context, isHereketleri, aciklama);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Qeydiyyat zamanı xəta baş verdi.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Şifrə və ya şifrə təkrarı uyğun deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir xəta baş verdi:\n{ex.Message}\n\nSətir məlumatı:\n{ex.StackTrace}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogInfo(ex.Message, ex);
            }
        }

        private void Btn_Cixis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

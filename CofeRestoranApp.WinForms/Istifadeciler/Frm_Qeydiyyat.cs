using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CafeRestoranApp.Entities.Utilities;

namespace CofeRestoranApp.WinForms.Istifadeciler
{
    public partial class Frm_Qeydiyyat : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private IstifadecilerDAL istifadecilerDal = new IstifadecilerDAL();
        private CafeRestoranApp.Entities.Models.Istifadeciler _entity;
        public bool kaydet = false;

        public Frm_Qeydiyyat(CafeRestoranApp.Entities.Models.Istifadeciler entity)
        {
            InitializeComponent();
            _entity = entity;
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
                if (Txt_Parol.Text == Txt_Parol_Tekrar.Text)
                {
                    _entity.KaytTarixi = DateTime.Now;
                    if (istifadecilerDal.AddOrUpdate(context, _entity))
                    {
                        istifadecilerDal.Save(context);
                        kaydet = true;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır.", "Giriş xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
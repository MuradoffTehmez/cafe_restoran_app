using AngleSharp.Dom;
using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
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
            Combo_Meynu_Secimi.Properties.DataSource = menuDAL.GetAll(Context);
            Combo_Meynu_Secimi.DataBindings.Add("EditValue", _entity, "MeynuID");
            txt_Urun_Adi.DataBindings.Add("Text", _entity, "UrunAdi");
            txt_Urun_kodu.DataBindings.Add("Text", _entity, "UrunKodu");
            Cal_Qiymet_1.DataBindings.Add("Text", _entity, "Qiymet1",true);
            Cal_Qiymet_2.DataBindings.Add("Text", _entity, "Qiymet2",true);
            Cal_Qiymet_3.DataBindings.Add("Text", _entity, "Qiymet3", true);
            txtR_Aciklama.DataBindings.Add("Text", _entity, "Aciklama");
            Date_Edit_Tarix.DataBindings.Add("Text", _entity, "Tarix");



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
                    if (urunDAL.AddorUpdate(Context, _entity))
                    {
                        urunDAL.Save(Context);
                        Qeydet = true;
                        MessageBox.Show("Məhsul uğurla saxlanıldı!");
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

                   return

                   !string.IsNullOrWhiteSpace(txt_Urun_Adi.Text) &&
                   !string.IsNullOrWhiteSpace(txt_Urun_kodu.Text) &&
                   Combo_Meynu_Secimi.EditValue != null &&
                   !string.IsNullOrWhiteSpace(Cal_Qiymet_1.Text) &&
                   !string.IsNullOrWhiteSpace(Cal_Qiymet_2.Text) &&
                   !string.IsNullOrWhiteSpace(Cal_Qiymet_3.Text) &&
                   !string.IsNullOrWhiteSpace(txtR_Aciklama.Text) &&
                   !string.IsNullOrWhiteSpace(Date_Edit_Tarix.Text);
        }

        private void txt_Urun_Adi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
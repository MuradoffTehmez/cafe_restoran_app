using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;
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

            if (_entity.Id == 0)
            {
              
                txt_Urun_Adi.Enabled = true;
                txt_Urun_kodu.Enabled = true;
                Cal_Qiymet_1.Enabled = true;
                Cal_Qiymet_2.Enabled = true;
                Cal_Qiymet_3.Enabled = true;
                txtR_Aciklama.Enabled = true;
                Date_Edit_Tarix.Enabled = true;
                Combo_Meynu_Secimi.Enabled = true;

            }
            else
            {
               // txt_Urun_Adi.Enabled = false;
                txt_Urun_kodu.Enabled = false;
              //  Cal_Qiymet_1.Enabled = false;
              //  Cal_Qiymet_2.Enabled = false;
              //  Cal_Qiymet_3.Enabled = false;
              //  txtR_Aciklama.Enabled = false;
             //   Date_Edit_Tarix.Enabled = false;
              //  Combo_Meynu_Secimi.Enabled = false;

                
            }

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
                    
                    if (_entity.Id == 0)
                    {
                       
                        urunDAL.AddorUpdate(Context, _entity);
                        urunDAL.Save(Context);
                        Qeydet = true;
                        MessageBox.Show("Məhsul uğurla saxlanıldı!");
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
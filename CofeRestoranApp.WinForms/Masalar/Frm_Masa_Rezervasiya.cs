using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using CofeRestoranApp.WinForms.WinTools;
using System;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Rezervasiya : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemyapildi;
        private CafeRestoranApp.Entities.Models.Masalar masalar;
        private MasalarDAL masalarDal = new MasalarDAL();
        CafeContext context = new CafeContext();

        public Frm_Masa_Rezervasiya(int masaId)
        {
            InitializeComponent();
            _masaId = masaId;
        }

        private void Btn_Tesdiqle_Click(object sender, EventArgs e)
        {
            masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            masalar.Islem = txtR_Proses.Text;
            masalar.SonIslemTarixi = Convert.ToDateTime(dateTarix.EditValue);
            masalar.KullaniciId = IstifadeciAyarlari.istifadciId;
            masalar.Rezervasiya = true;
            masalarDal.Save(context);
            islemyapildi = true;
            this.Close();
        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
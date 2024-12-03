using CafeRestoranApp.Entities.DAL;
using CafeRestoranApp.Entities.Models;
using System;

namespace CofeRestoranApp.WinForms.Masalar
{
    public partial class Frm_Masa_Siparis : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDAL musterilerDAL = new MusterilerDAL();
        private int? _masaId = null;

        public Frm_Masa_Siparis(int? masaId = null, string masaadi = null, string satiskodu = null)
        {
            InitializeComponent();
            _masaId = masaId;
            lookUpMusteri.Properties.DataSource = musterilerDAL.GetAll(context);
            if (_masaId != null)
            {
                Lbn_Basliq.Text = masaadi + "  Siparisleri";
            }
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btn_cisix_et_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

        }

        private void OdenisSİlGr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void Btn_Yeni_Sifaris_Click(object sender, EventArgs e)
        {

        }
    }
}
using CofeRestoranApp.WinForms.Istifadeciler;
using CofeRestoranApp.WinForms.Masalar;
using CofeRestoranApp.WinForms.Menular;
using CofeRestoranApp.WinForms.Urunler;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;

namespace CofeRestoranApp.WinForms.AnaMenu
{
    public partial class Frm_Ana_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }
        public Frm_Ana_Form()
        {
            InitializeComponent();
            XtraForm frm = new Frm_Istifadeci_Giris();
            frm.ShowDialog();
        }

        private void Frm_Ana_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Meynular_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new Frm_Menu();
            FormGetir(frm);
        }

        private void btn_Urunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frm_Urunler();
            FormGetir(frm);
        }

        private void btn_Masalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new Frm_Masalar();
            FormGetir(frm);
        }

        private void btn_Masa_Haraketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Btn_Masa_Sifaris_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new Frm_Masa_Durumu();
            FormGetir(frm);
        }
    }
}